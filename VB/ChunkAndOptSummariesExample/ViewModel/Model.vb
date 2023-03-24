Imports System
Imports System.ComponentModel

Namespace DataUpdatesExample

    Public Class Device
        Implements INotifyPropertyChanged, INotifyPropertyChanging

        Private nameField As String

        Private groupField As String

        Private sensor1Field, sensor2Field, sensor3Field, sensor4Field, sensor5Field, sensor6Field, sensor7Field, sensor8Field, sensor9Field, sensor10Field, sensor11Field, sensor12Field, sensor13Field, sensor14Field, sensor15Field, sensor16Field, sensor17Field, sensor18Field, sensor19Field, sensor20Field, sensor21Field, sensor22Field, sensor23Field, sensor24Field, sensor25Field, sensor26Field, sensor27Field, sensor28Field, sensor29Field, sensor30Field, sensor31Field As Integer

        Private Shared rnd As Random = New Random()

        Public Property Name As String
            Get
                Return nameField
            End Get

            Set(ByVal value As String)
                RaisePropertyChanging(NameOf(Device.Name))
                nameField = value
                RaisePropertyChanged(NameOf(Device.Name))
            End Set
        End Property

        Public Property Group As String
            Get
                Return groupField
            End Get

            Set(ByVal value As String)
                RaisePropertyChanging(NameOf(Device.Group))
                groupField = value
                RaisePropertyChanged(NameOf(Device.Group))
            End Set
        End Property

        Public Property Sensor1 As Integer
            Get
                Return sensor1Field
            End Get

            Set(ByVal value As Integer)
                RaisePropertyChanging(NameOf(Device.Sensor1))
                sensor1Field = value
                RaisePropertyChanged(NameOf(Device.Sensor1))
            End Set
        End Property

        Public Property Sensor2 As Integer
            Get
                Return sensor2Field
            End Get

            Set(ByVal value As Integer)
                RaisePropertyChanging(NameOf(Device.Sensor2))
                sensor2Field = value
                RaisePropertyChanged(NameOf(Device.Sensor2))
            End Set
        End Property

        Public Property Sensor3 As Integer
            Get
                Return sensor3Field
            End Get

            Set(ByVal value As Integer)
                RaisePropertyChanging(NameOf(Device.Sensor3))
                sensor3Field = value
                RaisePropertyChanged(NameOf(Device.Sensor3))
            End Set
        End Property

        Public Property Sensor4 As Integer
            Get
                Return sensor4Field
            End Get

            Set(ByVal value As Integer)
                RaisePropertyChanging(NameOf(Device.Sensor4))
                sensor4Field = value
                RaisePropertyChanged(NameOf(Device.Sensor4))
            End Set
        End Property

        Public Property Sensor5 As Integer
            Get
                Return sensor5Field
            End Get

            Set(ByVal value As Integer)
                RaisePropertyChanging(NameOf(Device.Sensor5))
                sensor5Field = value
                RaisePropertyChanged(NameOf(Device.Sensor5))
            End Set
        End Property

        Public Property Sensor6 As Integer
            Get
                Return sensor6Field
            End Get

            Set(ByVal value As Integer)
                RaisePropertyChanging(NameOf(Device.Sensor6))
                sensor6Field = value
                RaisePropertyChanged(NameOf(Device.Sensor6))
            End Set
        End Property

        Public Property Sensor7 As Integer
            Get
                Return sensor7Field
            End Get

            Set(ByVal value As Integer)
                RaisePropertyChanging(NameOf(Device.Sensor7))
                sensor7Field = value
                RaisePropertyChanged(NameOf(Device.Sensor7))
            End Set
        End Property

        Public Property Sensor8 As Integer
            Get
                Return sensor8Field
            End Get

            Set(ByVal value As Integer)
                RaisePropertyChanging(NameOf(Device.Sensor8))
                sensor8Field = value
                RaisePropertyChanged(NameOf(Device.Sensor8))
            End Set
        End Property

        Public Property Sensor9 As Integer
            Get
                Return sensor9Field
            End Get

            Set(ByVal value As Integer)
                RaisePropertyChanging(NameOf(Device.Sensor9))
                sensor9Field = value
                RaisePropertyChanged(NameOf(Device.Sensor9))
            End Set
        End Property

        Public Property Sensor10 As Integer
            Get
                Return sensor10Field
            End Get

            Set(ByVal value As Integer)
                RaisePropertyChanging(NameOf(Device.Sensor10))
                sensor10Field = value
                RaisePropertyChanged(NameOf(Device.Sensor10))
            End Set
        End Property

        Public Property Sensor11 As Integer
            Get
                Return sensor11Field
            End Get

            Set(ByVal value As Integer)
                RaisePropertyChanging(NameOf(Device.Sensor11))
                sensor11Field = value
                RaisePropertyChanged(NameOf(Device.Sensor11))
            End Set
        End Property

        Public Property Sensor12 As Integer
            Get
                Return sensor12Field
            End Get

            Set(ByVal value As Integer)
                RaisePropertyChanging(NameOf(Device.Sensor12))
                sensor12Field = value
                RaisePropertyChanged(NameOf(Device.Sensor12))
            End Set
        End Property

        Public Property Sensor13 As Integer
            Get
                Return sensor13Field
            End Get

            Set(ByVal value As Integer)
                RaisePropertyChanging(NameOf(Device.Sensor13))
                sensor13Field = value
                RaisePropertyChanged(NameOf(Device.Sensor13))
            End Set
        End Property

        Public Property Sensor14 As Integer
            Get
                Return sensor14Field
            End Get

            Set(ByVal value As Integer)
                RaisePropertyChanging(NameOf(Device.Sensor14))
                sensor14Field = value
                RaisePropertyChanged(NameOf(Device.Sensor14))
            End Set
        End Property

        Public Property Sensor15 As Integer
            Get
                Return sensor15Field
            End Get

            Set(ByVal value As Integer)
                RaisePropertyChanging(NameOf(Device.Sensor15))
                sensor15Field = value
                RaisePropertyChanged(NameOf(Device.Sensor15))
            End Set
        End Property

        Public Property Sensor16 As Integer
            Get
                Return sensor16Field
            End Get

            Set(ByVal value As Integer)
                RaisePropertyChanging(NameOf(Device.Sensor16))
                sensor16Field = value
                RaisePropertyChanged(NameOf(Device.Sensor16))
            End Set
        End Property

        Public Property Sensor17 As Integer
            Get
                Return sensor17Field
            End Get

            Set(ByVal value As Integer)
                RaisePropertyChanging(NameOf(Device.Sensor17))
                sensor17Field = value
                RaisePropertyChanged(NameOf(Device.Sensor17))
            End Set
        End Property

        Public Property Sensor18 As Integer
            Get
                Return sensor18Field
            End Get

            Set(ByVal value As Integer)
                RaisePropertyChanging(NameOf(Device.Sensor18))
                sensor18Field = value
                RaisePropertyChanged(NameOf(Device.Sensor18))
            End Set
        End Property

        Public Property Sensor19 As Integer
            Get
                Return sensor19Field
            End Get

            Set(ByVal value As Integer)
                RaisePropertyChanging(NameOf(Device.Sensor19))
                sensor19Field = value
                RaisePropertyChanged(NameOf(Device.Sensor19))
            End Set
        End Property

        Public Property Sensor20 As Integer
            Get
                Return sensor20Field
            End Get

            Set(ByVal value As Integer)
                RaisePropertyChanging(NameOf(Device.Sensor20))
                sensor20Field = value
                RaisePropertyChanged(NameOf(Device.Sensor20))
            End Set
        End Property

        Public Property Sensor21 As Integer
            Get
                Return sensor21Field
            End Get

            Set(ByVal value As Integer)
                RaisePropertyChanging(NameOf(Device.Sensor21))
                sensor21Field = value
                RaisePropertyChanged(NameOf(Device.Sensor21))
            End Set
        End Property

        Public Property Sensor22 As Integer
            Get
                Return sensor22Field
            End Get

            Set(ByVal value As Integer)
                RaisePropertyChanging(NameOf(Device.Sensor22))
                sensor22Field = value
                RaisePropertyChanged(NameOf(Device.Sensor22))
            End Set
        End Property

        Public Property Sensor23 As Integer
            Get
                Return sensor23Field
            End Get

            Set(ByVal value As Integer)
                RaisePropertyChanging(NameOf(Device.Sensor23))
                sensor23Field = value
                RaisePropertyChanged(NameOf(Device.Sensor23))
            End Set
        End Property

        Public Property Sensor24 As Integer
            Get
                Return sensor24Field
            End Get

            Set(ByVal value As Integer)
                RaisePropertyChanging(NameOf(Device.Sensor24))
                sensor24Field = value
                RaisePropertyChanged(NameOf(Device.Sensor24))
            End Set
        End Property

        Public Property Sensor25 As Integer
            Get
                Return sensor25Field
            End Get

            Set(ByVal value As Integer)
                RaisePropertyChanging(NameOf(Device.Sensor25))
                sensor25Field = value
                RaisePropertyChanged(NameOf(Device.Sensor25))
            End Set
        End Property

        Public Property Sensor26 As Integer
            Get
                Return sensor26Field
            End Get

            Set(ByVal value As Integer)
                RaisePropertyChanging(NameOf(Device.Sensor26))
                sensor26Field = value
                RaisePropertyChanged(NameOf(Device.Sensor26))
            End Set
        End Property

        Public Property Sensor27 As Integer
            Get
                Return sensor27Field
            End Get

            Set(ByVal value As Integer)
                RaisePropertyChanging(NameOf(Device.Sensor27))
                sensor27Field = value
                RaisePropertyChanged(NameOf(Device.Sensor27))
            End Set
        End Property

        Public Property Sensor28 As Integer
            Get
                Return sensor28Field
            End Get

            Set(ByVal value As Integer)
                RaisePropertyChanging(NameOf(Device.Sensor28))
                sensor28Field = value
                RaisePropertyChanged(NameOf(Device.Sensor28))
            End Set
        End Property

        Public Property Sensor29 As Integer
            Get
                Return sensor29Field
            End Get

            Set(ByVal value As Integer)
                RaisePropertyChanging(NameOf(Device.Sensor29))
                sensor29Field = value
                RaisePropertyChanged(NameOf(Device.Sensor29))
            End Set
        End Property

        Public Property Sensor30 As Integer
            Get
                Return sensor30Field
            End Get

            Set(ByVal value As Integer)
                RaisePropertyChanging(NameOf(Device.Sensor30))
                sensor30Field = value
                RaisePropertyChanged(NameOf(Device.Sensor30))
            End Set
        End Property

        Public Property Sensor31 As Integer
            Get
                Return sensor31Field
            End Get

            Set(ByVal value As Integer)
                RaisePropertyChanging(NameOf(Device.Sensor31))
                sensor31Field = value
                RaisePropertyChanged(NameOf(Device.Sensor31))
            End Set
        End Property

        Protected Sub RaisePropertyChanged(ByVal propertyName As String)
            RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
        End Sub

        Protected Sub RaisePropertyChanging(ByVal propertyName As String)
            RaiseEvent PropertyChanging(Me, New PropertyChangingEventArgs(propertyName))
        End Sub

        Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged

        Public Event PropertyChanging As PropertyChangingEventHandler Implements INotifyPropertyChanging.PropertyChanging

        Public Sub SetRandomSensorValues(ByVal all As Boolean)
            Sensor1 = rnd.Next(100, 1000)
            Sensor2 = rnd.Next(100, 1000)
            Sensor3 = rnd.Next(100, 1000)
            If all Then
                Sensor4 = rnd.Next(100, 1000)
                Sensor5 = rnd.Next(100, 1000)
                Sensor6 = rnd.Next(100, 1000)
                Sensor7 = rnd.Next(100, 1000)
                Sensor8 = rnd.Next(100, 1000)
                Sensor9 = rnd.Next(100, 1000)
                Sensor10 = rnd.Next(100, 1000)
                Sensor11 = rnd.Next(100, 1000)
                Sensor12 = rnd.Next(100, 1000)
                Sensor13 = rnd.Next(100, 1000)
                Sensor14 = rnd.Next(100, 1000)
                Sensor15 = rnd.Next(100, 1000)
                Sensor16 = rnd.Next(100, 1000)
                Sensor17 = rnd.Next(100, 1000)
                Sensor18 = rnd.Next(100, 1000)
                Sensor19 = rnd.Next(100, 1000)
                Sensor20 = rnd.Next(100, 1000)
                Sensor21 = rnd.Next(100, 1000)
                Sensor22 = rnd.Next(100, 1000)
                Sensor23 = rnd.Next(100, 1000)
                Sensor25 = rnd.Next(100, 1000)
                Sensor26 = rnd.Next(100, 1000)
                Sensor27 = rnd.Next(100, 1000)
                Sensor28 = rnd.Next(100, 1000)
                Sensor29 = rnd.Next(100, 1000)
                Sensor30 = rnd.Next(100, 1000)
                Sensor31 = rnd.Next(100, 1000)
            End If
        End Sub
    End Class
End Namespace
