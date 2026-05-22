using MyAttributeLib;
using System.Reflection;
using System.Runtime.InteropServices.Marshalling;

namespace MyORMDemo30
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\Prabhanshu\source\repos\Csharpdemos\EmpLib\bin\Debug\net10.0\EmpLib.dll";

            Assembly asm = Assembly.LoadFrom(path);

            Type[] allTypes = asm.GetTypes();

            for (int i = 0; i < allTypes.Length; i++)
            {
                Type type = allTypes[i];
                string createTableQuery = "CREATE TABLE ";

                Attribute[] attr = type.GetCustomAttributes().ToArray();

                for (int j = 0; j < attr.Length; j++)
                {
                    Attribute attr2 = attr[j];
                    if (attr2 is Table)
                    {
                        Table table = attr2 as Table;
                        // "CREATE TABLE Emp ("
                        createTableQuery = createTableQuery + table.TableName + "(";
                    }
                }

                PropertyInfo[] allProps = type.GetProperties();
                for (int j = 0; j < allProps.Length; j++)
                {
                    PropertyInfo prop = allProps[j];
                    Attribute[] propAttr = prop.GetCustomAttributes().ToArray();
                    for (int k = 0; k < propAttr.Length; k++)
                    {
                        Attribute pattr = propAttr[k];
                        if (pattr is Column)
                        {
                            Column col = pattr as Column;
                            // "CREATE TABLE Emp ( Id int, Name varchar(50), Address varchar(50),"
                            createTableQuery = createTableQuery + " " + col.ColumnName + " " + col.ColumnType + ",";
                        }
                    }
                }

                createTableQuery = createTableQuery.TrimEnd(',') + ");";
                Console.WriteLine(createTableQuery);
                File.WriteAllText(@"C:\Users\Prabhanshu\source\repos\Csharpdemos\MyORMDemo30\Data\myquery.sql", createTableQuery);
                Console.WriteLine("Done");
            }
        }
    }
}
