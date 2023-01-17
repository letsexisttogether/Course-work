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
using Controllers.Registration;

namespace Registration
{
    public partial class AuthorRegistrationForm : Form
    {
        public AuthorRegistrationForm()
        {
            InitializeComponent();
        }

        private void FirstPasswordChanged(object sender, EventArgs e)
        {
            PasswordProcessor.NewSymbolHandle(sender as RichTextBox, _firstPassword);

        }
        private void SecondPasswordChanged(object sender, EventArgs e)
        {
            PasswordProcessor.NewSymbolHandle(sender as RichTextBox, _secondPassword);
        }

        private void RegButtonClick(object sender, EventArgs e)
        {
            RegAccountResult result = _regController.RegNewAuthor(
                login.Text, _firstPassword.ToString(), _secondPassword.ToString(),
                email.Text);

            if (result == RegAccountResult.Empty_data)
            {
                MessageBox.Show(caption: "Помилка реєстрації", text: "Перевірте правильність даних");
                ClearPasswords();
            }
            else if (result == RegAccountResult.Passwords_unmatch)
            {
                MessageBox.Show(caption: "Помилка реєстарції", text: "Паролі не співпадають");
                ClearPasswords();
            }
            else if (result == RegAccountResult.Account_already_exists)
            {
                MessageBox.Show(caption: "Помилка реєстарції", text: "Такий автор вже існує");
                ClearPasswords();
            }
            else
            {
                MessageBox.Show(caption: "Повідомлення про реєстарію",
                    text: "Автора було успішно зареєстровано");
                LoadNextForm();
            }
        }

        private void ClickBackButton(object sender, EventArgs e)
        {
            LoadNextForm();
        }

        private void LoadNextForm()
        {
            Application.OpenForms[0].Show();
            this.Close();
        }
        private void ClearPasswords()
        {
            password.Clear();
            secondPassword.Clear();
            _firstPassword.Clear();
            _secondPassword.Clear();
        }


        private StringBuilder _firstPassword = new StringBuilder();
        private StringBuilder _secondPassword = new StringBuilder();
        private AuthorRegistrationController _regController = new AuthorRegistrationController();
    }
}
