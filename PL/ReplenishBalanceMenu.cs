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
    public partial class ReplenishBalanceMenu : Form
    {
        public ReplenishBalanceMenu()
        {
            InitializeComponent();
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            base.OnKeyDown(e);

            if (_moneyAmountTextBox.Text.Length > 0)
                _passwordTextBox.Enabled = true;
        }

        private void OnKeyPressesMoneyAmountTextBox(object sender, KeyPressEventArgs e)
        {
            bool isFirstZero = e.KeyChar == (int)Keys.D0 && _moneyAmountTextBox.Text.Length == 0;
            bool isDigit = (e.KeyChar <= (int)Keys.D1 || e.KeyChar <= (int)Keys.D9) == false;

            e.Handled = isFirstZero || isDigit;

            _passwordTextBox.Enabled = _moneyAmountTextBox.Text.Length + (e.Handled ? 0 : 1) > 0;
        }

        private void OnClickTopUpCashButton(object sender, EventArgs e)
        {
            if (_moneyAmountTextBox.Text.Length == 0)
            {
                MessageBox.Show("Заповніть усі поля");
                return;
            }

            if (_passwordTextBox.Text.Length == 0)
            {
                MessageBox.Show("Введіть пароль");
                return;
            }

            if (IsValidPassword() == false)
            {
                MessageBox.Show("Пароль невірний");
                _passwordTextBox.Text = string.Empty;
                return;
            }

            ChildrenEntertainmentService.Instance.Client.TopUpCash(int.Parse(_moneyAmountTextBox.Text));
            
            MessageBox.Show("Поповнення рахунко пройшло успішно");
            Close();
        }

        private bool IsValidPassword()
        {
            return ChildrenEntertainmentService.Instance.Client.password == _passwordTextBox.Text;
        }
    }
}
