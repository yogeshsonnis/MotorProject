using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UiComponent1.ViewModel
{
    public class newUserControlViewModel : INotifyPropertyChanged
    {
        public newUserControlViewModel()
        {
            Name = "M302_2";
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
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
