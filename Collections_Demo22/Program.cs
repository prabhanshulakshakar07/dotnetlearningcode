
using System.Collections;

namespace Collections_Demo22
   {
    internal class Program
    {
        static void Main(string[] args)
        {
            #region int[] 
            //int[] arr = new int[3];
            //arr[0] = 10;
            //arr[1] = 20;
            //arr[2] = 30;
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.WriteLine($"index:{i}, value = {arr[i].ToString()}");
            //} 
            #endregion

            #region string [] 
            //string[] days = new string[4];
            //days[0] = "Mon";
            //days[1] = "Tue";
            //days[2] = "Wed";
            //days[3] = "Thu";

            //for (int i = 0; i < days.Length; i++)
            //{
            //    Console.WriteLine(days[i]);
            //} 
            #endregion

            Book book = new Book();
            book.Title = "Alchemist";

            Emp emp1 = new Emp();
            emp1.Id = 1;
            emp1.Name = "Hugh Jackman";
            emp1.Address = "NEw York";

            Emp emp2 = new Emp();
            emp2.Id = 2;
            emp2.Name = "Tom Ellis";
            emp2.Address = "London";

            Emp emp3 = new Emp();
            emp3.Id = 3;
            emp3.Name = "Tom Cruise";
            emp3.Address = "LA";

            #region Emp[] 
            //Emp[] empArr = new Emp[3];
            //empArr[0] = emp1;
            //empArr[1] = emp2;
            //empArr[2] = emp3;

            //for (int i = 0; i < empArr.Length; i++)
            //{
            //    Emp obj = empArr[i];
            //    obj.GetEmpDetails();
            //} 
            #endregion


            #region object [] , is , as keywords
            //object[] objArr = new object[6];
            //objArr[0] = 10; // Box
            //objArr[1] = 55.23; // Box
            //objArr[2] = emp1; // Type casting
            //objArr[3] = "Hello"; // Type casting
            //objArr[4] = true; // Box
            //objArr[5] = book; // Type casting

            //for (int i = 0; i < objArr.Length; i++)
            //{
            //    object obj = objArr[i];
            //    //Console.WriteLine(obj.GetType().ToString());
            //    //if (obj.GetType().ToString() == "System.Int32")
            //    if (obj is int)
            //    {
            //        int j = Convert.ToInt32(obj); // Unboxing
            //        Console.WriteLine(j);
            //    }
            //    //if (obj.GetType().ToString() == "System.Double")
            //    if (obj is double)
            //    {
            //        double d = Convert.ToDouble(obj);
            //        Console.WriteLine(d);
            //    }
            //    //if (obj.GetType().ToString() == "System.String")
            //    if (obj is string)
            //    {
            //        Console.WriteLine(obj.ToString());
            //    }
            //    //if (obj.GetType().ToString() == "System.Boolean")
            //    if (obj is bool)
            //    {
            //        bool b = Convert.ToBoolean(obj);
            //        Console.WriteLine(b);
            //    }
            //    if (obj.GetType().ToString() == "_22Demo_Collections.Emp")
            //    {
            //        Emp emp = (Emp)obj;
            //        emp.GetEmpDetails();
            //    }
            //    if (obj is Emp)
            //    {
            //        Emp emp = obj as Emp;
            //        emp.GetEmpDetails();
            //    }
            //    if (obj is Book)
            //    {
            //        Book bk = obj as Book;
            //        Console.WriteLine(bk.Title);
            //    }
            //    if (obj.GetType().ToString() == "_22Demo_Collections.Book")
            //    { 
            //        Book bk = (Book)obj;
            //        Console.WriteLine(bk.Title);
            //    }
            //} 
            #endregion

            // Collections : growable size... all elemnts you store in the form of objects. 1D array

            // System.Collection namespace 
            // Object collection : 1D 
            #region ArrayList 
            //ArrayList arrObj = new ArrayList();
            //arrObj.Add(10);
            //arrObj.Add(55.34);
            //arrObj.Add(emp1);
            //arrObj.Add(emp2);
            //arrObj.Add(book);
            //for (int i = 0; i < arrObj.Count; i++)
            //{
            //    if (arrObj[i] is int)
            //    {
            //        int j = Convert.ToInt32(arrObj[i]);
            //        Console.WriteLine(j);
            //    }
            //    if (arrObj[i] is double)
            //    { 
            //        double d = Convert.ToDouble(arrObj[i]);
            //        Console.WriteLine(d);
            //    }
            //    if (arrObj[i] is Emp)
            //    {
            //        Emp emp = arrObj[i] as Emp;
            //        emp.GetEmpDetails();
            //    }
            //    if (arrObj[i] is Book)
            //    {
            //        Book bk = arrObj[i] as Book;
            //        Console.WriteLine(bk.Title);
            //    }
            //} 
            #endregion


            #region stack : Non- generic Collection
            //Stack st = new Stack();
            //st.Push(10);
            //st.Push(20);
            //st.Push(30);
            //Console.WriteLine(st.Pop()); // 30
            //for (int i = 0; i <= st.Count; i++)
            //{
            //    Console.WriteLine(st.Pop()); // 20, 10
            //} 
            #endregion

            #region Queue
            //Queue qu = new Queue(); ;
            //qu.Enqueue(10);
            //qu.Enqueue(20);
            //qu.Enqueue(30);
            //Console.WriteLine(qu.Dequeue()); 
            #endregion

            #region Hashtable
            //// HashTable: Key - value PAir Based Collection
            //// Key - Object, Value -> Object 
            //// Non - generic key-value pair based collection
            //Hashtable ht = new Hashtable();
            //ht.Add(1, 100);
            //ht.Add(2, 200);
            //ht.Add(3, 300);
            //ht.Add(1, 100);
            //ht.Add("abc", 23.33);
            //ht.Add(3, emp1);

            //for (int i = 0; i <= ht.Count; i++)
            //{

            //    Console.WriteLine(ht[i]);
            //}
            //foreach (object element in ht)
            //{
            //    Console.WriteLine(element);
            //}
            //foreach (object key in ht.Keys)
            //{
            //    Console.WriteLine(key);
            //}
            //foreach (object val in ht.Values)
            //{
            //    Console.WriteLine(val);
            //} 
            #endregion


            #region Tuples () collection
            var result = GetMesOmething();
            Console.WriteLine($"Num:{result.num}, Name:{result.nm}, Salary: {result.sal}");
            #endregion
        }
        // This method is to demo how to return tuples collection.
        static (int num, string nm, double sal) GetMesOmething()
        {
            int number = 234;
            string name = "Hugh Jackman";
            double salary = 80000;
            //object[] / ArrayList
            return (number, name, salary);
        }
    }

    public class Book
    {
        private string _Title;

        public string Title
        {
            get { return _Title; }
            set { _Title = value; }
        }
    }
    public class Emp
    {
        private int _id;
        private string _Name;
        private string _Address;
        public string Address
        {
            set { _Address = value; }
            get { return _Address; }
        }
        public string Name
        {
            set { _Name = value; }
            get { return _Name; }
        }
        public int Id
        {
            set { _id = value; }
            get { return _id; }
        }

        public void GetEmpDetails()
        {
            Console.WriteLine($"Id: {this.Id}, Name:{Name}, Address: {Address}");
        }
    }
}

