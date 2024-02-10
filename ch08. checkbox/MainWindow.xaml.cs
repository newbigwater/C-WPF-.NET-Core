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

namespace ch08._checkbox
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ChkCherry_OnChecked(object sender, RoutedEventArgs e)
        {
            chkBoxTxt.Text = "체리 선택";
        }

        private void ChkCherry_OnUnchecked(object sender, RoutedEventArgs e)
        {
            chkBoxTxt.Text = "체리";

        }
    }
}