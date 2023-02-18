using StudentMarkSheet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Marksheet1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("********** WELCOME TO THE STUDENT MARKSHEET GENERATOR **********");
            Console.WriteLine("\nKindly Provide us the below mentioned details to generate your marksheet");
            Functions Student1 = new Functions();

            Student1.StudentCreation();

            Student1.Write();

            Console.WriteLine("-----------------------------------------------------------------------------------");
            Console.WriteLine("\n");
            Student1.ReadData();

            Console.WriteLine("\n-----------------------------------------------------------------------------------");

            Console.ReadLine();
        }
    }
}