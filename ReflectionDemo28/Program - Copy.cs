//using System.Reflection;

//namespace ReflectionDemo28
//{


//     /// <summary>
//     ///  int Add ( int x , int y)
//     ///  
//     /// </summary>


//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            string asseblyPath = @"C:\Users\Prabhanshu\source\repos\Csharpdemos\MyMathLib\bin\Debug\net10.0\MyMathLib.dll";

//           Assembly asm = Assembly.LoadFrom(asseblyPath);
//           Type[] allTypes = asm.GetTypes();


//            for (int i = 0; i < allTypes.Length; i++) { 
//            Type type = allTypes[i]; // MyMathLib.CMath

            

//                //Console.WriteLine(type.FullName);
//                //Console.WriteLine(type.Name);


//               MethodInfo [] allmethods =type.GetMethods(); // get all methods of CMath class
//                //add,sub 
//                for ( int j =0; j < allmethods.Length; j++)
//                {
//                    string methodSignature = "";
//                    MethodInfo method = allmethods[j];

//                    //system.Int32 Add(
//                    methodSignature =methodSignature + method.ReturnType +" "+method.Name+ "( ";

//                    //Console.WriteLine(method.Name);

//                    //Console.WriteLine(method.ReturnParameter.ParameterType.ToString());
//                   ParameterInfo[] allParameters= method.GetParameters();


//                    for ( int k = 0; k < allParameters.Length; k++)
//                    {
//                        ParameterInfo para = allParameters[k];

//                        //Sytem.Int32 Add( System.Int32 x, System.Int32 y,

//                        methodSignature = methodSignature + para.ParameterType + " " + para.Name+",";




//                    }

                    



//  methodSignature = methodSignature.TrimEnd(',') + " )";
//                Console.WriteLine(methodSignature);


//                }
              

//            }
           


//        }
//    }
//}
