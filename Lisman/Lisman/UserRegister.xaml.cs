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
using System.Windows.Shapes;

namespace Lisman {
    /// <summary>
    /// Lógica de interacción para UserRegister.xaml
    /// </summary>
    public partial class UserRegister : Window {
        public UserRegister()
        {
            InitializeComponent();
        }

        private void Button_Click_Cancel(object sender, RoutedEventArgs e)
        {
            MainWindow login = new MainWindow();
            login.Show();
            this.Close();
        }

        private void button_save_Click(object sender, RoutedEventArgs e)
        {
            if (ValidateData()) {
                using (var client = new LismanService.UserClient()) {
                    var accountSave = new LismanService.Cuenta
                    {
                        Usuario = textField_userName.Text,
                        Contrasenia = EncodePassword(passwordBox_password.Password),
                        fecha_registro = DateTime.Now.ToString(),
                        Jugador = new LismanService.Jugador
                        {
                            Nombre = textField_name.Text,
                            Apellido = textField_lastName.Text,
                            Email = textField_email.Text,
                            


                        }

                    };
                    if (client.AddCuenta(accountSave) != -1) {
                        var messageRegistrationSuccessful = Properties.Resources.message_registration_successful;
                        MessageBox.Show(messageRegistrationSuccessful);
                        MainWindow login = new MainWindow();
                        login.Show();
                        this.Close();
                    } else {
                        var messageRegistrationError = Properties.Resources.message_registration_error;
                        MessageBox.Show(messageRegistrationError);

                    }
                }

           

                

                
            }
        }


        public Boolean ValidateData() {
            var messageError = "";
            if (textField_name.Text == "") {
                messageError = Properties.Resources.message_error_name;
                MessageBox.Show(messageError);
                return false;
            } else if (textField_lastName.Text == "") {
                messageError = Properties.Resources.message_error_lastname;
                MessageBox.Show(messageError);
                return false;
            } else if (textField_email.Text == "") {
                messageError = Properties.Resources.message_error_email;
                MessageBox.Show(messageError);
                return false;
            } else if (textField_userName.Text == "") {
                messageError = Properties.Resources.message_error_usename;
                MessageBox.Show(messageError);
                return false;
            } else if (passwordBox_password.Password == "") {
                messageError = Properties.Resources.message_error_password;
                MessageBox.Show(messageError);
                return false;
            } else if (passwordBox_confirmPassword.Password == "") {
                messageError = Properties.Resources.message_error_confirmation_password;
                MessageBox.Show(messageError);
                return false;
            } else if (!passwordBox_password.Password.Equals(passwordBox_confirmPassword.Password)){
                messageError = Properties.Resources.message_error_passwords_different;
                MessageBox.Show(messageError);
                return false;
            }

            return true;
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
