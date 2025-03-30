using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spa_NNLT.Nguyên;

namespace Spa_NNLT.Nguyên.Nguyên_DTO
{
    public class DataProvider
    {
        private string connectionSTR = "Data Source=DESKTOP-IE5BPNN\\SQLEXPRESS;Initial Catalog=QUANLY_SPA;Integrated Security=True;Integrated Security=True";
        public DataTable Excuted(string query)
        {
            DataTable data = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionSTR))
            { 


                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);

                

                SqlDataAdapter adapter = new SqlDataAdapter(command);

                adapter.Fill(data);

                connection.Close();

            }
            return data;

        }
    }
}
