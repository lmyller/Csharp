using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using LoginSystem.Classes;
using LoginSystem.Interfaces;

namespace LoginSystem
{
    internal partial class LoginSystemGUI : Form
    {
        private ListUser _listUsers;

        public LoginSystemGUI()
        {
            InitializeComponent();

            _listUsers = new ListUser();
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(() => Application.Run(new RegisterSystemGUI(_listUsers)));
            thread.Start();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (Valid.IsEmptyTextBox(nameOrEmailTextBox))
            {
                MessageLoginSystem.ShowMessage(IConstantLoginSystem.DEFAULT_ERROR_NAME_OR_EMAIL_EMPTY, 
                                               IConstantLoginSystem.DEFAULT_PROGRAM_NAME);
                SetFocus(nameOrEmailTextBox);

                return;
            }

            if (Valid.IsEmptyTextBox(passwordTextBox))
            {
                MessageLoginSystem.ShowMessage(IConstantLoginSystem.DEFAULT_ERROR_PASSWORD_EMPTY, 
                                               IConstantLoginSystem.DEFAULT_PROGRAM_NAME);
                SetFocus(passwordTextBox);
               
                return;
            }

            login();
        }

        private void login()
        {
            if (_listUsers.HasUser(new User(nameOrEmailTextBox.Text, passwordTextBox.Text)))
            {
                MessageLoginSystem.ShowMessage(IConstantLoginSystem.DEFAULT_LOGIN_REALIZED, 
                                               IConstantLoginSystem.DEFAULT_PROGRAM_NAME);

                Clear();
            }

            else
            {
                MessageLoginSystem.ShowMessage(IConstantLoginSystem.DEFAULT_ERROR_USER_NOT_FOUND, 
                                               IConstantLoginSystem.DEFAULT_PROGRAM_NAME);
            }
        }

        private void Clear()
        {
            nameOrEmailTextBox.Text = string.Empty;
            passwordTextBox.Text = string.Empty;

            SetFocus(nameOrEmailTextBox);
        }

        private void SetFocus(TextBox textBox)
        {
            textBox.Focus();
        }
    }
}