using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using UiComponent1.ViewModel;

namespace UiComponent1.View
{
    /// <summary>
    /// Interaction logic for CurrentMotorView.xaml
    /// </summary>
    public partial class CurrentMotorView : UserControl
    {
        public CurrentMotorView()
        {
            InitializeComponent();
            this.DataContext = new CurrentMotorViewModel();
        }

        public bool? IsOnOf
        {
            get { return (bool?)GetValue(IsOnOfProperty); }
            set { SetValue(IsOnOfProperty, value); }
        }

        // Using a DependencyProperty as the backing store for IsOnOf.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty IsOnOfProperty =
            DependencyProperty.Register("IsOnOf", typeof(bool?), typeof(CurrentMotorView), new PropertyMetadata(null, IsOnOfChange));

        private static void IsOnOfChange(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            GateSwitchesView view = d as GateSwitchesView;
            //For More Info Please Visit GateSwitchesView.xaml.cs
        }

        public string GateName
        {
            get { return (string)GetValue(GateNameProperty); }
            set { SetValue(GateNameProperty, value); }
        }

        // Using a DependencyProperty as the backing store for GateName.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty GateNameProperty =
            DependencyProperty.Register("GateName", typeof(string), typeof(CurrentMotorView), new PropertyMetadata(string.Empty, OnGateNameChange));

        private static void OnGateNameChange(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            CurrentMotorView view = d as CurrentMotorView;
            view.txtGateName.Text = e.NewValue.ToString();
        }

        public string CurrentValue
        {
            get { return (string)GetValue(CurrentValueProperty); }
            set { SetValue(CurrentValueProperty, value); }
        }

        // Using a DependencyProperty as the backing store for CurrentValue.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty CurrentValueProperty =
            DependencyProperty.Register("CurrentValue", typeof(string), typeof(CurrentMotorView), new PropertyMetadata(String.Empty, OnCurrentValueChange));

        private static void OnCurrentValueChange(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            CurrentMotorView view = d as CurrentMotorView;
            view.txtCurrentValue.Text = e.NewValue.ToString();
        }



        public string CurrentSetting
        {
            get { return (string)GetValue(CurrentSettingProperty); }
            set { SetValue(CurrentSettingProperty, value); }
        }

        // Using a DependencyProperty as the backing store for CurrentSetting.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty CurrentSettingProperty =
            DependencyProperty.Register("CurrentSetting", typeof(string), typeof(CurrentMotorView), new PropertyMetadata(string.Empty, OnCurrentSettingChange));

        private static void OnCurrentSettingChange(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            CurrentMotorView view = d as CurrentMotorView;
            view.txtCurrentSetting.Text = e.NewValue.ToString();
        }

        public string MotorName
        {
            get { return (string)GetValue(MotorNameProperty); }
            set { SetValue(MotorNameProperty, value); }
        }

        // Using a DependencyProperty as the backing store for MotorName.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty MotorNameProperty =
            DependencyProperty.Register("MotorName", typeof(string), typeof(CurrentMotorView), new PropertyMetadata(string.Empty, OnMotorNameChange));

        private static void OnMotorNameChange(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            CurrentMotorView view = d as CurrentMotorView;
            view.txtMotorName.Text = e.NewValue.ToString();
        }
    }

}
