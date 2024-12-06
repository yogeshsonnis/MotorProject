using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace UiComponent1.ViewModel
{
    public class TankViewModel : INotifyPropertyChanged
    {
        public TankViewModel()
        {
           
        }

        private string _maximumValue;
        public string MaxValue
        {
            get { return _maximumValue; }
            set
            {
                _maximumValue = value;
                OnPropertyChanged("MaxValue");
            }
        }

        private string _minValue;
        public string MinValue
        {
            get { return _minValue; }
            set
            {
                _minValue = value;
                OnPropertyChanged("MinValue");
            }
        }

        private int _tankNumber;
        public int TankNumber
        {
            get { return _tankNumber; }
            set
            {
                _tankNumber = value;
                OnPropertyChanged("TankNumber");
            }
        }

        private string _tankName;
        public string TankName
        {
            get { return _tankName; }
            set
            {
                _tankName = value;
                OnPropertyChanged("TankName");
            }
        }

        private SolidColorBrush _tankColor;
        public SolidColorBrush TankColor
        {
            get { return _tankColor; }
            set
            {
                _tankColor = value;
                OnPropertyChanged("TankColor");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
