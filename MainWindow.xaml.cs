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




namespace WPFCalculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 

    //TODO: Fix +/- sign
    //TODO: Fix Reset sign
    //TODO: Add working equals sign
    //TODO: Try moving the text to right side

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            FuckingFrame.Navigate(new Page1());
        }

    }
}
