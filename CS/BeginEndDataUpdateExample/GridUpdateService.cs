using DevExpress.Mvvm.UI;
using DevExpress.Xpf.Grid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeginEndDataUpdateExample
{
    public class GridUpdateService : ServiceBase, IGridUpdateService
    {
        protected GridControl Grid {
            get {
                return (GridControl)AssociatedObject;
            }
        }
        public void BeginDataUpdate() {
            Grid.BeginDataUpdate();
        }

        public void EndDataUpdate() {
            Grid.EndDataUpdate();
        }
    }

    public interface IGridUpdateService
    {
        void BeginDataUpdate();
        void EndDataUpdate();
    }
}
