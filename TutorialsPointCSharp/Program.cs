using System;
 
namespace TutorialsPointCSharp
{
    class Program
    {
        

        static void Main(string[] args)
        {
             double myDouble = 55.55;

            HelperClasses.DataTypesClass.printDataTypes();


            Console.WriteLine("hello there!");
            Console.ReadLine();
        }

        static void newFunction()
        {
            Console.WriteLine("This is a function... modified in master branch in github!");
        }
    }
}
