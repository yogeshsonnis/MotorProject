﻿using System;
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
    /// Interaction logic for GateView.xaml
    /// </summary>
    public partial class GateView : UserControl
    {
        public GateView()
        {
            InitializeComponent();
            this.DataContext = new GateViewModel();

        }
    }
}
