using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DBConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            string connString = @"Server=DESKTOP-VCKBA6J\SQLEXPRESS;Database=demo_m_sp21;Integrated Security=True;";
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();
            string query = "insert into Users values('jenia','nodi','1999-12-12','jenia.nodi@gmail.com',01639)";
            SqlCommand cmd = new SqlCommand(query,conn);
            int row_affected = cmd.ExecuteNonQuery();
            if(row_affected>0)
            {
                Console.WriteLine("Successfully Added");
            }
            else
            {
                Console.WriteLine("Successfully Added");
            }
            conn.Close(); 
            conn.Open();
            query = "select * from Users";
            cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            Console.WriteLine("Id\t\tFirst Name\t\tLast Name\t\tEmail");
            while (reader.Read())
            {
                long id= reader.GetInt64(0);
                string fname = reader.GetString(1);
                string lname = reader.GetString(2);
                Console.WriteLine("{0}\t{1}\t{2}", id, fname, lname);

            }
            conn.Close();
        }
    }
}
