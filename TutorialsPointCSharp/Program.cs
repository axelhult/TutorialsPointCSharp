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
            Console.WriteLine("This change is from within Visual studio (online)");
        }
     
        static void myNewGithubFunction(){
          // ... new function added in github (online)
           Console.WriteLine("this is a comment from Visual Studio!");
        }
    }
}
