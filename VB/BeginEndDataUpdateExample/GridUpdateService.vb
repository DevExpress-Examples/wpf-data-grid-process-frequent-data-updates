Imports DevExpress.Mvvm.UI
Imports DevExpress.Xpf.Grid
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Namespace BeginEndDataUpdateExample
	Public Class GridUpdateService
		Inherits ServiceBase
		Implements IGridUpdateService

		Protected ReadOnly Property Grid() As GridControl
			Get
				Return CType(AssociatedObject, GridControl)
			End Get
		End Property
		Public Sub BeginDataUpdate() Implements IGridUpdateService.BeginDataUpdate
			Grid.BeginDataUpdate()
		End Sub

		Public Sub EndDataUpdate() Implements IGridUpdateService.EndDataUpdate
			Grid.EndDataUpdate()
		End Sub
	End Class

	Public Interface IGridUpdateService
		Sub BeginDataUpdate()
		Sub EndDataUpdate()
	End Interface
End Namespace
