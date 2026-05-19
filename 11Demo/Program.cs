namespace _11Demo_OOP_Interface
{
    // DRY principle : Do Not Repeat Yorself
    //SRP
    // Factory Pattern : object produce .
    // Interface :
    // Template - can force the implementation
    // No need of Type Casting
    // Loose Coupling 
    // Achieve multiple inheritance
    // Public/ Open contract - Service based industry

    internal class Program
    {
        static void Main(string[] args)
        {
            // UI generation
            #region old code :
            //InsertIntoMySqlDB();
            //DeleteIntoMySqlDB();
            //UpdateIntoMySqlDB(); 
            #endregion
            while (true)
            {

                Console.WriteLine("Enter your Db Choice. 1. MySql, 2. Oracle, 3. SqlServer");
                int dbChoice = Convert.ToInt32(Console.ReadLine());

                DataBaseFactory factory = new DataBaseFactory();
                IDatabase db = factory.GetSomeDatabase(dbChoice);

                Console.WriteLine("Enter your Db operation Choice: 1.Insert, 2. Update, 3. Delete");
                int opCh = Convert.ToInt32(Console.ReadLine());
                switch (opCh)
                {
                    case 1:
                        db.Insert();
                        break;
                    case 2:
                        db.Update();
                        break;
                    case 3:
                        db.Delete();
                        break;
                    default:
                        Console.WriteLine("Invalid Db Operation choice!!");
                        break;
                }

                Console.WriteLine("Do you want continue? y/n");
                string ynch = Console.ReadLine().ToLower();// Y, N, y, n
                if (ynch == "n")
                {
                    break;
                }
            }

        }
    }
    public interface IDatabase
    {
        void Insert();
        void Update();
        void Delete();
    }
    // Creational Design Pattern : Factory Pattern: Object producing factories
    public class DataBaseFactory
    {
        public IDatabase GetSomeDatabase(int choice)
        {
            IDatabase dbObj = null;
            switch (choice)
            {
                case 1:
                    dbObj = new MySqlServer();
                    break;
                case 2:
                    dbObj = new OracleServer();
                    break;
                case 3:
                    dbObj = new SqlServer();
                    break;
                default:
                    dbObj = null;
                    break;

            }
            return dbObj;
        }
    }
    // Single Responsibility Principle (SRP)
    public class MySqlServer : IDatabase
    {
        public void Insert()
        {
            // code here..
            Console.WriteLine("Inserted data in MySql Db");
        }
        public void Update()
        {
            // code here..
            Console.WriteLine("Updated data in MySql Db");
        }
        public void Delete()
        {
            // code here..
            Console.WriteLine("Delete data in MySql Db");
        }
    }
    //SRP
    public class OracleServer : IDatabase
    {
        public void Insert()
        {
            // code here..
            Console.WriteLine("Inserted data in Oracle Db");
        }
        public void Update()
        {
            // code here..
            Console.WriteLine("Updated data in Oracle Db");
        }
        public void Delete()
        {
            // code here..
            Console.WriteLine("Delete data in Oracle Db");
        }
    }
    public class SqlServer : IDatabase
    {
        public void Insert()
        {
            // code here..
            Console.WriteLine("Inserted data in SqlServer Db");
        }
        public void Update()
        {
            // code here..
            Console.WriteLine("Updated data in SqlServer Db");
        }
        public void Delete()
        {
            // code here..
            Console.WriteLine("Delete data in SqlServer Db");
        }
    }
}







//////////////////////////////
///﻿//namespace _11Demo_OOP_Interface
//{
//    // DRY principle : Do Not Repeat Yorself
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            // UI generation
//            #region old code :
//            //InsertIntoMySqlDB();
//            //DeleteIntoMySqlDB();
//            //UpdateIntoMySqlDB(); 
//            #endregion
//            while (true)
//            {
//                Console.WriteLine("Enter your Db Choice. 1. MySql, 2. Oracle");
//                int dbChoice = Convert.ToInt32(Console.ReadLine());
//                int opCh = 0;
//                switch (dbChoice)
//                {
//                    case 1:
//                        MySqlServer mysqlDb = new MySqlServer();
//                        Console.WriteLine("Enter your Db operation Choice: 1.Insert, 2. Update, 3. Delete");
//                        opCh = Convert.ToInt32(Console.ReadLine());
//                        switch (opCh)
//                        {
//                            case 1:
//                                mysqlDb.Insert();
//                                break;
//                            case 2:
//                                mysqlDb.Update();
//                                break;
//                            case 3:
//                                mysqlDb.Delete();
//                                break;
//                            default:
//                                Console.WriteLine("Invalid Db Operation choice!!");
//                                break;
//                        }
//                        break;
//                    case 2:
//                        OracleServer oracle = new OracleServer();
//                        Console.WriteLine("Enter your Db operation Choice: 1.Insert, 2. Update, 3. Delete");
//                        opCh = Convert.ToInt32(Console.ReadLine());
//                        switch (opCh)
//                        {
//                            case 1:
//                                oracle.Insert();
//                                break;
//                            case 2:
//                                oracle.Update();
//                                break;
//                            case 3:
//                                oracle.Delete();
//                                break;
//                            default:
//                                Console.WriteLine("Invalid Db Operation choice!!");
//                                break;
//                        }
//                        break;
//                    default:
//                        Console.WriteLine("Invalid Db Choice");
//                        break;
//                }

//                Console.WriteLine("Do you want continue? y/n");
//                string ynch = Console.ReadLine().ToLower();// Y, N, y, n
//                if (ynch == "n")
//                {
//                    break;
//                }
//            }

//        }
//    }
//    // Single Responsibility Principle (SRP)
//    public class MySqlServer
//    {
//        public void Insert()
//        {
//            // code here..
//            Console.WriteLine("Inserted data in MySql Db");
//        }
//        public void Update()
//        {
//            // code here..
//            Console.WriteLine("Updated data in MySql Db");
//        }
//        public void Delete()
//        {
//            // code here..
//            Console.WriteLine("Delete data in MySql Db");
//        }
//    }

//    public class OracleServer
//    {
//        public void Insert()
//        {
//            // code here..
//            Console.WriteLine("Inserted data in Oracle Db");
//        }
//        public void Update()
//        {
//            // code here..
//            Console.WriteLine("Updated data in Oracle Db");
//        }
//        public void Delete()
//        {
//            // code here..
//            Console.WriteLine("Delete data in Oracle Db");
//        }
//    }
//}