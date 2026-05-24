
using Microsoft.Data.SqlClient;
namespace dotArch
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=DBExample;Integrated Security=True";

            SqlConnection con = new SqlConnection(connectionString);
            string selectQuery = "SELECT * FROM Emp";
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = selectQuery;
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Connection = con;

            con.Open();
            // Factory method
            SqlDataReader reader = cmd.ExecuteReader();// Query fire on DB
            while (reader.Read())
            {
                int id = Convert.ToInt32(reader[0]);
                string nm = reader[1].ToString();
                string add = reader[2].ToString();
                Console.WriteLine($"Id: {id}, Name: {nm}, Address:{add}");
            }

            con.Close();

        }
    }
}