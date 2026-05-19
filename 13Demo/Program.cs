using System.ComponentModel.DataAnnotations;

namespace _13Demo_OOP_Abstract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Parse --> Validate --> Save
            #region old 
            //PDF pdf = new PDF();
            //pdf.GenerateReport();
            ////pdf.Validate();
            ////pdf.Save();
            ////pdf.Parse(); 
            #endregion
            while (true)
            {
                Console.WriteLine("1. PDF, 2. CSV, 3. Word, 4. XML, 5. JSON");
                int reportchoice = Convert.ToInt32(Console.ReadLine());

                ReportFactory factory = new ReportFactory();
                Report report = factory.GetsomeReport(reportchoice);
                report.GenerateReport();

                Console.WriteLine("Do you want to continue? y/n: ");
                string ynch = Console.ReadLine().ToLower();
                if (ynch == "n")
                {
                    break;
                }
            }
        }
    }
    public abstract class Report
    {
        protected abstract void Parse();
        protected abstract void Validate();
        protected abstract void Save();
        public virtual void GenerateReport()
        {
            // Parse --> Validate --> Save
            Parse();
            Validate();
            Save();
            Console.WriteLine("Report generated successfully!");
        }
    }

    public abstract class SpecialReport : Report
    {
        protected abstract void Re_Validate();
        public override void GenerateReport()
        {
            // Parse --> Validate --> Re_Validate-->Save
            Parse();
            Validate();
            Re_Validate();
            Save();
            Console.WriteLine("Report generated successfully!");
        }
    }
    public class ReportFactory
    {
        public Report GetsomeReport(int ch)
        {
            Report reportObj = null;
            switch (ch)
            {
                case 1:
                    reportObj = new PDF();
                    break;
                case 2:
                    reportObj = new CSV();
                    break;
                case 3:
                    reportObj = new Word();
                    break;
                case 4:
                    reportObj = new XML();
                    break;
                case 5:
                    reportObj = new JSON();
                    break;
                default:
                    reportObj = null;
                    break;
            }
            return reportObj;
        }
    }
    public class PDF : Report
    {
        protected override void Parse()
        {
            // code here..
            Console.WriteLine("PDF Parsed");
        }
        protected override void Validate()
        {
            // code here..
            Console.WriteLine("PDF Validate");
        }
        protected override void Save()
        {
            // code here..
            Console.WriteLine("PDF Saved");
        }

    }
    public class CSV : Report
    {
        protected override void Parse()
        {
            // code here..
            Console.WriteLine("CSV Parsed");
        }
        protected override void Validate()
        {
            // code here..
            Console.WriteLine("CSV Validate");
        }
        protected override void Save()
        {
            // code here..
            Console.WriteLine("CSV Saved");
        }

    }

    public class Word : Report
    {
        protected override void Parse()
        {
            // code here..
            Console.WriteLine("Word Parsed");
        }
        protected override void Validate()
        {
            // code here..
            Console.WriteLine("Word Validate");
        }
        protected override void Save()
        {
            // code here..
            Console.WriteLine("Word Saved");
        }

    }

    public class XML : SpecialReport
    {
        //Only for XML Report = Parse ---> Validate---> Re_validate --> Save
        protected override void Parse()
        {
            // code here..
            Console.WriteLine("XML Parsed");
        }
        protected override void Validate()
        {
            // code here..
            Console.WriteLine("XML Validate");
        }
        protected override void Re_Validate()
        {
            // code here..
            Console.WriteLine("XML Re_Validate");
        }
        protected override void Save()
        {
            // code here..
            Console.WriteLine("XML Saved");
        }

    }
    public class JSON : SpecialReport
    {
        //Only for XML Report = Parse ---> Validate---> Re_validate --> Save
        protected override void Parse()
        {
            // code here..
            Console.WriteLine("JSON Parsed");
        }
        protected override void Validate()
        {
            // code here..
            Console.WriteLine("JSON Validate");
        }
        protected override void Re_Validate()
        {
            // code here..
            Console.WriteLine("JSON Re_Validate");
        }
        protected override void Save()
        {
            // code here..
            Console.WriteLine("JSON Saved");
        }

    }
}