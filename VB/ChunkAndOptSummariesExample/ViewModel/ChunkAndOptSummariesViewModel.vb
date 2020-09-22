Imports DevExpress.Xpf.ChunkList
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Namespace DataUpdatesExample
	Public Class ChunkAndOptSummariesViewModel
		Inherits UpdateViewModelBase

		Protected Overrides Sub ConfigureSettings()
			dataSourceSize = 1000000
			groupsCount = 100
			setAllRowValuesOnUpdate = False
			collectionUpdatesPerSecond = 200
			rowUpdatesPerSecond = 500
		End Sub
		Protected Overrides Function CreateSourceCollection() As IList(Of Device)
			Return New ChunkList(Of Device)(dataSourceSize)
		End Function
	End Class
End Namespace
