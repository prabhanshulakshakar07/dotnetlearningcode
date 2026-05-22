using System.Reflection;

namespace ReflectionDemo28
{


     /// <summary>
     ///  int Add ( int x , int y)
     ///  
     /// </summary>


    internal class Program
    {
        static void Main(string[] args)
        {
            string asseblyPath = @"C:\Users\Prabhanshu\source\repos\Csharpdemos\MyMathLib\bin\Debug\net10.0\MyMathLib.dll";

            Assembly asm = Assembly.LoadFrom(asseblyPath);

            Type[] allTypes = asm.GetTypes();

            for (int i = 0; i < allTypes.Length; i++)
            {
                Type type = allTypes[i];

                object dynmicallycreatedobject = asm.CreateInstance(type.FullName);

                MethodInfo[] allMethods = type.GetMethods();

                for (int j = 0; j < allMethods.Length; j++)
                {
                    string methodSignature = "";

                    MethodInfo method = allMethods[j];
                    methodSignature = methodSignature + method.ReturnType
                                    + " " + method.Name + "( ";

                    ParameterInfo[] allParameters = method.GetParameters();

                    for (int k = 0; k < allParameters.Length; k++)
                    {
                        ParameterInfo para = allParameters[k];

                        // System.Int32 Add( System.Int32 x, System.Int32 y,
                        methodSignature = methodSignature + para.ParameterType.ToString() + " " +
                            para.Name + ",";
                    }

                    object[] inputValues = new object[allParameters.Length];

                    for (int v = 0; v < inputValues.Length; v++)
                    {
                        ParameterInfo currentParameter = allParameters[v];
                        Console.WriteLine($"Enter value for {currentParameter.Name} of type = {currentParameter.ParameterType.ToString()}");
                        inputValues[v] = Convert.ChangeType(Console.ReadLine(), currentParameter.ParameterType);
                    }

                    // System.Int32 Add(System.Int32 x, System.Int32 y)
                    methodSignature = methodSignature.TrimEnd(',') + ")";
                    Console.WriteLine(methodSignature);

                    object? result = type.InvokeMember(
                        method.Name,
                        BindingFlags.Public |
                        BindingFlags.Instance |
                        BindingFlags.InvokeMethod,
                        null,
                        dynmicallycreatedobject,
                        inputValues
                        //new object[] {10,20 }
                        );

                    Console.WriteLine($"{result}");
                }

            }
        }
    }
}
