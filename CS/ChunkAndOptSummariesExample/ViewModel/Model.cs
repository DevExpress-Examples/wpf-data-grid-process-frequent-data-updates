using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataUpdatesExample
{
    public class Device : INotifyPropertyChanged, INotifyPropertyChanging
    {
        string name;
        string group;
        int sensor1, sensor2, sensor3, sensor4, sensor5, sensor6, sensor7, sensor8, sensor9, sensor10, sensor11, sensor12, sensor13, sensor14, sensor15, sensor16, sensor17, sensor18, sensor19, sensor20, sensor21, sensor22, sensor23, sensor24, sensor25, sensor26, sensor27, sensor28, sensor29, sensor30, sensor31;
        static Random rnd = new Random();

        public string Name {
            get {
                return name;
            }
            set {
                RaisePropertyChanging(nameof(Name));
                name = value;
                RaisePropertyChanged(nameof(Name));
            }
        }
        public string Group {
            get {
                return group;
            }
            set {
                RaisePropertyChanging(nameof(Group));
                group = value;
                RaisePropertyChanged(nameof(Group));
            }
        }
        public int Sensor1 {
            get {
                return sensor1;
            }
            set {
                RaisePropertyChanging(nameof(Sensor1));
                sensor1 = value;
                RaisePropertyChanged(nameof(Sensor1));
            }
        }
        public int Sensor2 {
            get {
                return sensor2;
            }
            set {
                RaisePropertyChanging(nameof(Sensor2));
                sensor2 = value;
                RaisePropertyChanged(nameof(Sensor2));
            }
        }
        public int Sensor3 {
            get {
                return sensor3;
            }
            set {
                RaisePropertyChanging(nameof(Sensor3));
                sensor3 = value;
                RaisePropertyChanged(nameof(Sensor3));
            }
        }
        public int Sensor4 {
            get {
                return sensor4;
            }
            set {
                RaisePropertyChanging(nameof(Sensor4));
                sensor4 = value;
                RaisePropertyChanged(nameof(Sensor4));
            }
        }
        public int Sensor5 {
            get {
                return sensor5;
            }
            set {
                RaisePropertyChanging(nameof(Sensor5));
                sensor5 = value;
                RaisePropertyChanged(nameof(Sensor5));
            }
        }
        public int Sensor6 {
            get {
                return sensor6;
            }
            set {
                RaisePropertyChanging(nameof(Sensor6));
                sensor6 = value;
                RaisePropertyChanged(nameof(Sensor6));
            }
        }
        public int Sensor7 {
            get {
                return sensor7;
            }
            set {
                RaisePropertyChanging(nameof(Sensor7));
                sensor7 = value;
                RaisePropertyChanged(nameof(Sensor7));
            }
        }
        public int Sensor8 {
            get {
                return sensor8;
            }
            set {
                RaisePropertyChanging(nameof(Sensor8));
                sensor8 = value;
                RaisePropertyChanged(nameof(Sensor8));
            }
        }
        public int Sensor9 {
            get {
                return sensor9;
            }
            set {
                RaisePropertyChanging(nameof(Sensor9));
                sensor9 = value;
                RaisePropertyChanged(nameof(Sensor9));
            }
        }
        public int Sensor10 {
            get {
                return sensor10;
            }
            set {
                RaisePropertyChanging(nameof(Sensor10));
                sensor10 = value;
                RaisePropertyChanged(nameof(Sensor10));
            }
        }
        public int Sensor11 {
            get {
                return sensor11;
            }
            set {
                RaisePropertyChanging(nameof(Sensor11));
                sensor11 = value;
                RaisePropertyChanged(nameof(Sensor11));
            }
        }
        public int Sensor12 {
            get {
                return sensor12;
            }
            set {
                RaisePropertyChanging(nameof(Sensor12));
                sensor12 = value;
                RaisePropertyChanged(nameof(Sensor12));
            }
        }
        public int Sensor13 {
            get {
                return sensor13;
            }
            set {
                RaisePropertyChanging(nameof(Sensor13));
                sensor13 = value;
                RaisePropertyChanged(nameof(Sensor13));
            }
        }
        public int Sensor14 {
            get {
                return sensor14;
            }
            set {
                RaisePropertyChanging(nameof(Sensor14));
                sensor14 = value;
                RaisePropertyChanged(nameof(Sensor14));
            }
        }
        public int Sensor15 {
            get {
                return sensor15;
            }
            set {
                RaisePropertyChanging(nameof(Sensor15));
                sensor15 = value;
                RaisePropertyChanged(nameof(Sensor15));
            }
        }
        public int Sensor16 {
            get {
                return sensor16;
            }
            set {
                RaisePropertyChanging(nameof(Sensor16));
                sensor16 = value;
                RaisePropertyChanged(nameof(Sensor16));
            }
        }
        public int Sensor17 {
            get {
                return sensor17;
            }
            set {
                RaisePropertyChanging(nameof(Sensor17));
                sensor17 = value;
                RaisePropertyChanged(nameof(Sensor17));
            }
        }
        public int Sensor18 {
            get {
                return sensor18;
            }
            set {
                RaisePropertyChanging(nameof(Sensor18));
                sensor18 = value;
                RaisePropertyChanged(nameof(Sensor18));
            }
        }
        public int Sensor19 {
            get {
                return sensor19;
            }
            set {
                RaisePropertyChanging(nameof(Sensor19));
                sensor19 = value;
                RaisePropertyChanged(nameof(Sensor19));
            }
        }
        public int Sensor20 {
            get {
                return sensor20;
            }
            set {
                RaisePropertyChanging(nameof(Sensor20));
                sensor20 = value;
                RaisePropertyChanged(nameof(Sensor20));
            }
        }
        public int Sensor21 {
            get {
                return sensor21;
            }
            set {
                RaisePropertyChanging(nameof(Sensor21));
                sensor21 = value;
                RaisePropertyChanged(nameof(Sensor21));
            }
        }
        public int Sensor22 {
            get {
                return sensor22;
            }
            set {
                RaisePropertyChanging(nameof(Sensor22));
                sensor22 = value;
                RaisePropertyChanged(nameof(Sensor22));
            }
        }
        public int Sensor23 {
            get {
                return sensor23;
            }
            set {
                RaisePropertyChanging(nameof(Sensor23));
                sensor23 = value;
                RaisePropertyChanged(nameof(Sensor23));
            }
        }
        public int Sensor24 {
            get {
                return sensor24;
            }
            set {
                RaisePropertyChanging(nameof(Sensor24));
                sensor24 = value;
                RaisePropertyChanged(nameof(Sensor24));
            }
        }
        public int Sensor25 {
            get {
                return sensor25;
            }
            set {
                RaisePropertyChanging(nameof(Sensor25));
                sensor25 = value;
                RaisePropertyChanged(nameof(Sensor25));
            }
        }
        public int Sensor26 {
            get {
                return sensor26;
            }
            set {
                RaisePropertyChanging(nameof(Sensor26));
                sensor26 = value;
                RaisePropertyChanged(nameof(Sensor26));
            }
        }
        public int Sensor27 {
            get {
                return sensor27;
            }
            set {
                RaisePropertyChanging(nameof(Sensor27));
                sensor27 = value;
                RaisePropertyChanged(nameof(Sensor27));
            }
        }
        public int Sensor28 {
            get {
                return sensor28;
            }
            set {
                RaisePropertyChanging(nameof(Sensor28));
                sensor28 = value;
                RaisePropertyChanged(nameof(Sensor28));
            }
        }
        public int Sensor29 {
            get {
                return sensor29;
            }
            set {
                RaisePropertyChanging(nameof(Sensor29));
                sensor29 = value;
                RaisePropertyChanged(nameof(Sensor29));
            }
        }
        public int Sensor30 {
            get {
                return sensor30;
            }
            set {
                RaisePropertyChanging(nameof(Sensor30));
                sensor30 = value;
                RaisePropertyChanged(nameof(Sensor30));
            }
        }
        public int Sensor31 {
            get {
                return sensor31;
            }
            set {
                RaisePropertyChanging(nameof(Sensor31));
                sensor31 = value;
                RaisePropertyChanged(nameof(Sensor31));
            }
        }


        protected void RaisePropertyChanged(string propertyName) {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        protected void RaisePropertyChanging(string propertyName) {
            PropertyChanging?.Invoke(this, new PropertyChangingEventArgs(propertyName));
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public event PropertyChangingEventHandler PropertyChanging;

        public void SetRandomSensorValues(bool all) {
            Sensor1 = rnd.Next(100, 1000);
            Sensor2 = rnd.Next(100, 1000);
            Sensor3 = rnd.Next(100, 1000);
            if (all) {
                Sensor4 = rnd.Next(100, 1000);
                Sensor5 = rnd.Next(100, 1000);
                Sensor6 = rnd.Next(100, 1000);
                Sensor7 = rnd.Next(100, 1000);
                Sensor8 = rnd.Next(100, 1000);
                Sensor9 = rnd.Next(100, 1000);
                Sensor10 = rnd.Next(100, 1000);
                Sensor11 = rnd.Next(100, 1000);
                Sensor12 = rnd.Next(100, 1000);
                Sensor13 = rnd.Next(100, 1000);
                Sensor14 = rnd.Next(100, 1000);
                Sensor15 = rnd.Next(100, 1000);
                Sensor16 = rnd.Next(100, 1000);
                Sensor17 = rnd.Next(100, 1000);
                Sensor18 = rnd.Next(100, 1000);
                Sensor19 = rnd.Next(100, 1000);
                Sensor20 = rnd.Next(100, 1000);
                Sensor21 = rnd.Next(100, 1000);
                Sensor22 = rnd.Next(100, 1000);
                Sensor23 = rnd.Next(100, 1000);
                Sensor25 = rnd.Next(100, 1000);
                Sensor26 = rnd.Next(100, 1000);
                Sensor27 = rnd.Next(100, 1000);
                Sensor28 = rnd.Next(100, 1000);
                Sensor29 = rnd.Next(100, 1000);
                Sensor30 = rnd.Next(100, 1000);
                Sensor31 = rnd.Next(100, 1000);
            }
        }
    }
}
