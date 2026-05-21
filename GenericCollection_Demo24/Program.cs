namespace GenericCollection_Demo24
{
    internal class Program
    {
        static void Main(string[] args)
        {
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

            // Generic Collection : System.Collection.Generic
            // Strongly - typed collection
            #region List<int> 
            //List<int> numbers = new List<int>();
            //numbers.Add(11);
            //numbers.Add(12);
            //numbers.Add(13);
            //numbers.Add(14);

            //for (int i = 0; i < numbers.Count; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //} 
            #endregion

            #region List<Emp>
            //List<Emp> allEmps = new List<Emp>();
            //allEmps.Add(emp1);
            //allEmps.Add(emp2);
            //allEmps.Add(emp3);
            //foreach (Emp emp in allEmps)
            //{
            //    emp.GetEmpDetails();
            //} 
            #endregion

            // Key-Value Pair collection
            Dictionary<int, Emp> dt = new Dictionary<int, Emp>();
            dt.Add(1, emp1);
            dt.Add(2, emp2);
            dt.Add(3, emp3);

            foreach (int key in dt.Keys)
            {
                Console.WriteLine(key);
            }
            foreach (Emp emp in dt.Values)
            {
                emp.GetEmpDetails();
            }
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