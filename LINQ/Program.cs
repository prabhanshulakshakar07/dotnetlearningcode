namespace LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5, };

            var result = numbers.Where(no => no > 3).FirstOrDefault();
            Console.WriteLine(result);

            for (int i = 0; i < numbers.Length; i++)
            {
                Func<int, bool> func1 = no => no == 3;
                func1(numbers[i]);
            }
            Func<int, bool> func = no => no == 3;
            IEnumerable<int> matchedNumber = numbers.Where(func);
           // where(numbers, Func<> del)



        }
    }
}
