﻿using System;
 
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
            Console.WriteLine("This change is from within github (online)");
        }
     
        static void myNewGithubFunction(){
          // ... new function added in github (online)
           Console.WriteLine("this is a comment from Visual Studio!");
        }

        static void newTestFunctionNovember()
        {
            // New function added 2019-11-10
        }

        static void TEST_FUNCTION_XX()
        {
            //...
        }
    }
}
