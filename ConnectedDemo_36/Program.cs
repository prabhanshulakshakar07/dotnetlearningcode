using ConnectedDemo_36.DEL;
using ConnectedDemo_36.Models;

namespace ConnectedDemo_36
{
    // DB Layer : SQLExpress
    // DAL : Data Access Layer // Db connectivity
    internal class Program
    {
        static void Main(string[] args)
        {
            // UI Layer: Buissness Presentation Layer
            while (true)
            {
                EmpDbContext dbContext = new EmpDbContext();

                Console.WriteLine("Select your operation choice: 1. Select, 2. Select by Id, 3. Insert, 4. Update, 5. Delete");

                int opCh = Convert.ToInt32(Console.ReadLine());

                int noRowsAffected = 0;
                switch (opCh)
                {
                    case 1:
                        List<Emp> allEmps = dbContext.SelectEmpRecords();
                        foreach (Emp emp in allEmps)
                        {
                            Console.WriteLine($"ID: {emp.EId}, Name: {emp.EName}, Address: {emp.EAddress}");
                        }
                        break;
                    case 2:
                        Console.WriteLine("Enter emp Id: ");
                        int empId = Convert.ToInt32(Console.ReadLine());
                        Emp empToBeFound = dbContext.SelectEmpById(empId);
                        if (empToBeFound != null)
                        {
                            Console.WriteLine($"Id: {empToBeFound.EId}, Name: {empToBeFound.EName}, Address: {empToBeFound.EAddress}");
                        }
                        else
                        {
                            Console.WriteLine("No such Emp exist!");
                        }
                        break;
                    case 3:
                        Emp empToBeInserted = new Emp();
                        Console.WriteLine("Enter Emp Id: ");
                        empToBeInserted.EId = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter Emp Name: ");
                        empToBeInserted.EName = Console.ReadLine();
                        Console.WriteLine("Enter Emp Address: ");
                        empToBeInserted.EAddress = Console.ReadLine();

                        noRowsAffected = dbContext.InsertEmpRecord(empToBeInserted);

                        if (noRowsAffected > 0)
                        {
                            Console.WriteLine("Records inserted successfully!!");
                        }
                        else
                        {
                            Console.WriteLine("Error");
                        }
                        break;
                    case 4:
                        Emp empToBeUpdated = new Emp();
                        Console.WriteLine("Enter Emp Id: ");
                        empToBeUpdated.EId = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter Emp Name: ");
                        empToBeUpdated.EName = Console.ReadLine();
                        Console.WriteLine("Enter Emp Address: ");
                        empToBeUpdated.EAddress = Console.ReadLine();

                        noRowsAffected = dbContext.UpdateEmpRecord(empToBeUpdated);

                        if (noRowsAffected > 0)
                        {
                            Console.WriteLine("Records updated successfully!!");
                        }
                        else
                        {
                            Console.WriteLine("Error");
                        }
                        break;
                    case 5:
                        Console.WriteLine("Enter Emp Id to be deleted: ");
                        int id = Convert.ToInt32(Console.ReadLine());

                        noRowsAffected = dbContext.DeleteEmpRecord(id);

                        if (noRowsAffected > 0)
                        {
                            Console.WriteLine("Records deleted successfully!!");
                        }
                        else
                        {
                            Console.WriteLine("Error");
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid Db Operation Choice");
                        break;
                }

                Console.WriteLine("Do you want to contine?y/n: ");
                string ynCh = Console.ReadLine().ToLower();
                if (ynCh == "n")
                {
                    break;
                }
            }
        }
    }
}