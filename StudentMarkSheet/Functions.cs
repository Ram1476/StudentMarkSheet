using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentMarkSheet
{
    internal class Functions
    {
        public int rollNum, maths, science,english,total;
        public float percentage;
        public string name;
        public string grade;
        public string path = @"D:\C#\Student.txt";
        public void StudentCreation() 
        {
            Console.WriteLine("\nEnter Roll Number :");
            rollNum = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nEnter Student Name :");
            name = Console.ReadLine();
            Console.Write("\nMark obtained in Maths : ");
            maths = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nMark obtained in Science : ");
            science = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nMark obtained in English : ");
            english = Convert.ToInt32(Console.ReadLine());
        }
        public int TotalCalculation() 
        {
            total = maths + science + english;
            return total;
        }
        public float PercentageCalculation() 
        {
           
            percentage = total / 3.0f;
            return percentage;

        }

        public string GradeCalculation() 
        {
            
            if (percentage >= 35 && percentage < 50)
            {
                grade = "C";
            }
            else if (percentage >= 50 && percentage <= 60)
            {
                grade = "B";
            }
            else if (percentage > 60 && percentage <= 80)
            {
                grade = "A";
            }
            else if (percentage > 80 && percentage <= 100)
            {
                grade = "A++";
            }
            else 
            {
                grade = "F";
            }
            return grade;
        }

        public void Write() 
        {
            FileStream fs = new FileStream(path,FileMode.Append,FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            FileInfo len = new FileInfo(path);
            if (len.Length == 0)
            {
                string firstLine = "Student-Roll-Num" + " | " + "Student-Name" + " | " + "Maths Mark(100)" + " | " +"Science Mark"
                    + " | " + "English Mark" + " | " + "Total-Mark" + " | " + "Percentage" + " | " + "Grade";
                string details = "\n"+rollNum.ToString() + " | " + name + " | " + maths.ToString() + " | " + science.ToString() + " | " + english.ToString() 
                    + " | " + TotalCalculation().ToString() + " | " + PercentageCalculation().ToString() + " | " + GradeCalculation();
                sw.WriteLine(firstLine);
                sw.WriteLine(details); 
                sw.Close();
                fs.Close();
            }
            else 
            {
                string details = "\n"+rollNum.ToString() + " | " + name + " | " + maths.ToString() + " | " + science.ToString() + " | " + english.ToString()
                    + " | " + TotalCalculation().ToString() + " | " + PercentageCalculation().ToString() + " | " + GradeCalculation();
                sw.WriteLine(details);
                sw.Close();
                fs.Close();
            }
        }

        public void ReadData() 
        {
            //StreamReader read = new StreamReader(path);
            //string save = " ";
            //while (save != null ) 
            //{
            //    save = read.ReadLine();
            //    Console.WriteLine(save);
            //}

            string[] lines = File.ReadAllLines(path);
            foreach (string line in lines) 
            {
                Console.WriteLine(line);
            }
        }
    }
}
