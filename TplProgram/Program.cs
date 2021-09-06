using System;
using System.Threading;
using System.Threading.Tasks;
namespace TplProgram
{ 
    class Myapp
    {
        
        public static void longTask()
        {
            Thread.Sleep(10000);//10sec

            
        }
        public static async void myTask()
        {
            //Task task=new Task(new Action(longTask));
            await Task.Run(new Action(longTask));// new thread generate
            Console.WriteLine("New Thread is generated");
           // task.Start();
          
        }
        public static void Main()
        {
           myTask();
           Console.WriteLine("I am main");
           Console.ReadLine();
        }
    }
}
