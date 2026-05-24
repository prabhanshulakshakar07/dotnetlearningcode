using DelegateMethod;

namespace DelegateMethod
{

    //Delegate retur type int ke sath 
    public delegate int MultiplyDelegate(int x, int y);

    internal class Program
    {
        static void Main(string[] args)
        {
            MultiplyDelegate multiply = delegate (int a, int b)
            { return a * b; };


            //The biggest magic is happening here. Consider it in three small parts:
            //MultiplyDelegate multiply: You created a variable whose data type is the above delegate.
            //This variable will not hold any normal value (like 5 or 10),
            //it will hold the entire function within itself (Pointer) .

            //= delegate (int a, int b): You used the keyword =by putting .
            //This means you generated a function without giving it a name ( ) that takes two inputs and .delegateAnonymousab

            //{ return a * b; };: You wrote the body of the missing function, which, when executed,
            //multiplies both numbers and returns them. ; I put it at the end because
            //this entire block is an assignment statement (like int x = 5; this one).

            int result = multiply(5, 6);
            Console.WriteLine("Multiply Result: " + result);


        }
    }
}


