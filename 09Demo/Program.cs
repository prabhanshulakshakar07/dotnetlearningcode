namespace _09Demo_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
    //public sealed class Base
    public class Base
    {
        public virtual void Display()
        {
            Console.WriteLine("Display from Base");
        }
    }
    public class Derived : Base
    {
        public sealed override void Display()
        {
            Console.WriteLine("Display from Derived");
        }
    }
    public class SecondDerived : Derived
    {
        // 'SecondDerived.Display()': cannot override inherited member 'Derived.Display()' because it is sealed
        //public override void Display()
        //{
        //    Console.WriteLine("Display from SecondDerived");
        //}
    }
}