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
    public partial class form2 : Form
    {
        private Worker exist_Worker;
        public form2()
        {
            InitializeComponent();
            //נטרול תיבות הטקסט כך שלא ניתן יהיה לרשום בהן
            textBox_name.Enabled = false;
            comboBox_title.Enabled = false;
            //הסתרת הכפתורים
            button_delete.Hide();
            button_update.Hide();
        }

        private void form2_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e) //לחיצה על חזרה
        {
            main_form mf = new main_form();
            mf.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)//לחיצה על כפתור החיפוש
        {
            //הצגת הכפתורים
            button_delete.Show();
            button_update.Show();
            //איתור המופע המתאים והצגת הפרטים
            exist_Worker = Program.seekWorker(textBox_id.Text);
            textBox_name.Text = exist_Worker.get_name();
            textBox_name.Enabled = true;
            comboBox_title.Enabled = true;
            comboBox_title.DataSource = Enum.GetValues(typeof(Title));
            comboBox_title.Text = exist_Worker.get_title().ToString();

        }

        private void button_update_Click(object sender, EventArgs e)
        {
            exist_Worker.set_name(textBox_name.Text);
            exist_Worker.set_title((Title)Enum.Parse(typeof(Title),comboBox_title.Text));
            exist_Worker.Update_worker();

            main_form mf = new main_form();
            mf.Show();
            this.Close();
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            exist_Worker.Delete_worker();

            main_form mf = new main_form();
            mf.Show();
            this.Close();
        }
    }
}
