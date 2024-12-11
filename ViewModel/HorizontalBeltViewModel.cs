using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UiComponent1.ViewModel
{
    public class HorizontalBeltViewModel : INotifyPropertyChanged
    {
        public HorizontalBeltViewModel()
        {
            MotorName = "M324";
            IsOnOf = true;
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

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
