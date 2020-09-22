using DataUpdatesExample;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefreshDataExample
{
    public class RefreshDataViewModel : UpdateViewModelBase
    {
        protected override void ConfigureSettings() {
            dataSourceSize = 5000;
            groupsCount = dataSourceSize / 30;
            setAllRowValuesOnUpdate = true;
            collectionUpdatesPerSecond = dataSourceSize;
            rowUpdatesPerSecond = dataSourceSize;
        }
        protected override IList<Device> CreateSourceCollection() {
            return new List<Device>();
        }
    }
}
