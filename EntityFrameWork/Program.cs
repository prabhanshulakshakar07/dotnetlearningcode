using EntityFrameWork.DAL;
using EntityFrameWork.Models;

namespace EntityFrameWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ORM - EntityFrameworkCore
            // DotNet Application <=== EmpDbContext == DbContext ==EF ===> MS SQL Server
            // Dot Application is ready and if I want to generate database accordingly .. POCO classses, Mehtods should get mapped with db tables and storedprocedures, so we are asking Entity Framework to genarte Database, tables and storedprocedures mapped with .Net c# code ---> We call this approach as "CODE FIRST Approach" of EntityFramework

            while (true)
            {
                CustomerDbContext dbContext = new CustomerDbContext();
                int noOfRowsAfftected = 0;
                Console.WriteLine("Enter your db operation Choice: 1. Select, 2. Insert, 3. Update, 4. Delete");
                int opCh = Convert.ToInt32(Console.ReadLine());

                switch (opCh)
                {
                    case 1:
                        List<Customer> custs = dbContext.Customers.ToList();
                        foreach (Customer cust in custs)
                        {
                            Console.WriteLine($"Id: {cust.CId}, Name: {cust.CName}, Address: {cust.CAddress}");
                        }
                        break;
                    case 2:
                        Customer obj = new Customer();

                        Console.WriteLine("Enter Name : ");
                        obj.CName = Console.ReadLine();
                        Console.WriteLine("Enter Address: ");
                        obj.CAddress = Console.ReadLine();

                        dbContext.Customers.Add(obj);

                        noOfRowsAfftected = dbContext.SaveChanges();

                        if (noOfRowsAfftected > 0)
                        {
                            Console.WriteLine("Inserted record in db successsfully");
                        }
                        else
                        {
                            Console.WriteLine("Error");
                        }

                        break;
                    case 3:
                        Console.WriteLine("Enter customer id to be updated: ");
                        int id = Convert.ToInt32(Console.ReadLine());

                        Customer custToBeUpdated = dbContext.Customers.Find(id);

                        Console.WriteLine("Enter name to be updated");
                        custToBeUpdated.CName = Console.ReadLine();

                        Console.WriteLine("Enter address to be updated");
                        custToBeUpdated.CAddress = Console.ReadLine();

                        noOfRowsAfftected = dbContext.SaveChanges();

                        if (noOfRowsAfftected > 0)
                        {
                            Console.WriteLine("Updated record in db successsfully");
                        }
                        else
                        {
                            Console.WriteLine("Error");
                        }
                        break;
                    case 4:
                        Console.WriteLine("Enter customer id to be updated: ");
                        int idtobeDeleted = Convert.ToInt32(Console.ReadLine());
                        Customer custTBeDeleted = dbContext.Customers.Find(idtobeDeleted);

                        dbContext.Customers.Remove(custTBeDeleted);

                        noOfRowsAfftected = dbContext.SaveChanges();

                        if (noOfRowsAfftected > 0)
                        {
                            Console.WriteLine("Deleted record in db successsfully");
                        }
                        else
                        {
                            Console.WriteLine("Error");
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid database operation choice!!");
                        break;
                }

                Console.WriteLine("do you want to continue? y/n");
                string ynCh = Console.ReadLine();
                if (ynCh == "n")
                {
                    break;
                }
            }
        }
    }
}