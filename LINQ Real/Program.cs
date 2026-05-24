namespace LINQ_Real
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // LINQ - Language Intergrated Query
            // LINQ to Collection Query

            List<Emp> emps = new List<Emp>() {
                new Emp(){ Id = 1, Name = "Ramesh", Address = "pune"},
                new Emp(){ Id = 2, Name = "Suresh", Address = "mumbai"},
                new Emp(){ Id = 3, Name = "Prathamesh", Address = "panji"},
                new Emp(){ Id = 4, Name = "Jignesh", Address = "mathura"},
                new Emp(){ Id = 5, Name = "Mahesh", Address = "konkan"},
                new Emp(){ Id = 6, Name = "Gopal", Address = "puri"},
                new Emp(){ Id = 7, Name = "Ganesh", Address = "manipur"},
                new Emp(){ Id = 8, Name = "Kalpesh", Address = "patna"},
                new Emp(){ Id = 9, Name = "Prafull", Address = "panvel"},
                new Emp(){ Id = 10, Name = "Jaydeep", Address = "wakanda"}
            };


            var filteredEmpData = emps.Where(emp => emp.Address.StartsWith("m")).Select(emp => emp).ToList();


            #region Normal filter logic code 
            //Console.WriteLine("Enter your city: ");
            //string? city = Console.ReadLine().ToLower();

            //List<Emp> filteredEmps = new List<Emp>();
            //for (int i = 0; i < emps.Count; i++)
            //{
            //    //if (emps[i].Address == city)
            //    if (emps[i].Address.StartsWith(city))
            //    {
            //        Emp emp = emps[i];
            //        //Console.WriteLine($"Id: {emp.Id}, Name: {emp.Name}, Address = {emp.Address}");
            //        filteredEmps.Add(emp);
            //    }
            //}
            //foreach (var emp in filteredEmps)
            //{
            //    Console.WriteLine($"Id: {emp.Id}, Name: {emp.Name}, Address = {emp.Address}");
            //} 
            #endregion


            #region LINQ demo 
            // LINQ Declaration
            //var result = (from emp in emps
            //              where emp.Address.StartsWith("m")
            //              select emp).ToList();

            //emps.Add(new Emp() { Id = 11, Name = "Mitesh", Address = "mangolia" });

            //// Lazy -Loading / Delayed execution of LINQ
            //// LINQ query gets fired when ever you start using it. just like foreach loop OR .ToList() method
            //foreach (Emp emp in result)
            //{
            //    Console.WriteLine($"Id: {emp.Id}, Name: {emp.Name}, Address = {emp.Address}");
            //}
            #endregion


            #region LINQ - Holder class
            // Returning Tuple
            //var result = (from emp in emps
            //              where emp.Address.StartsWith("m")
            //              select (emp.Name,emp.Address));

            //var result = (from emp in emps
            //              where emp.Address.StartsWith("m")
            //              select new Holder { HName = emp.Name, HAddress= emp.Address});

            //foreach (Holder h in result)
            //{
            //    Console.WriteLine($"NAme: {h.HName}, Address: {h.HAddress}");
            //}
            //foreach (string nm in result)
            //{
            //    Console.WriteLine($"{nm}");
            //}
            #endregion




            var result = (from emp in emps
                          where emp.Address.StartsWith("m")
                          select new { HName = emp.Name, HAddress = emp.Address });

            foreach (var h in result)
            {
                Console.WriteLine($"NAme: {h.HName}, Address: {h.HAddress}");
            }

            #region LINQ on int[] collection
            //int[] numbers = { 1, 2, 3, 4, 5 };
            //var result = (from no in numbers
            //              orderby no descending
            //              select no * 2);

            //foreach (int no in result)
            //{
            //    Console.WriteLine(no);
            //} 
            #endregion




        }
    }











    public class Emp
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
    }

    public class Holder
    {
        public string HName { get; set; }
        public string HAddress { get; set; }
    }
}
