using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ParallelOrderExample
{
    class Program
    {
        static TKUCourse.CHT tku = new TKUCourse.CHT();//Chinese Server
        //TKUCourse.ENG tku = new TKUCourse.ENG();//English Server

        static Semaphore sem;

        static void Main(string[] args)
        {
            

            string[] CourseCode = { "1234", "2345", "3456" };// Input custom Course Code Array Here

            Thread[] parallel = new Thread[CourseCode.Length];
            sem = new Semaphore(0, CourseCode.Length);

            for(int i = 0; i < CourseCode.Length; i++)
            {
                parallel[i] = new Thread(() => ParallelOrder(CourseCode[i]));
            }


            while (tku.Login("student_id", "student_password") == false) ;// If success login, function will return true, else return false

            foreach(Thread t in parallel)
            {
                t.Start();
            }// start order in parallel
            
            for(int i = 0; i < CourseCode.Length; i++)
            {
                sem.WaitOne();
            }

            Console.ReadKey();
            
        }

        static void ParallelOrder(string code)
        {
            if (tku.AddCourse(code))//If add successfully, function will return true, else return false
            {
                Console.WriteLine("Add : " + code + " Successfully!!");
            }// Display successfully message 
            else
            {
                Console.WriteLine("Add : " + code + " Failed!!");
            }// Display failed message
            sem.Release(1);
        }
    }
}
