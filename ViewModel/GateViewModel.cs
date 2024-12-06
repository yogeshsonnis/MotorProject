using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UiComponent1.ViewModel
{
    public class GateViewModel : INotifyPropertyChanged
    {
        public GateViewModel()
        {
            GateName = "G468";
            IsOnOf = false;
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

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    
}
}
