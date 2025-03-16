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

namespace Page_Navigation_App.View
{
    /// <summary>
    /// Interaction logic for Settings.xaml
    /// </summary>
    public partial class Settings : UserControl
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void autoinject1on_Click(object sender, RoutedEventArgs e)
        {
            CloudyApi.Api.AutoInject(true);
        }

        private void autoinject1off_Click(object sender, RoutedEventArgs e)
        {
            CloudyApi.Api.AutoInject(false);
        }
    }
}
