using BLL;

namespace PL
{
    public partial class ClientMainMenu : Form
    {
        private const string _cashAmountLabelPrefix = "Ваш баланс: ";

        public ClientMainMenu()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            var client = ChildrenEntertainmentService.Instance.Client;

            _cashAmountLabel.Text = _cashAmountLabelPrefix + client.Cash;
            client.CashChanged += OnCashChanged;
        }

        private void OnCashChanged(int newAmount)
        {
            _cashAmountLabel.Text = _cashAmountLabelPrefix + newAmount;
        }

        private void OnClickReplenishBalanceButton(object sender, EventArgs e)
        {
            this.CreateDialog<ReplenishBalanceMenu>();
        }

        private void OnClickMakeOfferButton(object sender, EventArgs e)
        {
            this.CreateDialog<OrderCreationMenu>();
        }

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            Application.Exit();
        }

        private void OnClickMyOffersButton(object sender, EventArgs e)
        {
            this.CreateDialog<OrdersMenu>();
        }
    }
}
