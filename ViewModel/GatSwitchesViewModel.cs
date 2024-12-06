using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UiComponent1.ViewModel
{
    public class GatSwitchesViewModel : INotifyPropertyChanged
    {
        public GatSwitchesViewModel()
        {
            Name = "G301";
            IsOnOf = true;
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

        private bool _isOnOf;

        public bool IsOnOf
        {
            get { return _isOnOf; }
            set
            {
                _isOnOf = value;
                OnPropertyChanged("IsOnOf");
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
