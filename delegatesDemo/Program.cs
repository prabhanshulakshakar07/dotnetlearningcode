namespace delegatesDemo
{



    //delegare - a type safe function pointer in .net

    public delegate void MyDeelegate();

    public delegate string MyDelegate2();
    public delegate string MyDelagte3(string nm);

     public delegate int AddDelegate(int p, int q);
    public delegate object randomDel(int ch);






    internal class Program
    {
        static void Main(string[] args)
        {

            Demo obj =new Demo();

            MyDeelegate del1 = new MyDeelegate(obj.Hi);
            del1();

            AddDelegate addDe1 = new AddDelegate(obj.Add);
            int addResult = AddDelegate(2, 3);
            Console.WriteLine(addResult);

            randomDel delObj = new randomDel(obj.Dosomething);

            object something= delObj(3);

            Console.WriteLine(something.ToString());





        }

        private static int AddDelegate(int v1, int v2)
        {
            throw new NotImplementedException();
        }

        static void Show()
        {
            Console.WriteLine("Show Method");
        }
        static void Display()
        {
            Console.WriteLine("Display Method");
        }
        static string Greet()
        {
            return "hello, How are you ?";

        }

        static string Hello(string name)
        {
            return $"Hello,{name}";
        }
       






    }

    public class Demo
    {
        //delegate void delm()
        public void Hi()
        {
            Console.WriteLine("Hi");
        }
        public int Add(int x, int y)
        {
            return x + y;
        }

        public object Dosomething(int ch)
        {
            if (ch == 0)
            {
                return 10;

            }
            else if (ch == 2)
            {
                return "Prabhanshu Lakshakar";
            }
            else
            {
                return true;
            }
        }

    }










}
