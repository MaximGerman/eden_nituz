using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Example_Project
{
    public partial class main_form : Form
    {
        public main_form()
        {
            InitializeComponent();
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void button_new_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }

        private void button_exist_Click(object sender, EventArgs e)
        {
            form2 f = new form2();
            f.Show();
            this.Hide();
        }
    }
}
