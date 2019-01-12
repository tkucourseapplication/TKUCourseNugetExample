using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopOrderExample
{
    class Program
    {
        static void Main(string[] args)
        {
            TKUCourse.CHT tku = new TKUCourse.CHT();//Chinese Server
            //TKUCourse.ENG tku = new TKUCourse.ENG();//English Server

            string[] CourseCode = { "1234", "2345", "3456" };// Input custom Course Code Array Here


            while (true)
            {
                while (tku.Login("student_id", "student_password") == false) ;// If success login, function will return true, else return false

                foreach(string s in CourseCode)
                {
                    if (tku.AddCourse(s))//If add successfully, function will return true, else return false
                    {
                        Console.WriteLine("Add : " + s + " Successfully!!");
                        Console.ReadKey();
                        return;
                    }// Display successfully message and exit the program
                }
            }
        }
    }
}
