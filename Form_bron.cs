using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DB_Kurs
{
    public partial class Form_bron : Form
    {
        
        public Form_bron()
        {
            InitializeComponent();
            comboBox1.DataSource = DBClass.Connec($"SELECT * FROM kinoteatrSet");
            comboBox1.DisplayMember = "name";
            comboBox1.ValueMember = "id_kinoteatr";
            comboBox1.Enabled = true;
            comboBox2.DataSource = DBClass.Connec($"SELECT * FROM seansSet");
            comboBox2.DisplayMember = "tame_date";
            comboBox2.ValueMember = "id_seans";
            comboBox2.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f2 = new Form1();
            f2.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Gmail mails = new Gmail();
            mails.mailpost($"{textBox2.Text}", $"Дрогой {textBox1.Text}. Вы успешно забронировали билет, в кинотеатре { comboBox1.Text}  на время { comboBox2.Text}", "Бронь билета");
            MessageBox.Show("Вы забронировали билет. Вам отослали информацию по почте");
        }
           

            private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            
        }

        private void Form_bron_Load(object sender, EventArgs e)
        {

        }
    }
}



