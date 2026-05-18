namespace _05Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region DataTypes

            //int x = 100;
            //Console.WriteLine(x);
            //Type xtype = x.GetType();
            //Console.WriteLine(xtype.ToString()); // System.Int32
            //Int32 y = 55;
            //Console.WriteLine(y.GetType().ToString());// System.Int32
            //double d = 23.33; //System.Double
            //Console.WriteLine(d.GetType().ToString());
            //string str = "Hello";
            //char[] name = new char[5] { 'f', 'i', 'v', 'e', '.' };
            //String str1 = new String(name);
            //Console.WriteLine(str1); 

            #endregion

            #region Input from User 

            //Console.WriteLine("Enter first number: ");
            //int fst =Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter second number: ");
            //int sec = Convert.ToInt32(Console.ReadLine());
            //int sum = fst + sec;
            //Console.WriteLine("Addition = "+ sum);
            //bool isSleepy = true;
            //Console.Read();
            //Console.ReadKey();
            //Console.ReadLine();
            ////Convert.ToBoolean();
            ////Convert.ToInt16(); 

            #endregion

            #region Boxing, Unboxing, Type Casting

            // value Types : bool, int, double, decimal, long, enum, struct
            // Reference Type : class, string, MyClass etc
            // Boxing : converting value type into Reference Type.
            int num = 10;
            //Boxing
            string number = Convert.ToString(num); // num.To String()
            Console.WriteLine(number + " " + number.GetType().ToString());

            // Unboxing : converting reference type again back to value type.
            int no = Convert.ToInt32(number);
            Console.WriteLine(no + " " + no.GetType().ToString());

            Object obj = 100; // Boxing
            //Object obj2 = obj; // Assignment
            // Type- casting : converting value type to value type OR refernce type to reference type
            string str = obj.ToString(); // Type- casting
            int j = Convert.ToInt32(str); // Unboxing
            Console.WriteLine(j);
            #endregion

        }
    }

    public class MyClass
    {

    }
}