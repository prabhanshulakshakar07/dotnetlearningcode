namespace GenericDemo25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Pass by Value and Pass by Refernce
            //int p = 10;
            //int q = 20;
            //Console.WriteLine($"Before Swapping: P = {p}, Q = {q}");
            //MyClass obj = new MyClass();
            ////obj.Swap(p, q);// Pass by Value
            //obj.Swap(ref p, ref q); // Pass By Refernce
            //Console.WriteLine($"After Swapping: P = {p}, Q = {q}");

            //string s1 = "Hello";
            //string s2 = "Bye";
            //Console.WriteLine($"Before Swapping: S1 = {s1}, S2 = {s2}");
            //obj.Swap(ref s1, ref s2);
            //Console.WriteLine($"After Swapping: S1 = {s1}, S2 = {s2}"); 
            #endregion

            int p = 10;
            int q = 20;
            Console.WriteLine($"Before Swapping: P = {p}, Q = {q}");
            //MyClass<int> obj = new MyClass<int>();

            Myclass obj = new Myclass();


            obj.Swap<int>(ref p, ref q);
            Console.WriteLine($"After Swapping: P = {p}, Q = {q}");

            string s1 = "Hello";
            string s2 = "Bye";
            Console.WriteLine($"Before Swapping: S1 = {s1}, S2 = {s2}");
            obj.Swap<string>(ref s1, ref s2);
            Console.WriteLine($"After Swapping: S1 = {s1}, S2 = {s2}");
        }
    }
}



//public class Myclass <T> generic class

//Generic Class

public class Myclass
{
    // generic method inside a non - generic class
    //public void swap<T>(ref T a, ref T b)



    public void Swap<T>(ref T x, ref T y)
    {
        T temp;
        temp = x;
        x = y;
        y = temp;

    }


    #region Same logic but different datatypes
    //public void Swap(ref int x,ref int y)
    //{
    //    int temp;
    //    temp = x;
    //    x = y;
    //    y = temp;
    //}

    //public void Swap(ref string x, ref string y)
    //{
    //    string temp;
    //    temp = x;
    //    x = y;
    //    y = temp;
    //} 
    #endregion






}




