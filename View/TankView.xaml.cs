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
    /// Interaction logic for TankView.xaml
    /// </summary>
    public partial class TankView : UserControl
    {
        public TankView()
        {
            InitializeComponent();
           // this.DataContext = new TankViewModel();
        }

        public string MaximumValue
        {
            get { return (string)GetValue(MaximumValueProperty); }
            set { SetValue(MaximumValueProperty, value); }
        }

        // Using a DependencyProperty as the backing store for MaximumValue.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty MaximumValueProperty =
            DependencyProperty.Register("MaximumValue", typeof(string), typeof(TankView), new PropertyMetadata(string.Empty, OnMaximumValueChange));

        private static void OnMaximumValueChange(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            TankView view = d as TankView;
            view.txtMaximumValue.Text = e.NewValue.ToString();
        }

        public string TankName
        {
            get { return (string)GetValue(TankNameProperty); }
            set { SetValue(TankNameProperty, value); }
        }

        // Using a DependencyProperty as the backing store for MaximumValue.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty TankNameProperty =
            DependencyProperty.Register("TankName", typeof(string), typeof(TankView), new PropertyMetadata(string.Empty, OnTankNameChange));

        private static void OnTankNameChange(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            TankView view = d as TankView;
            view.txtTankName.Text = e.NewValue.ToString();
        }

        public int TankNumber
        {
            get { return (int)GetValue(TankNumberProperty); }
            set { SetValue(TankNumberProperty, value); }
        }

        // Using a DependencyProperty as the backing store for TankNumber.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty TankNumberProperty =
            DependencyProperty.Register("TankNumber", typeof(int), typeof(TankView), new PropertyMetadata(0, OnTankNumberChange));

        private static void OnTankNumberChange(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            TankView view = d as TankView;
            view.txtTankNumber.Text = e.NewValue.ToString();
        }


        public SolidColorBrush TankColor
        {
            get { return (SolidColorBrush)GetValue(TankColorProperty); }
            set { SetValue(TankColorProperty, value); }
        }

        // Using a DependencyProperty as the backing store for TankColor.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty TankColorProperty =
            DependencyProperty.Register("TankColor", typeof(SolidColorBrush), typeof(TankView), new PropertyMetadata(null, OnTankColorChange));

        private static void OnTankColorChange(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            TankView view = d as TankView;
            view.tankBg.Background = (SolidColorBrush)e.NewValue;
        }



        public string MinimumValue
        {
            get { return (string)GetValue(MinimumValueProperty); }
            set { SetValue(MinimumValueProperty, value); }
        }

        // Using a DependencyProperty as the backing store for MinimumValue.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty MinimumValueProperty =
            DependencyProperty.Register("MinimumValue", typeof(string), typeof(TankView), new PropertyMetadata(string.Empty , OnTankMiniValueChange));

        private static void OnTankMiniValueChange(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            TankView view = d as TankView;
            view.txtMinValue.Text = e.NewValue.ToString();
        }
    }
}
