using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UiComponent1.ViewModel
{
    public class CurrentMotorViewModel : INotifyPropertyChanged
    {

        public CurrentMotorViewModel()
        {
            IsOnOf = true;
            GateName = "G303";
            MotorName = "M303";
            CurrentValue = "0 A";
            CurrentSetting = "320";
        }

        private bool? _isOnOf;

        public bool? IsOnOf
        {
            get { return _isOnOf; }
            set
            {
                _isOnOf = value;
                OnPropertyChanged("IsOnOf");
            }
        }

        private string _gateName;

        public string GateName
        {
            get { return _gateName; }
            set
            {
                _gateName = value;
                OnPropertyChanged("GateName");
            }
        }

        private string _motorName;

        public string MotorName
        {
            get { return _motorName; }
            set
            {
                _motorName = value;
                OnPropertyChanged("MotorName");
            }
        }

        private string _currentValue;

        public string CurrentValue
        {
            get { return _currentValue; }
            set
            {
                _currentValue = value;
                OnPropertyChanged("CurrentValue");
            }
        }

        private string _currentSetting;

        public string CurrentSetting
        {
            get { return _currentSetting; }
            set
            {
                _currentSetting = value;
                OnPropertyChanged("CurrentSetting");
            }
        }



        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
