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
    public partial class ManageItemsOpeningScreen : Form
    {
        public ManageItemsOpeningScreen()
        {
            InitializeComponent();
        }

        private void ManageItemsOpeningScreen_Load(object sender, EventArgs e)
        {
            

        }

        private void SearchItemByName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.Rows.Add("Value1", "Value2", "Value3");
        }
    }
}

