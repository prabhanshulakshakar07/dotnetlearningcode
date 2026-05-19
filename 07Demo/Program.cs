namespace _07Demo_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Demo 01 
            //Derived derived = new Derived(567);
            //Console.WriteLine(derived._baseid);
            //derived.Show();

            //Base baseobj = new Derived(67);
            //baseobj.Show(); 
            #endregion

            Derived d = new Derived(4);
            d.Display();
            d.Method1();
            d.Method1("Bob");
        }
    }
    public class Base
    {
        public int _baseid;
        public Base(int id)
        {
            _baseid = id;
        }
        public void Show()
        {
            Console.WriteLine("Show method from Base class");
        }
        public virtual void Display()
        {
            Console.WriteLine("Display method from Base class");
        }
        public void Method1()
        {
            Console.WriteLine("Method1 method from Base class");
        }
    }
    public class Derived : Base
    {
        public int _derivedid;

        // This is ctor mapping / chaining
        public Derived(int id) : base(id)
        {
            _derivedid = 2;
        }
        // Shadowing
        public new void Show()
        {
            Console.WriteLine("Show method from Derived class");
        }

        public override void Display()
        {
            Console.WriteLine("Display method from Derived class");
        }
        public void Method1(string nm)
        {
            Console.WriteLine($"Method1 method from Derived class {nm}");
        }
    }
}