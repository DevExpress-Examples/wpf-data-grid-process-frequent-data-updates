using DevExpress.Mvvm.UI.Interactivity;
using DevExpress.Xpf.Grid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Threading;

namespace RefreshDataExample
{
    public class GridTimerRefreshBehavior : Behavior<GridControl>
    {
        DispatcherTimer refreshTimer = new DispatcherTimer();
        protected override void OnAttached() {
            base.OnAttached();
            refreshTimer.Interval = new TimeSpan(0, 0, 0, 0, 1000);
            refreshTimer.Tick += RefreshTimer_Tick;
            refreshTimer.Start();
        }

        private void RefreshTimer_Tick(object sender, EventArgs e) {
            AssociatedObject.RefreshData();
        }
    }
}
