using _04Demo.two; // using statements resolves namespace at the time of compilation
namespace _04Demo
{
    // namespace are logical grouping of .Net types
    namespace two
    {
        //_04Demo.two.Week
        public enum Week { Mon, Tue, Wed }
    }
    internal class Program
    {
        string name = "Hugh JAckman";
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine(Week.Mon);
            Console.WriteLine(Week.Tue);

        }
    }
}