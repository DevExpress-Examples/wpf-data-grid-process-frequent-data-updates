Imports DataUpdatesExample
Imports System.Collections.Generic

Namespace RefreshDataExample

    Public Class RefreshDataViewModel
        Inherits UpdateViewModelBase

        Protected Overrides Sub ConfigureSettings()
            dataSourceSize = 5000
            groupsCount = dataSourceSize \ 30
            setAllRowValuesOnUpdate = True
            collectionUpdatesPerSecond = dataSourceSize
            rowUpdatesPerSecond = dataSourceSize
        End Sub

        Protected Overrides Function CreateSourceCollection() As IList(Of Device)
            Return New List(Of Device)()
        End Function
    End Class
End Namespace
