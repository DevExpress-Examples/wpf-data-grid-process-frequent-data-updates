using DevExpress.Mvvm;
using DataUpdatesExample;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Threading;

namespace DataUpdatesExample
{
    public class UpdateViewModelBase : ViewModelBase
    {
        protected int dataSourceSize;
        protected int groupsCount;
        protected int collectionUpdatesPerSecond;
        protected int rowUpdatesPerSecond;
        protected bool setAllRowValuesOnUpdate;
        Random rnd = new Random();
        DispatcherTimer updateTimer = new DispatcherTimer();
        IList<Device> devices;
        public IList<Device> Devices {
            get {
                return devices;
            }
            set {
                devices = value;
                RaisePropertyChanged("Devices");
            }
        }

        public UpdateViewModelBase() {
            ConfigureSettings();
            SetUpdateTimer();
            GenerateData();
        }
        protected virtual void ConfigureSettings() {

        }
        void OnUseChunkListChanged() {
            updateTimer.Stop();
            GenerateData();
            updateTimer.Start();
        }

        void SetUpdateTimer() {
            updateTimer.Interval = new TimeSpan(0, 0, 0, 0, 1000);
            updateTimer.Tick += UpdateData;
            updateTimer.Start();
        }
        protected virtual void UpdateData(object sender, EventArgs e) {
            UpdateDataCore();
        }
        protected void UpdateDataCore() {
            ModifyCollectionCore();
            ModifyDataItemsCore();
        }
        void ModifyCollectionCore() {
            for (int i = 0; i < collectionUpdatesPerSecond; i++) {
                int index = rnd.Next(0, Devices.Count);
                if (index % 2 == 0 && Devices.Count > 0)
                    Devices.RemoveAt(index);
                else {
                    Device newDevice = new Device() { Name = "Device" + i, Group = "Group" + i % groupsCount };
                    newDevice.SetRandomSensorValues(setAllRowValuesOnUpdate);
                    Devices.Insert(index, newDevice);
                }
            }
        }
        void ModifyDataItemsCore() {
            for (int i = 0; i < rowUpdatesPerSecond; i++) {
                Devices[rnd.Next(0, Devices.Count - 1)].SetRandomSensorValues(setAllRowValuesOnUpdate);
            }
        }
        void GenerateData() {
            IList<Device> newList = CreateSourceCollection();
            Random rnd = new Random();
            for (int i = 0; i < dataSourceSize; i++) {
                Device newDevice = new Device() { Name = "Device" + i, Group = "Group" + i % groupsCount };
                newDevice.SetRandomSensorValues(setAllRowValuesOnUpdate);
                newList.Add(newDevice);
            }
            Devices = newList;
        }
        protected virtual IList<Device> CreateSourceCollection() {
            return new List<Device>();
        }
    }
}
