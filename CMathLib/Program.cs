namespace CMathLib
{
    public class CMath
    {
        // Accessible with the same assembly as well as outside the assembly/ with OR without inheritance
        public void Add(int x, int y)
        {
            Console.WriteLine($"Public : Add = {x + y}");
        }
        // Accessible only within the class
        private void Sub(int x, int y)
        {
            Console.WriteLine($"Private : Sub = {x - y}");
        }
        // Accessible only within inherited hirarchey
        protected void Mult(int x, int y)
        {
            Console.WriteLine($"Protected : Mult = {x * y}");
        }
        // Only accessible within the same assembly:/ Public to in the same assembly
        internal void Div(int x, int y)
        {
            Console.WriteLine($"Internal : div = {x / y}");
        }
        // Accessible only within inherited hirarchey as well as Public to same assembly
        protected internal void Square(int x)
        {
            Console.WriteLine($"Protected-internal : Square = {x * x}");
        }
    }

    public class MyClass
    {
        CMath obj = new CMath();
        public void Test()
        {
            obj.Square(4);
            obj.Div(100, 20);
            obj.Add(100, 20);
        }
    }
    public class Demo : CMath
    {
        public void MyDemo()
        {
            base.Square(4);// P-I
            base.Div(100, 20); // I
            base.Mult(100, 20); // Pt
            base.Add(100, 20);
        }
    }
}