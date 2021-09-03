using System;
using System.Threading;
namespace ThreadingProgram
{
    public class MyWork
    {
        public void work1()
        {
            Thread.Sleep(7000);// This function will take 7seconds to perform the task 

            Console.WriteLine("i am doing for work1");

        }
        public void work2()
        {
            Console.WriteLine("i am doing for work2");

        }
        public static void Main()// Main is a thread. Thread means it provides the execution to program.or we can say thread is a execution model of the program.
        {
            MyWork myWork = new MyWork();
            myWork.work1();//At this point we invoking the first function is called work1.
            myWork.work2();//At this point we invoking the second function is called work2.
        }
    }
    
}
