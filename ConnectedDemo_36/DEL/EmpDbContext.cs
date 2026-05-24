using ConnectedDemo_36.Models;
using System;
using Microsoft.Data.SqlClient;
using System.Collections.Generic;
using System.Text;

namespace ConnectedDemo_36.DEL
{
    internal class EmpDbContext
    {
        string conString = @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=DBExample;Integrated Security=True";
        public List<Emp> SelectEmpRecords()
        {
            SqlConnection con = new SqlConnection(conString);
            SqlCommand cmd = new SqlCommand("Select * from Emp", con);

            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            List<Emp> emps = new List<Emp>();
            while (reader.Read())
            {
                int id = Convert.ToInt32(reader["Id"]);
                string nm = Convert.ToString(reader["Name"]);
                string add = Convert.ToString(reader["Address"]);

                Emp emp = new Emp() { EId = id, EName = nm, EAddress = add };

                emps.Add(emp);
            }
            con.Close();

            return emps;
        }



        // select record by id
        public Emp SelectEmpById(int id)
        {
            SqlConnection con = new SqlConnection(conString);
            SqlCommand cmd = new SqlCommand($"select * from Emp where Id = {id}", con);
            Emp emp = new Emp();
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                emp.EId = Convert.ToInt32(reader["Id"]);
                emp.EName = reader["Name"].ToString();
                emp.EAddress = reader["Address"].ToString();
            }
            con.Close();
            return emp;
        }

        // Insert record
        public int InsertEmpRecord(Emp emp)
        {
            SqlConnection con = new SqlConnection(conString);

            string insertQuery = $"insert into Emp values({emp.EId}, '{emp.EName}', '{emp.EAddress}')";

            SqlCommand cmd = new SqlCommand(insertQuery, con);
            con.Open();
            int noOFRowsAfftected = cmd.ExecuteNonQuery();
            con.Close();

            return noOFRowsAfftected;
        }

        // Update record
        public int UpdateEmpRecord(Emp emp)
        {
            SqlConnection con = new SqlConnection(conString);

            string updateQuery = $"update Emp set Name= '{emp.EName}', Address= '{emp.EAddress}' where Id = {emp.EId}";

            SqlCommand cmd = new SqlCommand(updateQuery, con);
            con.Open();
            int noOFRowsAfftected = cmd.ExecuteNonQuery();
            con.Close();

            return noOFRowsAfftected;
        }
        /// Delete record
        /// 
        public int DeleteEmpRecord(int id)
        {
            SqlConnection con = new SqlConnection(conString);

            string deleteQuery = $"delete from Emp where Id = {id}";

            SqlCommand cmd = new SqlCommand(deleteQuery, con);
            con.Open();
            int noOFRowsAfftected = cmd.ExecuteNonQuery();
            con.Close();

            return noOFRowsAfftected;
        }







    }
}
