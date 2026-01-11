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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBox1.DataSource = Enum.GetValues(typeof(Title));//אתחול הקומבובוקס
        }

        private void ID_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Add_button_Click(object sender, EventArgs e)
        {
            Worker W = new Worker(ID_textBox.Text, Name_textBox.Text, (Title)Enum.Parse(typeof(Title),comboBox1.Text), true);//יצירת עובד חדש
            
            
            main_form mf = new main_form();
            mf.Show();
            this.Close();
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            main_form mf = new main_form();
            mf.Show();
            this.Close();


        }
    }
}
