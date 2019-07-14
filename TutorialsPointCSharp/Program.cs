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
            Console.WriteLine("This is a function!");
        }
     
        static void myNewGithubFunction(){
          // ... new function added in github (online)
           Console.WriteLine("hello github commit!");
        }
    }
}
