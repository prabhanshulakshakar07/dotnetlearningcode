using System.Threading.Channels;

namespace _12Demo_OOP_Abstract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Demo 01 
            //Derived derived = new Derived();
            //derived.Show();
            //Console.WriteLine(derived.Add(10, 20));
            //derived.Display();

            //Base baseObj = new Derived();
            //baseObj.Display(); 
            #endregion

            Calculator obj = new Calculator();
            obj.Add(10, 20);
            BaseCalculator basecalc = new Calculator();
            basecalc.Add(10, 20);
            CMath cmath = new Calculator();
            cmath.Add(10, 20);
        }
    }

    public abstract class Base
    {
        // Pure virtual methods
        public abstract void Show();
        public abstract int Add(int x, int y);

        public void Display()
        {
            Console.WriteLine("Display from Base");
        }
    }
    public class Derived : Base
    {
        public override void Show()
        {
            Console.WriteLine("Show from Derived");
        }

        public override int Add(int x, int y)
        {
            return x + y;
        }

        public new void Display()
        {
            Console.WriteLine("Display from Derived");
        }
    }

    public abstract class CMath
    {
        public abstract void Add(int x, int y);
        public abstract void Sub(int x, int y);
        public abstract void Mult(int x, int y);
    }
    public abstract class BaseCalculator : CMath
    {
        public abstract void Div(int x, int y);
        public override void Add(int x, int y)
        {
            Console.WriteLine($"Add = {x + y}");
        }
    }
    public class Calculator : BaseCalculator
    {
        public override void Sub(int x, int y)
        {
            Console.WriteLine($"Sub = {x - y}");
        }
        public override void Mult(int x, int y)
        {
            Console.WriteLine($"Mult = {x * y}");
        }
        public override void Div(int x, int y)
        {
            Console.WriteLine($"Div = {x / y}");
        }
    }
}