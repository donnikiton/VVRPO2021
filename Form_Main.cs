using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DB_Kurs
{
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_kinoteatr f2 = new Form_kinoteatr();
            f2.ShowDialog();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_seans f2 = new Form_seans();
            f2.ShowDialog();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_kinozal f2 = new Form_kinozal();
            f2.ShowDialog();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form_seans f2 = new Form_seans();
            f2.ShowDialog();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form_kinozal f2 = new Form_kinozal();
            f2.ShowDialog();
        }
    }
}
