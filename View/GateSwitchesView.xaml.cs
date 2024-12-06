﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    /// Interaction logic for GateSwitchesView.xaml
    /// </summary>
    public partial class GateSwitchesView : UserControl
    {
        public GateSwitchesView()
        {
            InitializeComponent();
            this.DataContext = new GatSwitchesViewModel();
        }

        public string MotorName
        {
            get { return (string)GetValue(MotorNameProperty); }
            set { SetValue(MotorNameProperty, value); }
        }

        // Using a DependencyProperty as the backing store for MotorName.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty MotorNameProperty =
            DependencyProperty.Register("MotorName", typeof(string), typeof(GateSwitchesView), new PropertyMetadata(string.Empty, OnMotorNameChange));

        private static void OnMotorNameChange(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            GateSwitchesView view = d as GateSwitchesView;
            view.txtMotorName.Text = e.NewValue.ToString();
        }


        public bool? IsOnOf
        {
            get { return (bool?)GetValue(IsOnOfProperty); }
            set { SetValue(IsOnOfProperty, value); }
        }

        // Using a DependencyProperty as the backing store for isActive.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty IsOnOfProperty =
            DependencyProperty.Register("IsOnOf", typeof(bool?), typeof(GateSwitchesView), new PropertyMetadata(null, IsOnOfChange));

        private static void IsOnOfChange(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            GateSwitchesView view = d as GateSwitchesView;

        }
    }
}
