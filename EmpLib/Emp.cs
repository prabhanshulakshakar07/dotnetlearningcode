using MyAttributeLib;

namespace EmpLib
{
    [Table(TableName = "Emp")]
    public class Employee
    {
        private int _EId;
        private string _EName;
        private string _EAddress;

        [Column(ColumnName = "Id", ColumnType = "int")]
        public int EId
        {
            get { return _EId; }
            set { _EId = value; }
        }

        [Column(ColumnName = "Name", ColumnType = "varchar(50)")]
        public string EName
        {
            get { return _EName; }
            set { _EName = value; }
        }

        [Column(ColumnName = "Address", ColumnType = "varchar(50)")]
        public string Address
        {
            get { return _EAddress; }
            set { _EAddress = value; }
        }
    }
}