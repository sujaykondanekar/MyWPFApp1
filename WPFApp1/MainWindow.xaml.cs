﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPFApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow(decimal Variable1, bool IsEnabled)
        {
            InitializeComponent();
            lblDisplay.Content = "Test 3";
            if(dataSet==null) 
            {
            //do nothing. Comment should appear here
            }
            if(null==record)
            {
            //this becomes valid.
            }
        }
    }
}
