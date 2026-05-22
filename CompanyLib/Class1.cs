using System;

namespace CompanyLib
{
    // Company is a custom attribute
    [AttributeUsage(AttributeTargets.Class)]
    public class Company : Attribute
    {
        private string _CompanyName;

        private string _DeveloperNAme;

        public string DeveloperName
        {
            get { return _DeveloperNAme; }
            set { _DeveloperNAme = value; }
        }
        public string CompanyName
        {
            get { return _CompanyName; }
            set { _CompanyName = value; }
        }

    }
}
