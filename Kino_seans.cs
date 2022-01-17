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
    public partial class Kino_seans : Form
    {
        public Kino_seans()
        {
            InitializeComponent();
            dataGridView1.DataSource = Connec();

        }

        private void Kino_seans_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "testDataSet2.KinoteatrSet". При необходимости она может быть перемещена или удалена.
            this.kinoteatrSetTableAdapter.Fill(this.testDataSet2.KinoteatrSet);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


            /*SELECT KinoteatrSet.name, KinozalSet.number, KinozalSet.capasity, seansSet.tame_date
            FROM KinoteatrSet INNER JOIN
                         KinozalSet ON KinoteatrSet.Id_kinoteatr = KinozalSet.KinoteatrId_kinoteatr INNER JOIN
                         seansSet ON KinozalSet.Id_kinozal = seansSet.KinozalId_kinozal*/
        }
        public static DataTable Connec()
        {
            string connectionString = "Server=DESKTOP-TS4D4OC\\SQLEXPRESS;Database=DB_kurs;Trusted_Connection=True;TrustServerCertificate=True;";
            string sqlExpression = $"SELECT KinoteatrSet.name, KinozalSet.number, KinozalSet.capasity, seansSet.tame_date FROM KinoteatrSet INNER JOIN KinozalSet ON KinoteatrSet.Id_kinoteatr = KinozalSet.KinoteatrId_kinoteatr INNER JOIN  seansSet ON KinozalSet.Id_kinozal = seansSet.KinozalId_kinozal";

            {
                SqlCommand cmd = new SqlCommand(sqlExpression);
                SqlDataAdapter da = new SqlDataAdapter(sqlExpression, connectionString);
                DataSet ds = new DataSet();
                da.Fill(ds);
                return ds.Tables[0];
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_kinoteatr f2 = new Form_kinoteatr();
            f2.ShowDialog();
        }
    }
}
