using System.Collections;

namespace CSharpFeaturesDemo
{
    public delegate bool CheckDelegate(int num);
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Partial Classes
            // Partial class: Same named class present in two differnt physical files/ locations/ different Paths. 
            //Demo demo = new Demo();
            //Console.WriteLine(demo.Add(2, 3));
            //Console.WriteLine(demo.Sub(11,5));
            #endregion

            #region Nullable Types
            //// When database/anyone: returns null value for value type containers of C# (like int, double, bool, char, DateTime etc) then it will create problem.Hence we need to create Nullable type variables: Nullable<T> name = null;
            // Assigning null value to a value type
            //int? x = null;
            //Nullable<int> number = null;
            //Nullable<double> salary = null;
            //Console.WriteLine(salary);

            //int? no = 10;
            //if (no.HasValue)
            //{
            //    Console.WriteLine($"no has value: {no.Value}");
            //}
            //else
            //{
            //    Console.WriteLine("no is null");
            //}
            #endregion

            #region Object Initializer
            //// We can initialize objects while declaring it using {} brackets, internally at backend - compiler will generate combinations of overloaded constrctors syntaxes for us. This will keep our class clean and readable.
            //Emp emp1 = new Emp() { Id = 100 };
            //Console.WriteLine(emp1.Id);
            //Emp emp2 = new Emp() { Name = "Hugh", Address = "NYC" };
            //Console.WriteLine(emp2.Name + emp2.Address);
            //Emp emp3 = new Emp() { Address = "Pune", Id = 34 };
            #endregion

            #region Collection Initializer
            //int[] arr = new int[3];
            //arr[0] = 1;
            //arr[1] = 2;
            //arr[2] = 3;

            //int[] arr = new int[] { 1, 2, 3 };

            //string[] days = new string[] { "Mon","Tue"};

            //Console.WriteLine("Enter your first name:");
            //string fnm = Console.ReadLine();
            //Console.WriteLine("Enter your last name:");
            //string lnm = Console.ReadLine();

            //string[] personInfo = new string[] {fnm, lnm };
            //for (int i = 0; i < personInfo.Length; i++)
            //{
            //    Console.WriteLine(personInfo[i]);
            //}

            //List<string> lst = new List<string>() { fnm, lnm};
            ////lst.Add(fnm);
            ////lst.Add(lnm);
            //for (int i = 0; i < lst.Count; i++)
            //{
            //    Console.WriteLine(lst[i]);
            //}

            #endregion

            #region Auto-properties
            // If there is a scenario where names of the private members does not matter: then we go for auto-property syntax: where compiler generates : Private Memebrs along with getter and setter methods for us. And we use or communicate with the help of public properties.
            // Please note: we can not do any kind of validations or changes using property syntax or by using private memeber names
            // Consider this as a temporary holder classes

            //Emp emp4 = new Emp() { Address = "Mumbai", Id = 23};
            #endregion

            #region Implict Type
            // Temporary holder
            // Defination at Compile Time
            // Local Scope : at level of declaration.
            // var can not be pass as a parameter to a function, can not declare as a return type of a function.
            //int x = 20;
            //string nm = "Hugh";

            //object obj = GetMeSOmething(2);
            //if (obj is Emp)
            //{
            //    Emp emp1 = obj as Emp;
            //    Console.WriteLine(emp1.GetEmpData());
            //}

            //var num = 100;

            //var emp = new Emp() { Name = "Rob" };
            //Console.WriteLine(emp.GetEmpData());

            //var obj1 = GetMeSOmething(2);
            //if (obj1 is Emp)
            //{
            //    Emp emp2 = obj1 as Emp;
            //    Console.WriteLine(emp2.GetEmpData());
            //}
            #endregion

            #region Anonymous Types
            // Without name: Nameless Class

            //Emp e1 = new Emp() { Id = 1, Name = "Tom", Address="LA"};
            //Emp e2 = new Emp() { Name = "Rob", Id = 34};

            //var e3 = new Emp() { Id = 1, Name = "Tina", Address = "Pune" };
            // Console.WriteLine(e3.GetType().ToString());

            // Anonymous type class
            // PRoperty Name and its sequence, and not datatype
            // var v1 = new { Id = 1, Name = "Tina", Address = "Pune" };
            //          Console.WriteLine(v1.GetType().ToString());

            //var v2 = new { Id = 12, Name = "Peter", Address = "Satara" };
            //          Console.WriteLine(v2.GetType().ToString());

            //var v6 = new { Id = 12, Name = 23.33, Address = "Satara" };
            //          Console.WriteLine(v6.GetType().ToString());

            //var v4 = new { Id = 12, Address = "Satara", Name = "Peter" };
            //          Console.WriteLine(v4.GetType().ToString());
            // var v5 = new { Address = "Satara", Name = "Peter" };
            //          Console.WriteLine(v5.GetType().ToString());

            #region Holder 
            //Console.WriteLine("ENter Id: ");
            //int id = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter name: ");
            //string? nm = Console.ReadLine();
            //Console.WriteLine("Enter address: ");
            //string? add = Console.ReadLine();
            ////var v3 = new Holder { HId = id,HName = nm, HAddress = add};
            //var v3 = new { HId = id, HName = nm, HAddress = add };
            //Console.WriteLine(v3.GetType().ToString()); 
            #endregion
            #endregion

            #region Anonymous Method and Lambda function

            int x = 15;
            #region Normal Function call
            //if (Check(x))
            //{
            //    Console.WriteLine($"{x} is greater than 10");
            //}
            //else
            //{
            //    Console.WriteLine($"{x} is less than 10");
            //} 
            #endregion

            #region Checkdelegate call
            //CheckDelegate del = new CheckDelegate(Check);
            //if (del(x))
            //{
            //    Console.WriteLine($"{x} is greater than 10");
            //}
            //else
            //{
            //    Console.WriteLine($"{x} is less than 10");
            //} 
            #endregion

            #region Anonymous MEthod: delegate keyword
            //CheckDelegate del = new CheckDelegate(delegate (int num)
            //                                        {
            //                                            return num > 10;
            //                                        });
            //            if (del(x))
            //            {
            //                Console.WriteLine($"{x} is greater than 10");
            //            }
            //            else
            //            {
            //                Console.WriteLine($"{x} is less than 10");
            //            } 
            #endregion


            #region Lambda function: => goes to operator
            //CheckDelegate del = new CheckDelegate(num => num > 10);
            //if (del(x))
            //{
            //    Console.WriteLine($"{x} is greater than 10");
            //}
            //else
            //{
            //    Console.WriteLine($"{x} is less than 10");
            //} 
            #endregion

            #endregion


            #region Predicate delegate : Built- in
            //Predicate<int> evenpredicate = num => num % 2 == 0;
            //Console.WriteLine($"{12} is Even : {evenpredicate(12)}");


            //Predicate<int> predicate = num => num > 10;
            ////Console.WriteLine(predicate(23));
            //if (predicate(x))
            //{
            //    Console.WriteLine($"{x} is greater than 10");
            //}
            //else
            //{
            //    Console.WriteLine($"{x} is less than 10");
            //} 
            #endregion

            #region Extension Method
            //// extend functionality of built-in types : 
            //// 1. Static class
            //// 2. MEthod : static Method 
            //// 3. this keyword
            //int[] numbers = { 1, 2, 3, 4, 5 };
            //Console.WriteLine(numbers.Sum());
            ////numbers.changeArrayType
            ////MyClass obj = new MyClass();
            //List<int> nums = numbers.changeArrayType();
            //for (int i = 0; i < nums.Count; i++)
            //{
            //    Console.WriteLine($"{nums[i]}");
            //}

            //string email = "something@gmail.com";
            ////email.CheckForValidEmailAddress();

            ////Attribute [] attribute = attr.ToArray();

            ////bool isValidEmail =obj.CheckForValidEmailAddress(email);
            //bool isValidEmail = email.CheckForValidEmailAddress();
            //Console.WriteLine(isValidEmail);

            //double sal = 2345.678;
            //int salary = sal.Demo(false,"abcd");
            //Console.WriteLine(salary);

            #endregion

            #region Iterator, Custom Collection
            //List<int> list = new List<int>();
            //list.Add(1);
            //list.Add(2);
            //list.Add(3);
            //list.Add(4);
            //list.Add(5);
            ////foreach (var item in list)
            ////{
            ////    Console.WriteLine(item); // 1,2,3,4,5
            ////}

            ////for (int i = 0; i < list.Count; i++)
            ////{
            ////    Console.WriteLine(list[i]);
            ////}

            //CustomCollection myCollection = new CustomCollection();
            //myCollection.Add("Mon");
            //myCollection.Add("Tue");
            //myCollection.Add("Wed");
            ////myCollection.GetEnumerator()// index: 0, 1
            //foreach (string item in myCollection) 
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion
        }

        static bool Check(int num)
        {
            return num > 10;
            //if (num > 10)
            //{
            //    return true;
            //}
            //else
            //{
            //    return false;
            //}
        }
        static object GetMeSOmething(int ch)
        {
            if (ch == 1)
                return 100;
            else if (ch == 2)
                return new Emp() { Id = 22, Name = "Peter", Address = "Mumbai" };
            else
                return true;
        }
    }
    public class CustomCollection : IEnumerable
    {
        private List<string> _items = new List<string>();

        public void Add(string element)
        {
            _items.Add(element);
        }

        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < _items.Count; i++)
            {
                yield return _items[i];//0,1
            }
        }
    }
    public class MyCollection<T> : IEnumerable<T>
    {
        private readonly List<T> _items = new List<T>();

        // Add method to insert items
        public void Add(T item)
        {
            _items.Add(item);
        }

        // Generic enumerator
        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < _items.Count; i++)
            {
                yield return _items[i];
            }
        }

        // Non-generic enumerator required by IEnumerable
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }


    }
    public class MyCollection : IEnumerable
    {
        private string[] days = new string[] { "Monday", "Tuesday", "Wedensday", "Thrusday", "Firday", "Saturday", "Sunday" };

        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < days.Length; i++)
            {
                string day = days[i];
                yield return day; // yield keyword is used to return the value from the iterator method. And it maintains last index value.
            }
        }

        //public string[] Days
        //{
        //    get { return days; }
        //}
    }
    public class Holder
    {
        public int HId { get; set; }
        public string HName { get; set; }
        public string HAddress { get; set; }
    }
    public class Emp
    {
        #region Auto-properties
        //prop
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        #endregion

        #region Full Properties along with private member
        //private int _ID;
        //private string _Name;
        //private string _Address;

        //public string Address
        //{
        //    get { return _Address; }
        //    set { _Address = value; }
        //}
        //public string Name
        //{
        //    get { return _Name; }
        //    set { _Name = value; }
        //}
        //public int Id
        //{
        //    get { return _ID; }
        //    set { _ID = value; }
        //}
        #endregion

        #region ctor overloadding
        //public Emp(int id)
        //{
        //    _ID = id;
        //}
        //public Emp(int id, string nm)
        //{
        //    _ID = id;
        //    _Name = nm;
        //}
        //public Emp(int id, string nm, string add)
        //{
        //    _ID = id;
        //    _Name = nm;
        //    _Address = add;
        //}
        //public Emp(string nm, string add)
        //{
        //    _Name = nm;
        //    _Address = add;
        //} 
        #endregion

        public string GetEmpData()
        {
            return $"Id: {Id}, Name: {Name}, Address; {Address}";
        }

    }

    public static class MyClass
    {
        // this parameter should be the first parameter of extension method. 
        public static int Demo(this double d, bool b, string test)
        {
            Console.WriteLine($"{b}, {test}");
            return Convert.ToInt32(d);
        }
        public static bool CheckForValidEmailAddress(this string email)
        {
            return email.Contains("@");
        }
        public static List<int> changeArrayType(this int[] arr)
        {
            List<int> lst = new List<int>();

            for (int i = 0; i < arr.Length; i++)
            {
                lst.Add(arr[i]);
            }

            return lst;
        }
    }
}
