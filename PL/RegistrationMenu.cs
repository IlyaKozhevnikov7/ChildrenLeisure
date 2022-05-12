using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace PL
{
    public partial class RegistrationMenu : Form
    {
        public RegistrationMenu()
        {
            InitializeComponent();
        }

        private async void OnClickSingInButton(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_nameTextBox.Text) || string.IsNullOrEmpty(_passwordTextBox.Text))
            {
                MessageBox.Show("Заповніть усі поля");
                return;
            }

            bool singInResult = await ChildrenEntertainmentService.Instance.TrySignInAsync(_nameTextBox.Text, _passwordTextBox.Text);

            if (singInResult)
            {
                MessageBox.Show("Реєстрації пройшла успішно");
                this.BackToOwnerForm();
            }
            else
            {
                MessageBox.Show("Користувач з такими даними вже усніє");
            }
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);

            if (Owner != null)
                Owner.Show();
        }
    }
}
