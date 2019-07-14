using System;
 
namespace TutorialsPointCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            HelperClasses.DataTypesClass.printDataTypes();


            //dynamic x, y, z;
            int x = 3;
            Double y = 15.99;

            dynamic z = y / x;

            Console.WriteLine(x.GetType());
            Console.WriteLine(y.GetType());
            Console.WriteLine(z.GetType());
            Console.ReadLine();
        }
    }
}
