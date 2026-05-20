namespace EventsDelegate_Demo19
{

    public delegate void pointHandler(int mrk);
    internal class Program
    {
        static void Main(string[] args)
        {
          


            Team team = new Team();

            //+= coupling operator

            team._playoffpass += team.playoffpass;
            team._playofffail += team.playofffail;

            Console.WriteLine("Enter the points of team");
            team.points = Convert.ToInt32(Console.ReadLine());











        }
    }






    public class Team
    {

        public event pointHandler _playoffpass;

        public event pointHandler _playofffail;

        private int _points;
        public int points
        {
            set
            {
                _points = value;
                if (_points >= 14)
                {
                    _playoffpass?.Invoke(_points);
                }
                else
                {
                    _playofffail?.Invoke(_points);
                }


            }


            get { return _points; }



        }
       

























        public void playoffpass(int points)
        {
            Console.WriteLine($"Congratulation!! You have Qualify for playoff with {points}");
        }
        public void playofffail(int points)
        {
            Console.WriteLine($"Congratulation!! You have un qualify for playoff with  {points}");
        }






    }



    }
