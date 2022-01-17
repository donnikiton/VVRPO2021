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
    public partial class Form_seans : Form
    {
        public Form_seans()
        {
            InitializeComponent();
            comboBox1.DataSource =Connec();
            comboBox1.DisplayMember = "KinozalId_kinozal";
            comboBox1.ValueMember = "id_kinozal";
            comboBox1.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f2 = new Form1();
            f2.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void Form_seans_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "testDataSet2.seansSet". При необходимости она может быть перемещена или удалена.
            this.seansSetTableAdapter.Fill(this.testDataSet2.seansSet);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_Main f2 = new Form_Main();
            f2.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
                
            DBClass.connect($"INSERT INTO seansSet(tame_date,KinozalId_kinozal, BiletId_bilet) VALUES (  '{ textBox1.Text}'  ,  { comboBox1.Text}  ,  { comboBox2.Text} );");
                
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DBClass.connect($"DELETE FROM seansSet WHERE tame_date =  {textBox1.Text}  ,  { comboBox1.Text}  ,  { comboBox2.Text} ;");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=DESKTOP-TS4D4OC\\SQLEXPRESS;Database=DB_kurs;Trusted_Connection=True;TrustServerCertificate=True;";
            string sqlExpression = "SELECT tame_date,KinozalId_kinozal, BiletId_bilet FROM SeansSet WHERE tame_date = '" + textBox1.Text + "' AND KinozalId_kinozal = '" + comboBox1.Text + "' AND BiletId_bilet = '" + comboBox2.Text + "' ;";
            using (SqlConnection connection = new SqlConnection(connectionString))

            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                    MessageBox.Show("Информация о билете найдена");
                else
                    MessageBox.Show("Информация о билете не найдена");
            }
        }
        public static DataTable Connec()
        {
            string connectionString = "Server=DESKTOP-TS4D4OC\\SQLEXPRESS;Database=DB_kurs;Trusted_Connection=True;TrustServerCertificate=True;";
            string sqlExpression = $"SELECT kinozalSet.id_kinozal, KinoteatrId_kinoteatr FROM KinozalSet ;";
            {
                SqlCommand cmd = new SqlCommand(sqlExpression);
                SqlDataAdapter da = new SqlDataAdapter(sqlExpression, connectionString);
                DataSet ds = new DataSet();
                da.Fill(ds);
                return ds.Tables[0];
            }

        }
        private void button5_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            user_seans f2 = new user_seans();
            f2.ShowDialog();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
