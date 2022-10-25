﻿using System.Data;
using System;
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

namespace Graph_Development
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

        private void Button_Reg_Click(object sender, RoutedEventArgs e)
        {
            string login = TextBoxLogin.Text.Trim();
            string pass = TextBoxPassword.Password.Trim();
            string passRepeat = TextBoxPasswordRepeat.Password.Trim();
            string email = TextBoxEmail.Text.Trim().ToLower();

            if (login.Length < 5)
            {
                TextBoxLogin.ToolTip = "Errrrrror!!!";
                TextBoxLogin.Background = Brushes.DarkRed;
            }
        }
    }
}
