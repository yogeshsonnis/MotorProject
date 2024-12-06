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
    /// Interaction logic for MotorView.xaml
    /// </summary>
    public partial class MotorView : UserControl
    {
        public MotorView()
        {
            InitializeComponent();
            this.DataContext = new MotorViewModel();
        }

        public string MotorName
        {
            get { return (string)GetValue(MotorNameProperty); }
            set { SetValue(MotorNameProperty, value); }
        }

        // Using a DependencyProperty as the backing store for MotorName.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty MotorNameProperty =
            DependencyProperty.Register("MotorName", typeof(string), typeof(MotorView), new PropertyMetadata(string.Empty, OnMotorNameChange));

        private static void OnMotorNameChange(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            MotorView view = d as MotorView;
            view.txtMotorName.Text = e.NewValue.ToString();
        }



        public string CurrentValue
        {
            get { return (string)GetValue(CurrentValueProperty); }
            set { SetValue(CurrentValueProperty, value); }
        }

        // Using a DependencyProperty as the backing store for CurrentValue.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty CurrentValueProperty =
            DependencyProperty.Register("CurrentValue", typeof(string), typeof(MotorView), new PropertyMetadata(string.Empty, OnCurrentValueChange));

        private static void OnCurrentValueChange(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            MotorView view = d as MotorView;
            view.txtCurrentValue.Text = e.NewValue.ToString();
        }
    }
}
