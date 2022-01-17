using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace DB_Kurs
{

    class DBClass
        
{
    
    static string connectionString = "Server=DESKTOP-TS4D4OC\\SQLEXPRESS;Database=DB_kurs;Trusted_Connection=True;TrustServerCertificate=True;";
        public static DataTable Connec(string sqlExpression)
        {
            SqlCommand cmd = new SqlCommand(sqlExpression);
            SqlDataAdapter da = new SqlDataAdapter(sqlExpression, connectionString);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds.Tables[0];
        }
        public static void connect(string sqlExpression)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                command.ExecuteNonQuery();
            }
        }
    }
    public class Conn
    {
        private static volatile Conn stringCon;

        private string _data;

        public string Data => _data;

        private Conn(string data)
        {
            _data = data;
        }

        public static Conn GetInst(string data)
        {
            if (string.IsNullOrEmpty(data))
            {
                throw new ArgumentNullException(nameof(data));
            }
            if (stringCon == null)
            {
                stringCon = new Conn(data);
            }

            return stringCon;
        }

        public override string ToString()
        {
            return Data;
        }
    }

}
            