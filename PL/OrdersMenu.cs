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
    public partial class OrdersMenu : Form
    {
        public OrdersMenu()
        {
            InitializeComponent();
        }

        protected override async void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            dataGridView1.DataSource = await ChildrenEntertainmentService.Instance.ReceiveOrders();
        }
    }
}
