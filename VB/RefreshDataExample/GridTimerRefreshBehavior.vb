Imports DevExpress.Mvvm.UI.Interactivity
Imports DevExpress.Xpf.Grid
Imports System
Imports System.Windows.Threading

Namespace RefreshDataExample

    Public Class GridTimerRefreshBehavior
        Inherits Behavior(Of GridControl)

        Private refreshTimer As DispatcherTimer = New DispatcherTimer()

        Protected Overrides Sub OnAttached()
            MyBase.OnAttached()
            refreshTimer.Interval = New TimeSpan(0, 0, 0, 0, 1000)
            AddHandler refreshTimer.Tick, AddressOf RefreshTimer_Tick
            refreshTimer.Start()
        End Sub

        Private Sub RefreshTimer_Tick(ByVal sender As Object, ByVal e As EventArgs)
            AssociatedObject.RefreshData()
        End Sub
    End Class
End Namespace
