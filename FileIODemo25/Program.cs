namespace FileIODemo25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"C:\Users\Prabhanshu\source\repos\Csharpdemos\FileIODemo25\Data\empdata.txt";

            FileStream fs = null;

            if (File.Exists(filePath))
            {
                fs = new FileStream(filePath, FileMode.Append, FileAccess.Write);
            }
            else
            {
                fs = new FileStream(filePath, FileMode.Create, FileAccess.Write);
            }

            StreamWriter write = new StreamWriter(fs);
            write.WriteLine("Blah Blah Blah Blah");
            fs.Flush();
            write.Close();
            fs.Close();
            Console.WriteLine("Done");

            

            #region StreamReader
            //if (File.Exists(filePath))
            //{
            //    fs = new FileStream(filePath, FileMode.Open, FileAccess.Read);
            //}
            //StreamReader reader = new StreamReader(fs);
            //string data = reader.ReadToEnd();
            //Console.WriteLine(data);
            //reader.Close();
            //fs.Close();
            #endregion

            if (File.Exists(filePath))
            {
                fs = new FileStream(filePath, FileMode.Append, FileAccess.Write);
            }
            else
            {
                fs = new FileStream(filePath, FileMode.Create, FileAccess.Write);
            }

            Emp emp = new Emp();
            emp.EId = 1;
            emp.EName = "Hugh Jackman";
            emp.Address = "NYC";

            StreamWriter write = new StreamWriter(fs);
            write.WriteLine(emp);

            fs.Flush();
            write.Close();
            fs.Close();
            Console.WriteLine("Done");
        }
    }
    public class Emp
    {
        private int _EId;
        private string _EName;
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