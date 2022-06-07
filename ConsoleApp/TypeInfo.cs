using System.Reflection;

namespace ConsoleApp
{
    public class Reflection
    {
        public static void TypeInfo<T>(T obj) where T : class
        {
            Type t = typeof(T);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\n\nType: {0}", t);
            Console.ForegroundColor = ConsoleColor.White;

            ConstructorInfo[] constructorsInfo = t.GetConstructors();
            Console.WriteLine("Constructors:");
            foreach (ConstructorInfo constructorInfo in constructorsInfo) Console.WriteLine("\t{0}", constructorInfo.Name);

            MethodInfo[] methodsInfo = t.GetMethods();
            Console.WriteLine("Methods:");
            foreach (MethodInfo methodInfo in methodsInfo) Console.WriteLine("\t{0}", methodInfo.Name);


            FieldInfo[] fieldsInfo = t.GetFields();
            Console.WriteLine("Fields: ");
            foreach (FieldInfo fieldInfo in fieldsInfo) Console.WriteLine("\t{0}", fieldInfo.Name);
        }
    }
}
