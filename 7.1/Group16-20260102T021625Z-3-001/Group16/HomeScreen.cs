using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Group16
{
    public partial class HomeScreen : Form
    {
        public HomeScreen()
        {
            InitializeComponent();
        }

        private void Manage_Item_Click(object sender, EventArgs e)
        {
            ManageItemsOpeningScreen mi = new ManageItemsOpeningScreen();
            mi.Show();
            this.Close();
        }


        private void SetMinimumStock_Click(object sender, EventArgs e)
        {
            SetMinimumStockOpeningScreen ms = new SetMinimumStockOpeningScreen();
            ms.Show();
            this.Close();
        }


        private void CreateOrder_Click(object sender, EventArgs e)
        {
            CreateOrderOpeningScreen co = new CreateOrderOpeningScreen();
            co.Show();
            this.Close();
        }

        private void UpdateStock_Click(object sender, EventArgs e)
        {
            UpdateStockOpeningScreen mi = new UpdateStockOpeningScreen();
            mi.Show();
            this.Close();
        }

        private void itemsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.itemsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sAD_16DataSet);

        }

        private void HomeScreen_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sAD_16DataSet.Items' table. You can move, or remove it, as needed.
            this.itemsTableAdapter.Fill(this.sAD_16DataSet.Items);

        }
    }
}
