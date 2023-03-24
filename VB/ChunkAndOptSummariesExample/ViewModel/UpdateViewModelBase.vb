Imports DevExpress.Mvvm
Imports System
Imports System.Collections.Generic
Imports System.Windows.Threading

Namespace DataUpdatesExample

    Public Class UpdateViewModelBase
        Inherits ViewModelBase

        Protected dataSourceSize As Integer

        Protected groupsCount As Integer

        Protected collectionUpdatesPerSecond As Integer

        Protected rowUpdatesPerSecond As Integer

        Protected setAllRowValuesOnUpdate As Boolean

        Private rnd As Random = New Random()

        Private updateTimer As DispatcherTimer = New DispatcherTimer()

        Private devicesField As IList(Of Device)

        Public Property Devices As IList(Of Device)
            Get
                Return devicesField
            End Get

            Set(ByVal value As IList(Of Device))
                devicesField = value
                RaisePropertyChanged("Devices")
            End Set
        End Property

        Public Sub New()
            ConfigureSettings()
            SetUpdateTimer()
            GenerateData()
        End Sub

        Protected Overridable Sub ConfigureSettings()
        End Sub

        Private Sub OnUseChunkListChanged()
            updateTimer.Stop()
            GenerateData()
            updateTimer.Start()
        End Sub

        Private Sub SetUpdateTimer()
            updateTimer.Interval = New TimeSpan(0, 0, 0, 0, 1000)
            AddHandler updateTimer.Tick, AddressOf UpdateData
            updateTimer.Start()
        End Sub

        Protected Overridable Sub UpdateData(ByVal sender As Object, ByVal e As EventArgs)
            UpdateDataCore()
        End Sub

        Protected Sub UpdateDataCore()
            ModifyCollectionCore()
            ModifyDataItemsCore()
        End Sub

        Private Sub ModifyCollectionCore()
            For i As Integer = 0 To collectionUpdatesPerSecond - 1
                Dim index As Integer = rnd.Next(0, Devices.Count)
                If index Mod 2 = 0 AndAlso Devices.Count > 0 Then
                    Devices.RemoveAt(index)
                Else
                    Dim newDevice As Device = New Device() With {.Name = "Device" & i, .Group = "Group" & i Mod groupsCount}
                    newDevice.SetRandomSensorValues(setAllRowValuesOnUpdate)
                    Devices.Insert(index, newDevice)
                End If
            Next
        End Sub

        Private Sub ModifyDataItemsCore()
            For i As Integer = 0 To rowUpdatesPerSecond - 1
                Devices(rnd.Next(0, Devices.Count - 1)).SetRandomSensorValues(setAllRowValuesOnUpdate)
            Next
        End Sub

        Private Sub GenerateData()
            Dim newList As IList(Of Device) = CreateSourceCollection()
            Dim rnd As Random = New Random()
            For i As Integer = 0 To dataSourceSize - 1
                Dim newDevice As Device = New Device() With {.Name = "Device" & i, .Group = "Group" & i Mod groupsCount}
                newDevice.SetRandomSensorValues(setAllRowValuesOnUpdate)
                newList.Add(newDevice)
            Next

            Devices = newList
        End Sub

        Protected Overridable Function CreateSourceCollection() As IList(Of Device)
            Return New List(Of Device)()
        End Function
    End Class
End Namespace
