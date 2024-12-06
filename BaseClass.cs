using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using UiComponent1.View;
using UiComponent1.ViewModel;

namespace UiComponent1
{
    public class BaseClass : UserControl
    {
        public string MotorName
        {
            get { return (string)GetValue(MotorNameProperty); }
            set { SetValue(MotorNameProperty, value); }
        }

        // Using a DependencyProperty as the backing store for MotorName.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty MotorNameProperty =
            DependencyProperty.Register("MotorName", typeof(string), typeof(HorizontalBeltView), new PropertyMetadata(string.Empty, OnMotorNameChange));

        private static void OnMotorNameChange(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            HorizontalBeltView view = d as HorizontalBeltView;
            view.txtMotorName.Text = e.NewValue.ToString();
        }

    }
}
