using Microsoft.Data.SqlClient;

namespace StoreProcedure
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //InsertDepartment("HR");
            //InsertDepartment("Sales");

            InsertEmployee("Peter Parker", 2);
            InsertEmployee("Tony Stark", 1);
            InsertEmployee("Wolvarine", 2);
            InsertEmployee("Hulk", 2);

            GetEmployeeById(1);
            Console.WriteLine("--------------------------------");
            GetEmployeeById(2);
            Console.WriteLine("--------------------------------");

        }
        static void InsertDepartment(string deptName)
        {
            string conString = "Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=MyDb;Integrated Security=True";

            // Using block
            using (var con = new SqlConnection(conString))
            {
                using (var cmd = new SqlCommand("InsertDepartment", con))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@DepartmentName", deptName);

                    con.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static void InsertEmployee(string nm, int deptId)
        {
            string conStr = "Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=MyDb;Integrated Security=True";
            // Example of inserting an employee using a stored procedure
            using (var connection = new SqlConnection(conStr))
            {
                using (var command = new SqlCommand("InsertEmployee", connection))
                {
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@EmployeeName", nm);
                    command.Parameters.AddWithValue("@DepartmentId", deptId);
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        public static void GetEmployeeById(int id)
        {
            string conStr = "Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=MyDb;Integrated Security=True";
            // Example of retrieving an employee by ID using a stored procedure
            using (var connection = new SqlConnection(conStr))
            {
                connection.Open();
                using (var command = new SqlCommand("GetEmployeeByDepartment", connection))
                {
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@DepartmentId", id);
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Console.WriteLine($"Id: {reader["EmployeeId"]}, Name: {reader["EmployeeName"]}");
                        }
                    }
                }
            }
        }
    }
}