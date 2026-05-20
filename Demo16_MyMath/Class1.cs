
using CMathLib;
namespace  Demo16_MyMath
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CMath cmath = new CMath();
            cmath.Add(2, 3);

            AdvMath adv = new AdvMath();
            adv.Add(2, 3);
            adv.wrapperMult(5, 7);
            adv.wrapperSquare(9);

            MyClass myClass = new MyClass();
            myClass.Test();

            Demo demo = new Demo();
            demo.MyDemo();

        }
    }
    public class AdvMath : CMath
    {
        // Wrapper Method
        public void wrapperMult(int x, int y)
        {
            base.Mult(x, y);
        }
        public void wrapperSquare(int x)
        {
            base.Square(x);
        }
    }
}