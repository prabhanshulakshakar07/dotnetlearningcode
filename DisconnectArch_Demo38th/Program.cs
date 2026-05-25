using System.Data;
using Microsoft.Data.SqlClient;
namespace DisconnectArch_Demo38th
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string conString = @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=DBExample;Integrated Security=True";

            #region Select Query using SqlDataAdpter
            SqlConnection con = new SqlConnection(conString);
            SqlDataAdapter da = new SqlDataAdapter("select * from Emp", con);
            // helper to DataAdpter: to gerate insert, update, delete queries
            SqlCommandBuilder builder = new SqlCommandBuilder(da);











            // This line is going to fetch Primary key schema from Database and this line will going to help DataAdaptor to created Id column from Emp table accordingly.
            da.MissingSchemaAction = MissingSchemaAction.AddWithKey;

            // DataSet is a collection of DataTable
            // Datatable is a collection of DataRow
            // DataRow is a collection of DataColumn

            DataSet ds = new DataSet();
            //DataTable dt = new DataTable("Emp");
            //ds.Tables.Add(dt);

            // This Fill() method will create DataTable with name "Emp" and will add it to collection of DataSet.
            da.Fill(ds, "Emp");

            ds.WriteXml(@"C:\Users\Prabhanshu\source\repos\Csharpdemos\DisconnectArch_Demo38th\Data\data.xml");
            foreach (DataRow row in ds.Tables["Emp"].Rows)
            {
                Console.WriteLine($"Id: {row["Id"]}, Name: {row["Name"]}, Address: {row["Address"]}");
            }
            #endregion

            #region Connected Arch. with DataSet
            ////DataSet ds = new DataSet();
            //DataTable dt = new DataTable();

            //DataColumn col1 = new DataColumn("Id", typeof(int));
            //DataColumn col2 = new DataColumn("Name", typeof(string));
            //DataColumn col3 = new DataColumn("Address", typeof(string));

            //dt.Columns.Add(col1);
            //dt.Columns.Add(col2);
            //dt.Columns.Add(col3);

            //dt.PrimaryKey = new DataColumn[] { col1 };

            //SqlConnection con = new SqlConnection(conString);
            //SqlCommand cmd = new SqlCommand("select * from Emp", con);
            //con.Open();
            //SqlDataReader reader = cmd.ExecuteReader();

            //while (reader.Read()) 
            //{
            //    DataRow row = dt.NewRow();
            //    row[0] = reader["Id"];
            //    row[1] = reader["Name"];
            //    row[2] = reader["Address"];
            //    dt.Rows.Add(row);
            //}

            //con.Close();

            ////ds.Tables.Add(dt);

            //foreach (DataRow row in dt.Rows) 
            //{
            //    Console.WriteLine($"Id: {row["Id"]}, Name: {row["Name"]}, Address: {row["Address"]}");
            //}
            #endregion

            #region Insert Query with DataAdapter
            //DataRow recordToBeInsertedRow = ds.Tables["Emp"].NewRow();
            ////Console.WriteLine("Enter id : ");
            //recordToBeInsertedRow["Id"] = 4;
            //recordToBeInsertedRow["Name"] = "Olivia";
            //recordToBeInsertedRow["Address"] = "Patna";

            //ds.Tables["Emp"].Rows.Add(recordToBeInsertedRow);

            //da.Update(ds,"Emp");
            //Console.WriteLine("Done");
            #endregion

            #region Update query with DataAdpter

            //Console.WriteLine("Enter Id: ");
            //int id = Convert.ToInt32(Console.ReadLine());

            //DataRow rowToBeEdited = ds.Tables["Emp"].Rows.Find(id);
            //if (rowToBeEdited != null)
            //{
            //    Console.WriteLine("Enter name to be updated: ");
            //    rowToBeEdited["Name"] = Console.ReadLine();

            //    Console.WriteLine("Enter address to be updated: ");
            //    rowToBeEdited["Address"] = Console.ReadLine();
            //}
            //da.Update(ds,"Emp");

            #endregion

            #region Delete Query using DataAdapter
            //Console.WriteLine("Enter Id to be deleted: ");
            //int idToBeDeleted = Convert.ToInt32(Console.ReadLine());

            //DataRow rowToBeDeleted = ds.Tables["Emp"].Rows.Find(idToBeDeleted);

            ////ds.Tables["Emp"].Rows[idToBeDeleted].Delete();
            //rowToBeDeleted.Delete();

            //da.Update(ds, "Emp");
            #endregion
        }
    }
}