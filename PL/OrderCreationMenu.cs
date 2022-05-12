using BLL;

namespace PL
{

    public partial class OrderCreationMenu : Form
    {
        private readonly string _priceLablePrefix = "Ціна: ";

        public OrderCreationMenu()
        {
            InitializeComponent();

            comboBox1.SelectedIndex = 0;
        }

        private void OnClickCheckoutButton(object sender, EventArgs e)
        {
            if (ChildrenEntertainmentService.Instance.TryMakeOrder((LeisureType)comboBox1.SelectedIndex))
            {
                MessageBox.Show("Запит успішно оплачений");
                Close();
            }
            else
            {
                MessageBox.Show("На балансі недостатньо коштів");
            }
        }

        private void OnSelectedValueChanged(object sender, EventArgs e)
        {
            label2.Text = _priceLablePrefix + ChildrenEntertainmentService.Instance.GetLeisurePrice((LeisureType)comboBox1.SelectedIndex);
        }
    }
}
