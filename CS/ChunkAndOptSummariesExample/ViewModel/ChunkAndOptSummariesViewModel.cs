using DevExpress.Xpf.ChunkList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataUpdatesExample
{
    public class ChunkAndOptSummariesViewModel : UpdateViewModelBase
    {
        protected override void ConfigureSettings() {
            dataSourceSize = 1000000;
            groupsCount = 100;
            setAllRowValuesOnUpdate = false;
            collectionUpdatesPerSecond = 200;
            rowUpdatesPerSecond = 500;
        }
        protected override IList<Device> CreateSourceCollection() {
            return new ChunkList<Device>(dataSourceSize);
        }
    }
}
