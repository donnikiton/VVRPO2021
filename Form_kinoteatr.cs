using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DB_Kurs;
using System.Windows.Forms;

namespace DB_Kurs
{
    public partial class Form_kinoteatr : Form
    {
        public Form_kinoteatr()
        {
            InitializeComponent();
        }

        private void Form_kinoteatr_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "testDataSet2.KinoteatrSet". При необходимости она может быть перемещена или удалена.
            this.kinoteatrSetTableAdapter.Fill(this.testDataSet2.KinoteatrSet);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DBClass.connect($"INSERT INTO kinoteatrSet(name) VALUES ('" + textBox1.Text + "');");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DBClass.connect($"DELETE FROM kinoteatrSet WHERE name = '" + textBox1.Text + "';");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_Main f2 = new Form_Main();
            f2.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Kino_seans f2 = new Kino_seans();
            f2.ShowDialog();
        }
    }
}
