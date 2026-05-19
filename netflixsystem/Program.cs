using System;
using System.Collections.Generic;

namespace NetflixFactoryPattern
{
    // ========================================================
    // 1. THE PRODUCT (Interface and Concrete Implementations)
    // ========================================================
    public interface INetflixDashboard
    {
        void ShowContent();
    }

    // Concrete Product A: For Free/Mobile Users
    public class FreeDashboard : INetflixDashboard
    {
        public void ShowContent()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n--- NETFLIX MOBILE / FREE PLAN ---");
            Console.WriteLine("Displaying 3 Standard Movies (Contains Ads):");

            var freeMovies = new List<string> { "Spiderman 1", "Kung Fu Panda", "Inception" };
            foreach (var movie in freeMovies)
            {
                Console.WriteLine($" -> {movie}");
            }

            Console.WriteLine("\n💡 Upgrade to Premium to unlock unlimited 4K content!");
            Console.ResetColor();
        }
    }

    // Concrete Product B: For Premium Users
    public class PremiumDashboard : INetflixDashboard
    {
        public void ShowContent()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n--- NETFLIX PREMIUM 4K PLAN ---");
            Console.WriteLine("🚀 Unlimited Movies & Exclusive Web Series (No Ads):");

            var premiumContent = new List<string> {
                "Stranger Things S5", "Sacred Games", "The Dark Knight",
                "Interstellar", "Breaking Bad", "Money Heist", "Narcos"
            };
            foreach (var show in premiumContent)
            {
                Console.WriteLine($" [⭐ Premium] -> {show}");
            }
            Console.ResetColor();
        }
    }

    // ========================================================
    // 2. THE CREATOR (Abstract Factory Class & Subclasses)
    // ========================================================
    public abstract class NetflixApp
    {
        // This is the actual Factory Method
        public abstract INetflixDashboard CreateDashboard();

        // High-level business logic that uses the product
        public void RenderHomePage()
        {
            INetflixDashboard dashboard = CreateDashboard();
            dashboard.ShowContent();
        }
    }

    // Concrete Creator A
    public class MobileUserApp : NetflixApp
    {
        public override INetflixDashboard CreateDashboard() => new FreeDashboard();
    }

    // Concrete Creator B
    public class PremiumUserApp : NetflixApp
    {
        public override INetflixDashboard CreateDashboard() => new PremiumDashboard();
    }

    // ========================================================
    // 3. MAIN MENU-DRIVEN PROGRAM Execution
    // ========================================================
    class Program
    {
        static void Main(string[] args)
        {
            NetflixApp appFactory = null;
            bool keepRunning = true;

            Console.WriteLine("======================================");
            Console.WriteLine("     WELCOME TO NETFLIX ENTERPRISE    ");
            Console.WriteLine("======================================");

            while (keepRunning)
            {
                Console.WriteLine("\n------- USER LOGIN MENU -------");
                Console.WriteLine("1. Login as Free/Mobile User");
                Console.WriteLine("2. Login as Premium User");
                Console.WriteLine("3. Exit Application");
                Console.Write("Enter your choice (1-3): ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        // Factory Method Magic: Instantiating the Free Factory at runtime
                        appFactory = new MobileUserApp();
                        appFactory.RenderHomePage();
                        break;

                    case "2":
                        // Factory Method Magic: Instantiating the Premium Factory at runtime
                        appFactory = new PremiumUserApp();
                        appFactory.RenderHomePage();
                        break;

                    case "3":
                        Console.WriteLine("\nClosing Netflix. Thank you for using our app! 👋");
                        keepRunning = false;
                        break;

                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("⚠️ Invalid Choice! Please press 1, 2, or 3.");
                        Console.ResetColor();
                        break;
                }

                if (keepRunning)
                {
                    Console.WriteLine("\n--------------------------------------");
                    Console.WriteLine("Press any key to return to the Menu...");
                    Console.ReadKey();
                    Console.Clear(); // Clears the screen for a clean UI on the next loop
                }
            }
        }
    }
}