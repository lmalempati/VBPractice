using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using VBPractice;

namespace ReflectionExample
{


public class FieldInfoClass
    {
        public int myField1 = 0;
        protected string myField2 = null;
        public int MyProperty { get; set; }
        public static void Main()
        {
            GetClassInfo_Reflection(new FieldInfoClass());
        }

        private static void GetClassInfo_Reflection(Object param)
        {
            FieldInfo[] myFieldInfo;
            PropertyInfo[] myPropertyInfo;
            //Type myType = typeof(Employee);
            Type myType = param.GetType();
            // Get the type and fields of FieldInfoClass.
            myFieldInfo = myType.GetFields(BindingFlags.NonPublic | BindingFlags.Instance
                | BindingFlags.Public);
            Console.WriteLine("\nThe fields of " +
                "FieldInfoClass are \n");
            // Display the field information of FieldInfoClass.
            for (int i = 0; i < myFieldInfo.Length; i++)
            {
                Console.WriteLine("\nName            : {0}", myFieldInfo[i].Name);
                Console.WriteLine("Declaring Type  : {0}", myFieldInfo[i].DeclaringType);
                Console.WriteLine("IsPublic        : {0}", myFieldInfo[i].IsPublic);
                Console.WriteLine("MemberType      : {0}", myFieldInfo[i].MemberType);
                Console.WriteLine("FieldType       : {0}", myFieldInfo[i].FieldType);
                Console.WriteLine("IsFamily        : {0}", myFieldInfo[i].IsFamily);
                //Console.ReadLine();
            }
            myPropertyInfo = myType.GetProperties(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);

            for (int i = 0; i < myPropertyInfo.Length; i++)
            {
                Console.WriteLine("\nProperty Name            : {0}", myPropertyInfo[i].Name);
                Console.WriteLine("Declaring Type  : {0}", myPropertyInfo[i].DeclaringType);
                //Console.WriteLine("IsPublic        : {0}", myPropertyInfo[i].ispublic);
                Console.WriteLine("MemberType      : {0}", myPropertyInfo[i].MemberType);
                Console.WriteLine("PropertyType       : {0}", myPropertyInfo[i].PropertyType);
                Console.ReadLine();
            }
        }
    }
}
