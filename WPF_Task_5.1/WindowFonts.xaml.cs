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
using System.Windows.Shapes;

namespace WPF_Task_5._1
{
    /// <summary>
    /// Логика взаимодействия для WindowFonts.xaml
    /// </summary>
    public partial class WindowFonts : Window
    {
        public WindowFonts()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //string fntName = ListBoxFont.SelectedItem.ToString();
            //fntStyle = ListBoxFontStyle.SelectedItem.ToString();

            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
