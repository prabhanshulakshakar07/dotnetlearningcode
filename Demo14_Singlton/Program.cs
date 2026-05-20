namespace Demo14_Singlton
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Enter Your Choice: 1. MySQL Server, 2. Oracle Server, 3. SQL Server, 4. Exit");
                int dbChoice = Convert.ToInt32(Console.ReadLine());

                DataBaseFactory factory =new DataBaseFactory();
                Database db =factory.GetSomeDatabase(dbChoice);
                Console.WriteLine("Enter YOur Db Operation choice: 1. Insert, 2. Update, 3. Delete");

                int opCh =Convert.ToInt32(Console.ReadLine());
                switch(opCh)
                {
                    case 1:
                        db.DoInsert();
                        break;

                    case 2:
                        db.DoUpdate();
                        break;


                    case 3:
                        db.DoDelete();
                        break;

                    default:
                        Console.WriteLine("Invalid Db Operation Choice!!");
                        break;

                }

                Console
                    .WriteLine("Do you want to continue? (Y/N)");
                string ynch = Console.ReadLine().ToLower();
                if(ynch != "y")
                {
                    break;
                }




            }
          












        }






    }
}


public abstract class Database
{
    public Logger _logger = null;
    protected Database()
    {
        _logger = Logger.GetLogger();
    }
    protected abstract void Insert();
    protected abstract void Update();
    protected abstract void Delete();
    protected abstract string GetDatabseName();

    public void DoInsert()// Wrapper Method
    {
        Insert();
        _logger.Log($"Insert operation done in {GetDatabseName()} Db");
    }
    public void DoUpdate()
    {
        Update();
        _logger.Log  ($"Update operation done in {GetDatabseName()} Db");
    }
    public void DoDelete()
    {
        Delete();
        _logger.Log($"Delete operation done in {GetDatabseName()} Db");
    }
}

public class DataBaseFactory
{
    public Database GetSomeDatabase(int choice)
    {
        Database dbObj = null;
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


//signle Responsibility Principle: A class should have only one reason to change. In this example, the Database class is responsible for managing database connections and operations, while the Logger class is responsible for logging messages. This separation of concerns allows each class to focus on its specific responsibilities, making the code more maintainable and easier to understand.
public class MySqlServer : Database
{
    //private Logger _logger = null;
    //public MySqlServer()
    //{
    //    _logger = Logger;
    //}
    protected override string GetDatabseName()
    {
        return "MySQL Server ";
    }


    protected override void Insert()
    {
        Console.WriteLine("Insert operation done in MySQL Server Db");
        //_logger.Log("Insert operation done in MySQL Server Db");
    }
    protected override void Update()
    {
        Console.WriteLine("Update operation done in MySQL Server Db");
    }

    protected override void Delete()
    {
        Console.WriteLine("Delete operation done in MySQL Server Db");
    }

}


//srp
public class OracleServer : Database
{
    //private Logger _logger = null;
    //public OracleServer()
    //{
    //    _logger = Logger.GetLogger();
    //}
   
    protected override void Insert()
    {
        Console.WriteLine("Insert operation done in Oracle Server Db");
        //_logger.Log("Insert operation done in Oracle Db");

    }
    protected override void Update()
    {
    
        Console.WriteLine("Update operation done in Oracle Server Db");
        //_logger.Log("Insert operation done in Oracle Db");

    }
    protected override void Delete()
    {
        Console.WriteLine("Delete operation done in Oracle Server Db");
        //_logger.Log("Insert operation done in Oracle Db");
    }
    protected override string GetDatabseName()
    {
        return "Oracle Server";
    }

}
public class SqlServer :Database
{
    //private Logger _logger = null;
    //public SqlServer()
    //{
    //    _logger = Logger.GetLogger();
    //}


    protected override string GetDatabseName()
    {
        return "SQL Server";
    }

    protected override void Insert()
    {
        Console.WriteLine("Insert operation done in SQL Server Db");
        //.Log("Insert operation done in SQL Db");
    }
    protected override void Update()
    {
        Console.WriteLine("Update operation done in SQL Server Db");
        //.Log("Insert operation done in SQL Db");
    }
    protected override void Delete()
    {
        Console.WriteLine("Delete operation done in SQL Server Db");
        //.Log("Insert operation done in SQL Db");
    }






}







// Logger is a singleton class, which means that only one instance of this class can be created and shared across the entire application. This is useful for logging purposes, as it ensures that all log messages are consistent and centralized.

public class Logger
{
    private static Logger _logger =new Logger();

    //private static Logger _logger2 = new Logger();
    //private static Logger _logger3 = new Logger();

    private Logger()
    {
        Console.WriteLine("Logger object created...");
    }
    #region Extra Code 
    //public void CreateLogFile()
    //{ 
    //    // Log.txt create
    //}

    //public static Logger[] GetLoggers()
    //{
    //    // Object Pooling
    //    Logger[] loggers = new Logger[3] { _logger, _logger2, _logger3};
    //    return loggers;
    //} 
    #endregion

    public static Logger GetLogger()
    {
        return _logger;
    }

    public void Log(string message)
    {
        // File IO: log.txt
        Console.WriteLine($"---Log: {message} at {DateTime.Now.ToString()}");
    }





}