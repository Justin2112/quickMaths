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

namespace mathFormulaCalculator
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
        //Algebra
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Window3 Alg = new Window3();
            Alg.Show();
        }
        //Geometry
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Window1 Geom = new Window1();
            Geom.Show();

        }
    }
}
