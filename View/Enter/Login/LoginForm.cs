using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EnterProcessHelpful;
using Model.SQL;
using Model.Entities;
using Registration;
using View.MainPart;
using Controllers.Enter;

namespace Login
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoadLoginForm(object sender, EventArgs e)
        {

        }

        private void PasswordTextChanged(object sender, EventArgs e)
        {
            RichTextBox passwordBox = (RichTextBox)sender;

            PasswordProcessor.NewSymbolHandle(passwordBox, _password);
        }

        private void ClickLoginButton(object sender, EventArgs e)
        {
            LoginCheckResult result = _mainController
                .AccountCheck(login.Text, _password.ToString());

            if (result == LoginCheckResult.Success)
            {
                Form form = _mainController.EnterToAccount(login.Text);

                if (form == null)
                {
                    MessageBox.Show(caption: "Помилка входу", text: "Такого аккаунту не існує");
                    CleanFields();
                }
                else
                {
                    form.Show();
                    this.Hide();
                }
            }
            
            if (result == LoginCheckResult.Empty_Login)
            {
                MessageBox.Show(caption: "Помилка входу", text: "Задано пустий логін");
            }
            else if (result == LoginCheckResult.Empty_Password)
            {
                MessageBox.Show(caption: "Помилка входу", text: "Задано пустий пароль");
            }
            else  if (result == LoginCheckResult.Wrong_Account)
            {
                MessageBox.Show(caption: "Помилка входу", text: "Такого аккаунту не існує");
                CleanFields();
            }
        }

        private void ClickRegButton(object sender, EventArgs e)
        {
            Form registrationSelection = new RegistationSelectForm();
            registrationSelection.Show();
            this.Hide();
        }

        private void CleanFields()
        {
            login.Clear();
            password.Clear();
            _password.Clear();
        }


        private StringBuilder _password = new StringBuilder();
        private LoginController _mainController = new LoginController();
    }

}
