using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Net.NetworkInformation;
using System.Windows;
using System.Windows.Media;

namespace UiComponent1.ViewModel
{
    public class DashboardViewModel : INotifyPropertyChanged
    {
       public DashboardViewModel()
        {
            TankCollection = new ObservableCollection<TankViewModel>();

            var TankRedColorBrush = (SolidColorBrush)Application.Current.Resources["TankRedColor"];
            var TankGreenColorBrush = (SolidColorBrush)Application.Current.Resources["SuccessColor"];
            var TankColorBrush = (SolidColorBrush)Application.Current.Resources["PrimaryColor"];
            var Tank1ColorBrush = (SolidColorBrush)Application.Current.Resources["FirstTankColor"];
            var Tank2ColorBrush = (SolidColorBrush)Application.Current.Resources["SecondTankColor"];
            var Tank3ColorBrush = (SolidColorBrush)Application.Current.Resources["ThirdTankColor"];
            var Tank4ColorBrush = (SolidColorBrush)Application.Current.Resources["FourthTankColor"];
            var Tank5ColorBrush = (SolidColorBrush)Application.Current.Resources["FifthTankColor"];
            var Tank6ColorBrush = (SolidColorBrush)Application.Current.Resources["SixthTankColor"];
            var Tank7ColorBrush = (SolidColorBrush)Application.Current.Resources["SeventhTankColor"];
            var Tank8ColorBrush = (SolidColorBrush)Application.Current.Resources["EighthTankColor"];
            var Tank9ColorBrush = (SolidColorBrush)Application.Current.Resources["NinethTankColor"];
            var Tank10ColorBrush = (SolidColorBrush)Application.Current.Resources["TenthTankColor"];

           
            for (int i = 1; i <= 10; i++)
            {
                TankViewModel vm = new TankViewModel();
                vm.MaxValue = "10";
                vm.TankNumber = i;
                vm.TankName = i + " xyz";
                vm.GateName = "G"+ (468 + i).ToString();

                if (i == 1)
                   vm.TankColor = Tank1ColorBrush;
                else if (i == 2)
                    vm.TankColor = Tank2ColorBrush;
                else if (i == 3)
                    vm.TankColor = Tank3ColorBrush;
                else if (i == 4)
                    vm.TankColor = Tank4ColorBrush;
                else if (i == 5)
                    vm.TankColor = Tank5ColorBrush;
                else if (i == 6)
                    vm.TankColor = Tank6ColorBrush;
                else if (i == 7)
                    vm.TankColor = Tank7ColorBrush;
                else if (i == 8)
                    vm.TankColor = Tank8ColorBrush;
                else if (i == 9)
                    vm.TankColor = Tank9ColorBrush;
                else
                    vm.TankColor = Tank10ColorBrush;
                   
                vm.MinValue = "0";
                TankCollection.Add(vm);               
            }   
        }
        
       ObservableCollection<TankViewModel> tankCollection;
       public ObservableCollection<TankViewModel> TankCollection
        {
            get
            { return tankCollection; }
            set
            {
                tankCollection = value;
                OnPropertyChanged(nameof(TankCollection));
            }
        }
        
       ObservableCollection<TankViewModel> oddNumTankCollection;
       public ObservableCollection<TankViewModel> OddNumTankCollection
        {
            get
            { return oddNumTankCollection; }
            set
            {
                oddNumTankCollection = value;
                OnPropertyChanged(nameof(OddNumTankCollection));
            }
        }

        ObservableCollection<TankViewModel> evenNumTankCollection;
        public ObservableCollection<TankViewModel> EvenNumTankCollection
        {
            get
            { return evenNumTankCollection; }
            set
            {
                evenNumTankCollection = value;
                OnPropertyChanged(nameof(EvenNumTankCollection));
            }
        }
        
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
