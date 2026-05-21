namespace MultiDelegate_Demo
{
    public delegate void AnnualFuncDelegate();
    internal class Program
    {
        static void Main(string[] args)
        {

            AnnualEvent obj = new AnnualEvent();








            // Multi-cast Delegate
            AnnualFuncDelegate funcDel = new AnnualFuncDelegate(obj.Welcome);
            funcDel += obj.Speech;

            Console.WriteLine("Is Guest arrived?");
            string isArrived = Console.ReadLine();
            if (isArrived == "y")
            {
                // += coupling operator
                funcDel += obj.GuestSpeech;
            }
            else

            {
                // De- coupling operator
                funcDel -= obj.GuestSpeech;
            }
            funcDel += obj.Dance;
            funcDel += obj.Dinner;
            funcDel += obj.GoodBye;
            funcDel += obj.PackUp;

            funcDel();

            //AnnualFuncDelegate funcDel2 = obj.Speech;
        }
    }














    public class AnnualEvent
    {
        public void Welcome()
        {
            Console.WriteLine("Wel-come all!");
        }

        public void Speech()
        {
            Console.WriteLine("Co-ordinator: Blah Blah Balh");
        }

        public void GuestSpeech()
        {
            Console.WriteLine("Guest: Blah Blah Balh Blah Blah");
        }

        public void Dance()
        {
            Console.WriteLine("Zingat....");
        }

        public void Dinner()
        {
            Console.WriteLine("Enjoy your food..");
        }

        public void GoodBye()
        {
            Console.WriteLine("Ghar jao bhai!!!");
        }

        public void PackUp()
        {
            Console.WriteLine("finally !! Pack up!!!");
        }











    }
}