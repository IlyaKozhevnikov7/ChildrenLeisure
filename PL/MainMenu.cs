using BLL;

namespace PL
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();

            MaximizeBox = false;
            MinimizeBox = false;
        }

        private void OnClickAuthorizationButton(object sender, EventArgs e)
        {
            this.CreateRelativeForm<AuthorizationMenu>();
        }

        private void OnClickRegistrationButton(object sender, EventArgs e)
        {
            this.CreateRelativeForm<RegistrationMenu>();
        }
    }
}
