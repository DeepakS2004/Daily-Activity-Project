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

namespace Project_5
{
    /// <summary>
    /// Interaction logic for Data.xaml
    /// </summary>
    public partial class Data : Page
    {
        public Data(List<Activity> value)
        {
            InitializeComponent();
            list.ItemsSource = value;
        }
    }
}
