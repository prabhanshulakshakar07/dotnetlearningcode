using System.Text.Json;
using System.Xml.Linq;
using System.Xml.Serialization;


namespace SerializationDemo27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Emp emp = new Emp();
            emp.EId = 1;
            emp.EName = "Hugh Jackman";
            emp.Address = "NYC";
            // XML Serialization

            string filepath = @"C:\Users\Prabhanshu\source\repos\Csharpdemos\FileIODemo25\Data\empdata.xml";

            string filepath2 = @"C:\Users\Prabhanshu\source\repos\Csharpdemos\FileIODemo25\Data\empdata.json";

            FileStream fs = null;

            #region xml Serialize
            //if (File.Exists(filepath))
            //{
            //    fs = new FileStream(filepath, FileMode.Append, FileAccess.Write);
            //}
            //else
            //{
            //    fs = new FileStream(filepath, FileMode.Create, FileAccess.Write);
            //}

            //XmlSerializer xs = new XmlSerializer(typeof(Emp));
            //xs.Serialize(fs, emp);
            //fs.Close();
            //Console.WriteLine("Done");
            #endregion

            #region xml Deserialize
            //if (File.Exists(filepath))
            //{
            //    fs = new FileStream(filepath, FileMode.Open, FileAccess.Read);
            //}
            //else
            //{
            //    Console.WriteLine("File does not exist");
            //}

            //XmlSerializer xs = new XmlSerializer(typeof(Emp));
            //Emp emp1 = xs.Deserialize(fs) as Emp;
            //fs.Close();
            //Console.WriteLine($"{emp1.EId}, {emp1.EName}, {emp1.Address}"); 
            #endregion


            #region JSON Serialization
            if (File.Exists(filepath))
            {
                fs = new FileStream(filepath2, FileMode.Append, FileAccess.Write);
            }
            else
            {
                fs = new FileStream(filepath2, FileMode.Create, FileAccess.Write);
            }

            JsonSerializer.Serialize<Emp>(fs, emp);

            fs.Close();
            Console.WriteLine("Done");
            #endregion

            #region JSON Deserialize
            //if (File.Exists(filepath))
            //{
            //    fs = new FileStream(filepath2, FileMode.Open, FileAccess.Read);
            //}
            //else
            //{
            //    Console.WriteLine("File does not exist");
            //}

            //Emp emp2 = JsonSerializer.Deserialize<Emp>(fs) as Emp;
            //fs.Close();
            //Console.WriteLine($"{emp2.EId}, {emp2.EName}, {emp2.Address}");
            #endregion
        }
    }
    public class Emp
    {
        private int _EId;
        private string _EName;
        private string _EAddress;

        //[XmlIgnore]
        public string Address
        {
            get { return _EAddress; }
            set { _EAddress = value; }
        }

        public string EName
        {
            get { return _EName; }
            set { _EName = value; }
        }

        public int EId
        {
            get { return _EId; }
            set { _EId = value; }
        }

    }
}