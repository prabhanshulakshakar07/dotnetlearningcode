namespace _10Demo_OOP_Interface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Implicat Way demo: 
            //CMath cmath = new CMath();
            //Console.WriteLine($"Add= {cmath.Add(2, 3)}");
            //Console.WriteLine($"Sub= {cmath.Sub(2, 3)}");
            //Console.WriteLine($"Mult= {cmath.Mult(2, 3)}");

            //// Client 1: 
            //IX xObj = new CMath();
            //Console.WriteLine($"Add= {xObj.Add(2, 3)}");
            //Console.WriteLine($"Sub= {xObj.Sub(2, 3)}");

            //// Client 2: IY
            //IY yObj = new CMath();
            //Console.WriteLine($"Mult= {yObj.Mult(2, 3)}"); 
            #endregion

            #region Explicit Way demo: 

            // Client 1: 
            IX xObj = new CMath();
            Console.WriteLine($"Add= {xObj.Add(2, 3)}");
            Console.WriteLine($"Sub= {xObj.Sub(2, 3)}");

            // Client 2: IY
            IY yObj = new CMath();
            Console.WriteLine($"Add= {yObj.Add(2, 3)}");
            Console.WriteLine($"Mult= {yObj.Mult(2, 3)}");

            #endregion

        }
    }
    public interface IX
    {
        // method declarations: implementation force 
        int Add(int x, int y);
        int Sub(int x, int y);
    }
    public interface IY
    {
        int Add(int x, int y);
        int Mult(int x, int y);
    }
    // Explicit Way of Interface Implementation
    public class CMath : IX, IY
    {
        int IX.Add(int x, int y)
        {
            return x + y;
        }

        int IY.Add(int x, int y)
        {
            return x + y + 1000;
        }

        int IY.Mult(int x, int y)
        {
            return x * y;
        }

        int IX.Sub(int x, int y)
        {
            return x - y;
        }
    }
}


/////
///﻿//namespace _10Demo_OOP_Interface
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            CMath cmath = new CMath();
//            Console.WriteLine($"Add= {cmath.Add(2, 3)}");
//            Console.WriteLine($"Sub= {cmath.Sub(2, 3)}");
//            Console.WriteLine($"Mult= {cmath.Mult(2, 3)}");

//            // Client 1: 
//            IX xObj = new CMath();
//            Console.WriteLine($"Add= {xObj.Add(2, 3)}");
//            Console.WriteLine($"Sub= {xObj.Sub(2, 3)}");

//            // Client 2: IY
//            IY yObj = new CMath();
//            Console.WriteLine($"Mult= {yObj.Mult(2, 3)}");

//        }
//    }
//    public interface IX
//    {
//        // method declarations: implementation force 
//        int Add(int x, int y);
//        int Sub(int x, int y);
//    }
//    public interface IY
//    {
//        int Mult(int x, int y);
//    }
//    // Implicit Way of Interface Implementation
//    public class CMath : IX, IY
//    {
//        public int Add(int x, int y)
//        {
//            return x + y;
//        }

//        public int Mult(int x, int y)
//        {
//            return x * y;
//        }

//        public int Sub(int x, int y)
//        {
//            return x - y;
//        }
//    }
//}