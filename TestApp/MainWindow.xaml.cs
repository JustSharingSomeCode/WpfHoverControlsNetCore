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

namespace TestApp
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void HoverFloatAdder_OnValueChanged(object sender, EventArgs e)
        {
            ValueChangedLbl.Content = FloatAdder.Value;
        }

        private void HoverExpander_Btn1_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Edit Btn");
        }

        private void HoverExpander_Btn2_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Search Btn");
        }

        private void HoverExpander_Btn3_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Delete Btn");
        }
    }
}
