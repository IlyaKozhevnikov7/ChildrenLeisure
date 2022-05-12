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
    public partial class AuthorizationMenu : Form
    {
        public AuthorizationMenu()
        {
            InitializeComponent();

            MaximizeBox = false;
            MinimizeBox = false;
        }

        private async void OnClickEnterButton(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_nameTextBox.Text) || string.IsNullOrEmpty(_passwordTextBox.Text))
            {
                MessageBox.Show("Заповніть усі поля");
                return;
            }

            if (await ChildrenEntertainmentService.Instance.TryLoginAsync(_nameTextBox.Text, _passwordTextBox.Text))
            {
                this.CreateRelativeForm<ClientMainMenu>();
            }
            else
            {
                MessageBox.Show("Вы ввели не правильні дані");
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
