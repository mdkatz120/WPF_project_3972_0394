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
using Microsoft.Maps.MapControl.WPF;
using System.Text.RegularExpressions;
using WPF_project_3972_0394.ViewModel;

namespace WPF_project_3972_0394
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        public MainWindow()
        {
            InitializeComponent();
            myMap.Center = new Location(31.7799727, 35.2109524);
            
            
        }

        private void rep_Loaded(object sender, RoutedEventArgs e)
        {

        }
    }
    
}
