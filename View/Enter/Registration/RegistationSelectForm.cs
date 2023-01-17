using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controllers.Enter;

namespace Registration
{
    public partial class RegistationSelectForm : Form
    {
        public RegistationSelectForm()
        {
            InitializeComponent();

            FormClosed += RegistationSelectFormClosed;
        }

        private void RegistationSelectFormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void meBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ClickLoadUserRegistrationForm(object sender, EventArgs e)
        {
            Form nextForm = new UserRegistrationForm();
            nextForm.Show();
            this.Hide();
        }

        private void ClickBackButton(object sender, EventArgs e)
        {
            Application.OpenForms[0].Show();
            this.Hide();
        }

        private void ClickLoadAuthorRegistrationForm(object sender, EventArgs e)
        {
            Form nextForm = new AuthorRegistrationForm();
            nextForm.Show();
            this.Hide();
        }
    }
}
