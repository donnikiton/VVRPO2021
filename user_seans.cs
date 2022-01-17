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
    public partial class user_seans : Form
    {
        public user_seans()
        {
            InitializeComponent();
            dataGridView1.DataSource = Connec();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public static DataTable Connec()
        {
            string connectionString = "Server=DESKTOP-TS4D4OC\\SQLEXPRESS;Database=DB_kurs;Trusted_Connection=True;TrustServerCertificate=True;";
            string sqlExpression = $"SELECT polzovatelSet.FIO, polzovatelSet.number_phone AS 'Номер телефона', polzovatelSet.email AS 'Электронная почта', KinoteatrSet.name AS 'Название кинотеатра', KinozalSet.number AS 'Номер сеанса' , BiletSet.Id_bilet AS 'Номер билета', seansSet.tame_date AS 'Воемя сеанса' FROM KinozalSet INNER JOIN seansSet ON KinozalSet.Id_kinozal = seansSet.KinozalId_kinozal INNER JOIN KinoteatrSet ON KinozalSet.KinoteatrId_kinoteatr = KinoteatrSet.Id_kinoteatr INNER JOIN BiletSet ON seansSet.BiletId_bilet = BiletSet.Id_bilet INNER JOIN polzovatelSet ON BiletSet.polzovatelId_polzovatel = polzovatelSet.Id_polzovatel";

            {
                SqlCommand cmd = new SqlCommand(sqlExpression);
                SqlDataAdapter da = new SqlDataAdapter(sqlExpression, connectionString);
                DataSet ds = new DataSet();
                da.Fill(ds);
                return ds.Tables[0];
            }

        }

        private void user_seans_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "testDataSet2.KinozalSet". При необходимости она может быть перемещена или удалена.
            this.kinozalSetTableAdapter.Fill(this.testDataSet2.KinozalSet);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_seans f2 = new Form_seans();
            f2.ShowDialog();
        }
    }
}
