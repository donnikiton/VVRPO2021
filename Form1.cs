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
    public partial class Form1 : Form
    {
        static void dataload(string[] args)
        {
            string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=usersdb;Integrated Security=True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
            }

        }
        public Form1()
        {
            InitializeComponent();
        }
        private void button4_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form_Main f2 = new Form_Main();
            f2.ShowDialog();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form_bron f2 = new Form_bron();
            f2.ShowDialog();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
