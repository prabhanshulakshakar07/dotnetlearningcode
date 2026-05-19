namespace _08Demo_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Emp emp = new Emp();
            //emp.EId = 22;
            ////emp.set_EId(1);
            //Console.WriteLine(emp.EId);
            ////Console.WriteLine(emp.get_EId());
            //emp.Name = "Hugh Jackman";
            //string nm = emp.Name;
            //Console.WriteLine(nm);
            //Console.WriteLine(string.Format("Id : {0}, Name: {1}",emp.EId,emp.Name));
        }
    }

    public class Emp
    {
        // Fields
        private int _EId; // pvt member
        private string _EName;
        private bool _isActive;
        private MyClass _obj;
        private int[] _numbers;

        // Properties
        public int[] numbs
        {
            set { _numbers = value; }
            get { return _numbers; }
        }
        public MyClass myclassObj
        {
            set { _obj = value; }
            get { return _obj; }
        }
        public bool isActive
        {
            set { _isActive = value; }
            get { return _isActive; }
        }
        public string Name
        {
            set { _EName = value; }
            get { return _EName; }
        }

        public int EId // Property
        {
            set
            {
                if (value == 5)
                    _EId = value;
                else
                    _EId = 0;
            }
            //get 
            //{
            //    return _EId;
            //}
        }
        // Property Syntax:
        // accessModifier DataType PropertyName
        // {
        // set{
        //      pvt fieldname =  value;
        //    }

        // get{
        //      return pvt fieldname;
        //    }
        // }

        #region java like getter setter code demo 
        //public void set_EId(int id) 
        //{
        //    if(id == 5)
        //        this._EId = id;
        //    else
        //        this._EId = 0;
        //}
        //public int get_EId()
        //{
        //    return this._EId;
        //} 
        #endregion
    }

    public class MyClass
    {

    }
}