using Microsoft.Data.SqlClient;

namespace ConnectedDB.Models
{
    // DAL - Data Access Layer
    public class EmpDbContext
    {
        private readonly string? _connectionString;

        public EmpDbContext(IConfiguration config)
        {
            _connectionString = config.GetConnectionString("conStr");
        }

        public List<Emp> GetAllEmps()
        {
            List<Emp> emps = new List<Emp>();

            using (var con = new SqlConnection(_connectionString))
            {
                using (var cmd = new SqlCommand("SELECT * FROM Emp", con))
                {
                    con.Open();

                    SqlDataReader sqlDataReader = cmd.ExecuteReader();
                    SqlDataReader reader = sqlDataReader;

                    while (reader.Read())
                    {
                        emps.Add(new Emp()
                        {
                            Id = (int)reader["Id"],
                            Name = reader["Name"].ToString(),
                            Address = reader["Address"].ToString()
                        });
                    }
                }
            }

            return emps;
        }
    }
}