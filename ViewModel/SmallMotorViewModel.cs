using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UiComponent1.ViewModel
{
    public class SmallMotorViewModel : INotifyPropertyChanged
    {

        public SmallMotorViewModel()
        {
            MotorName = "M440";
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
