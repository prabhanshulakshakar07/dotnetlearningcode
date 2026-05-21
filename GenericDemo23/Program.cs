namespace GenericDemo23
{


    public delegate void MyDel<T>(T fnm, T lnm);
    public delegate void MyFooDel<T1, T2, T3>(T1 x, T2 y, T3 z);
    public delegate void MyDel2<T1, out T2>();



    internal class Program
    {
        static void Main(string[] args)
        {
            #region Generic 
            //Demo demo = new Demo();
            //MyDel<string> del1 = new MyDel<string>(demo.Greet);
            //del1("Hugh", "Jackman");

            //double d = demo.MethodA<int, string, double, bool>(11,"Bob",45678.45,false);
            //Console.WriteLine(d);

            //MyFooDel<int, int, int> del = new MyFooDel<int, int, int>(demo.foo);
            //del(22,44,66); 
            #endregion

            #region dynamic Types , out keyword
            //CMath cmath = new CMath();
            //Console.WriteLine(cmath.Add<int>(2, 3));

            //double a, c;
            //cmath.Calculate(5,out a,out c);
            //Console.WriteLine($"Area = {a}, Circumference = {c}"); 
            #endregion

            int[] numbers = new int[3];
            numbers[0] = 10;
            numbers[1] = 20;
            numbers[2] = 30;

            Myclass obj = new Myclass();

            Console.WriteLine(obj.Sum(numbers));

            obj.GreetThePlayers("Peter", "Bob", "Tim", "Jack");

        }
    }







    public class Myclass
    {
        public int Sum(int[] arr)
        {
            int add = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                add += arr[i];
            }
            return add;


        }

        public void GreetThePlayers(params string[] names)
        {
            for (int i = 0; i < names.Length; i++) {

                Console.WriteLine($"Hello {names[i]}");


            }


        }
    }

    public class Demo
    {
        public void Greet<T>(T fnm , T lnm)
        {
            Console.WriteLine($"Hello , {fnm} {lnm}");
        }

        public R MethodA<P,Q,R,S>(P id, Q name , R sal, S isActive)
        {
            Console.WriteLine($"Id: {id}, Name: {name}, Salary: {sal}, IsActive: {isActive}");
            return sal;
        }

        public void foo<T1,T2,T3>(T1 para1, T2 para2, T3 para3)
        {
            Console.WriteLine($"Para1: {para1}, Para2: {para2}, Para3: {para3}");
        }


    }

    public class CMAth
    {
        public T Add<T>(T x, T y)
        {
            dynamic x1 = x;
            dynamic y1 = y;

            return x1 + y1;
        }

        public void Calculate(double radius, out double area, out double circumference)
        {
            area = 3.14 * radius * radius;
            circumference = 2 * 3.14 * radius;
        }








    }

















    
























}
