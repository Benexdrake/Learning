﻿using System.Windows;

namespace WPF_Test
{
    public partial class LoginWindow : Window
    {
        string username = "Test";
        string password = "111111";

        public LoginWindow()
        {
            InitializeComponent();
        }

        private void btn_Login_Click(object sender, RoutedEventArgs e)
        {
            if(tBox_Username.Text.Equals(username) && tBox_Password.Text.Equals(password))
            {
                MessageBox.Show("Yay");
                MainWindow main = new MainWindow();
                main.Show();
            }
        }
    }
}
