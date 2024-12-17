using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Net.NetworkInformation;
using System.Threading;
using System.Windows;
using System.Windows.Media;

namespace UiComponent1.ViewModel
{
    public class DashboardViewModel : INotifyPropertyChanged
    {
        SolidColorBrush TankRedColorBrush = (SolidColorBrush)Application.Current.Resources["TankRedColor"];
        SolidColorBrush TankGreenColorBrush = (SolidColorBrush)Application.Current.Resources["SuccessColor"];
        SolidColorBrush TankColorBrush = (SolidColorBrush)Application.Current.Resources["PrimaryColor"];
        SolidColorBrush Tank1ColorBrush = (SolidColorBrush)Application.Current.Resources["FirstTankColor"];
        SolidColorBrush Tank2ColorBrush = (SolidColorBrush)Application.Current.Resources["SecondTankColor"];
        SolidColorBrush Tank3ColorBrush = (SolidColorBrush)Application.Current.Resources["ThirdTankColor"];
        SolidColorBrush Tank4ColorBrush = (SolidColorBrush)Application.Current.Resources["FourthTankColor"];
        SolidColorBrush Tank5ColorBrush = (SolidColorBrush)Application.Current.Resources["FifthTankColor"];
        SolidColorBrush Tank6ColorBrush = (SolidColorBrush)Application.Current.Resources["SixthTankColor"];
        SolidColorBrush Tank7ColorBrush = (SolidColorBrush)Application.Current.Resources["SeventhTankColor"];
        SolidColorBrush Tank8ColorBrush = (SolidColorBrush)Application.Current.Resources["EighthTankColor"];
        SolidColorBrush Tank9ColorBrush = (SolidColorBrush)Application.Current.Resources["NinethTankColor"];
        SolidColorBrush Tank10ColorBrush = (SolidColorBrush)Application.Current.Resources["TenthTankColor"]; 

        public DashboardViewModel()
        {
            TankCollection = new ObservableCollection<TankViewModel>();
            OddNumTankCollection = new ObservableCollection<TankViewModel>();
            EvenNumTankCollection = new ObservableCollection<TankViewModel>();
           
            LoadTankCollection();
            LoadOddNumTankCollection();
            LoadEvenNumTankCollection();
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
        
        public void LoadTankCollection()
        {
            int i;
            for (i = 1; i <= 10; i++)
            {
                TankViewModel vm = new TankViewModel();
                vm.MaxValue = "10";
                vm.TankNumber = i;
                vm.TankName = i + " xyz";
                vm.GateName = "G" + (43 - i).ToString();

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

        public void LoadOddNumTankCollection()
        {
            int count = 0;
            for (int i = 5; i >= 1; i -= 2 ) 
            {
                TankViewModel tankViewModel = new TankViewModel();
                tankViewModel.MaxValue = "3";
                tankViewModel.TankNumber = i;
                tankViewModel.TankName = i + " xyz";
                tankViewModel.MinValue = "0";
                tankViewModel.GateName = "G" + (22 - count).ToString();
                count++;

                if (i == 5)
                    tankViewModel.TankColor = Tank5ColorBrush;
                else if (i == 3)
                    tankViewModel.TankColor = Tank3ColorBrush;
                else
                    tankViewModel.TankColor = Tank1ColorBrush;

                OddNumTankCollection.Add(tankViewModel);
            }
        }

        public void LoadEvenNumTankCollection()
        {
            int count = 0;
            for (int i = 2; i <=6 ; i += 2)
            {
                TankViewModel tankViewModel = new TankViewModel();
                tankViewModel.MaxValue = "3";
                tankViewModel.TankNumber = i;
                tankViewModel.TankName = i + " xyz";
                tankViewModel.MinValue = "0";
                tankViewModel.GateName = "G" + (19 - count).ToString();
                count++;

                if (i == 2)
                    tankViewModel.TankColor = Tank2ColorBrush;
                else if (i == 4)
                    tankViewModel.TankColor = Tank4ColorBrush;
                else
                    tankViewModel.TankColor = Tank6ColorBrush;

                EvenNumTankCollection.Add(tankViewModel);
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
