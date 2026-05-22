using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace BinarySerializationDemo26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"C:\Users\Prabhanshu\source\repos\Csharpdemos\FileIODemo25\Data\data.txt";

            Emp emp = new Emp();
            emp.EId = 1;
            emp.EName = "Hugh Jackman";
            emp.Address = "NYC";

            FileStream fs = null;

            #region Serialize
            if (File.Exists(filePath))
            {
                fs = new FileStream(filePath, FileMode.Append, FileAccess.Write);
            }
            else
            {
                fs = new FileStream(filePath, FileMode.Create, FileAccess.Write);
            }


            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs, emp);
            fs.Close();
            Console.WriteLine("Done");
            #endregion

            //if (File.Exists(filePath))
            //{
            //    fs = new FileStream(filePath, FileMode.Open, FileAccess.Read);
            //}
            //else
            //{
            //    Console.WriteLine("File does not exsist");
            //}

            //BinaryFormatter bf = new BinaryFormatter();
            //Emp obj = bf.Deserialize(fs) as Emp;
            //Console.WriteLine($"{obj.EId}, {obj.EName}, {obj.Address}");
        }
    }

    [Serializable] // Attribute
    public class Emp
    {
        private int _EId;
        private string _EName;

        [NonSerialized]
        private string _EAddress;


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