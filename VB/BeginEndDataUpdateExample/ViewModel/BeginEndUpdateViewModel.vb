Imports DataUpdatesExample
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Namespace BeginEndDataUpdateExample
	Public Class BeginEndUpdateViewModel
		Inherits UpdateViewModelBase

		Public ReadOnly Property GridUpdateService() As IGridUpdateService
			Get
				Return Me.GetService(Of IGridUpdateService)()
			End Get
		End Property
		Protected Overrides Sub ConfigureSettings()
			dataSourceSize = 5000
			groupsCount = dataSourceSize \ 30
			setAllRowValuesOnUpdate = True
			collectionUpdatesPerSecond = dataSourceSize
			rowUpdatesPerSecond = dataSourceSize
		End Sub
		Protected Overrides Sub UpdateData(ByVal sender As Object, ByVal e As EventArgs)
			GridUpdateService.BeginDataUpdate()
			UpdateDataCore()
			GridUpdateService.EndDataUpdate()
		End Sub
	End Class
End Namespace
