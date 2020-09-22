using DataUpdatesExample;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeginEndDataUpdateExample
{
    public class BeginEndUpdateViewModel : UpdateViewModelBase
    {
        public IGridUpdateService GridUpdateService {
            get { return this.GetService<IGridUpdateService>(); }
        }
        protected override void ConfigureSettings() {
            dataSourceSize = 5000;
            groupsCount = dataSourceSize / 30;
            setAllRowValuesOnUpdate = true;
            collectionUpdatesPerSecond = dataSourceSize;
            rowUpdatesPerSecond = dataSourceSize;
        }
        protected override void UpdateData(object sender, EventArgs e) {
            GridUpdateService.BeginDataUpdate();
            UpdateDataCore();
            GridUpdateService.EndDataUpdate();
        }
    }
}
