using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UiComponent1.ViewModel
{
    public class MotorViewModel : INotifyPropertyChanged
    {

        public MotorViewModel()
        {
            Name = "M410";
            CurrentValue = "117 A";
        }

        private string _motorName;

        public string Name
        {
            get { return _motorName; }
            set
            {
                _motorName = value;
                OnPropertyChanged("Name");
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


        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
