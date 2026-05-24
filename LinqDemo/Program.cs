using static System.Runtime.InteropServices.JavaScript.JSType;

namespace LinqDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
          
            Predicate<int> even = x => x % 2 == 0;
            Predicate<int> odd = x => x % 2 != 0;


            Console.WriteLine(even(5));
            Console.WriteLine(odd(5));

            Action actiondel = new Action(Show);
            actiondel();
            Action del2 = new Action(delegate ()
            {
                Console.WriteLine("Show");
            });

            del2();
            Action del3 = () => Console.WriteLine("Lambda Show");
            del3();

            #region Func<>
            Func<bool> func = () => 100 > 10;
            Console.WriteLine(func());

            Func<int, bool> func2 = x => x > 10;
            Console.WriteLine(func2(100));

            Func<int, string, string> func3 = (x, str) => $"{x}, {str}";
            Console.WriteLine(func3(1234, "Hugh Jackman"));
            //Func<> 
            #endregion







            Data data = new Data();
            //data.InvokeEmpData();
            data.InvokeCustomerData();




        }



        static void Show()
        {
            Console.WriteLine("Show method");
        }
    }



//x developer
public class Emp
{
    public int Id { get;set;  }
    public string Name { get; set; }
    public string Address { get; set; }
    public void GetEmpData() {
        Console.WriteLine($"Id: {Id},Name : {Name} , Address: {Address}");





    }
}

//Ydeveloper


public  class Demo()
{
    public void FetchData(Action del)
    {
        del();
    }
}

//Intern

public class Customer
{
    public int billNo { get; set; }
    public string CName { get; set; }
    public void GetCustomerDetails()
    {
        Console.WriteLine($"Bill No: {billNo}, Name : {CName}");
    }
}












// Lead 
public class Data
{
    public void InvokeEmpData()
    {
        Emp emp = new Emp() { Id = 1, Name = "Peter", Address = "Pune" };
        Action actiondel = new Action(emp.GetEmpData);
        Demo demo = new Demo();
        demo.FetchData(actiondel);
    }

    public void InvokeCustomerData()
    {
        Customer cust = new Customer() { billNo = 3456, CName = "Jack" };
        Action actionDel = new Action(cust.GetCustomerDetails);
        Demo demo = new Demo();
        demo.FetchData(actionDel);
    }

}