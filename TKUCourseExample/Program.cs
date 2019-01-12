using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NormalOrderExample
{
    class Program
    {
        static void Main(string[] args)
        {
            TKUCourse.CHT tku = new TKUCourse.CHT();//Chinese Server
            //TKUCourse.ENG tku = new TKUCourse.ENG();//English Server

            List<string[]> CourseCode = new List<string[]>();
            CourseCode.Add(new string[] { "0000", "1111","2222" });
            CourseCode.Add(new string[] { "3333" });
            CourseCode.Add(new string[] { "4444" });
            CourseCode.Add(new string[] { "5555", "6666" });
            CourseCode.Add(new string[] { "7777", "8888", "9999" });
            CourseCode.Add(new string[] { "1234", "2345", "3456" });
            // Input custom 2D Course Code Array Here

            List<bool[]> DropMode = new List<bool[]>();
            DropMode.Add(new bool[] { false, false, false });
            DropMode.Add(new bool[] { true });
            DropMode.Add(new bool[] { false });
            DropMode.Add(new bool[] { false, false });
            DropMode.Add(new bool[] { false, true, false });
            DropMode.Add(new bool[] { false, true, false });
            //Input custom 2D DropMode Array Here (If you need to drop course, set mapping course flag true.)


          
            while (tku.Login("student_id", "student_password") == false) Console.WriteLine("Attempt login...");// If success login, function will return true, else return false

            for (int i = 0; i < CourseCode.Count; i++) 
            {
                string[] s_array = CourseCode[i];
                for (int j=0;j<s_array.Length;j++)
                {
                    string s = s_array[j];
                    bool dropflag = DropMode[i][j];
                    if (dropflag)
                    {
                        tku.DropCourse(s);
                        Console.WriteLine("No. " + s + " Drop!!");
                    }
                    else
                    {
                        if (tku.AddCourse(s))//If add successfully, function will return true, else return false
                        {
                            Console.WriteLine("Add : " + s + " Successfully!!");
                            break;
                        }// Display successfully message 
                        else
                        {
                            Console.WriteLine("Add : " + s + " Failed!!");
                        }//display failed message
                    }
                }
            }

            Console.ReadKey();
            
        }
    }
}
