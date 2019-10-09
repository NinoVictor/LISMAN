﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
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

namespace Lisman {
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow()
        {
            InitializeComponent();
        }

        public Boolean ValidateFields()
        {
            
            if(textField_user.Text == "") {
                var messageError = Properties.Resources.message_error_usename;
                MessageBox.Show(messageError);
                return false;
            }
            if (passwordBox_password.Password == "") {
                var messageError = Properties.Resources.message_error_password;
                MessageBox.Show(messageError);
                return false;
            }
            return true;
        }

        private void Hyperlink_Click(object sender, RoutedEventArgs e)
        {
            UserRegister userRegister = new UserRegister();
            userRegister.Show();
            this.Close();
        }

        private void MenuItem_Click_Spanish(object sender, RoutedEventArgs e)
        {
            System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("es-MX");
            MainWindow login = new MainWindow();
            login.Show();
            this.Close();
        }

        private void MenuItem_Click_English(object sender, RoutedEventArgs e)
        {
            System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("");
            MainWindow login = new MainWindow();
            login.Show();
            this.Close();
        }

        private void btn_login_Click(object sender, RoutedEventArgs e)
        {
            if (ValidateFields()) {
                using (var client = new LismanService.AccountManagerClient()){
                    
                    try {
                        LismanService.Account account = client.LoginAccount(textField_user.Text, EncodePassword(passwordBox_password.Password));
                        if (account != null) {
                            MainMenu mainMenu = new MainMenu();
                            mainMenu.Show();
                            this.Close();
                        } else {
                            var messageWarningLogin = Properties.Resources.message_warning_login;
                            MessageBox.Show(messageWarningLogin);
                        }
                    } catch(Exception ex) {
                        Console.WriteLine(ex.Message);
                    }
                    
                    
                }


            }
        }

        public string EncodePassword(string originalPassword)
        {
            SHA256 sha256 = SHA256Managed.Create();
            ASCIIEncoding encoding = new ASCIIEncoding();
            byte[] stream = null;
            StringBuilder sb = new StringBuilder();
            stream = sha256.ComputeHash(encoding.GetBytes(originalPassword));
            for (int i = 0; i < stream.Length; i++) sb.AppendFormat("{0:x2}", stream[i]);
            return sb.ToString();
        }

        
    }
}
