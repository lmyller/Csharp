using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LoginSystem.Classes;
using LoginSystem.Interfaces;

namespace LoginSystem
{
    internal partial class RegisterSystemGUI : Form
    {
        private ListUser _listUsers;

        public RegisterSystemGUI()
        {
            InitializeComponent();
        }

        public RegisterSystemGUI(ListUser listUsers)
        {
            InitializeComponent();

            this._listUsers = listUsers;
        }

        private void registerButton_Click(object sender, EventArgs e)
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
            
            if (Valid.IsEmptyTextBox(confirmPasswordTextBox))
            {
                MessageLoginSystem.ShowMessage(IConstantLoginSystem.DEFAULT_ERROR_CONFIRM_PASSWORD_EMPTY, 
                                               IConstantLoginSystem.DEFAULT_PROGRAM_NAME);
                
                SetFocus(confirmPasswordTextBox);

                return;
            }

            if(!Valid.isEqual(passwordTextBox.Text, confirmPasswordTextBox.Text))
            {
                MessageLoginSystem.ShowMessage(IConstantLoginSystem.DEFAULT_ERROR_PASSWORD_DIFFERENT,
                                               IConstantLoginSystem.DEFAULT_PROGRAM_NAME);
                
                return; 
            }

            if(_listUsers.AddUser(new User(nameOrEmailTextBox.Text, passwordTextBox.Text)))
            {
                MessageLoginSystem.ShowMessage(IConstantLoginSystem.DEFAULT_REGISTER_REALIZED,
                                               IConstantLoginSystem.DEFAULT_PROGRAM_NAME);

                Close();
            }

            else
            {
                MessageLoginSystem.ShowMessage(IConstantLoginSystem.DEFAULT_USER_REGISTERED,
                                               IConstantLoginSystem.DEFAULT_PROGRAM_NAME);
            }
        }

        private void SetFocus(TextBox textBox)
        {
            textBox.Focus();
        }
    }
}
