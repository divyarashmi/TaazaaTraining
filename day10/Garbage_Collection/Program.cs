//difference between finalise and dispose
using System;
using Garbage_Collection.GarbageCollection;

namespace Garbage_Collection
{
    class Program
    {
        public static void Main()
        {// we are defining scope of an object using block. Achieves explicit garbage collection. 
           using (IT iT= new IT())
           {
             iT.databaseCollect();//now the function is called,got the value still resources running so why not cleanup the resource just after consuming
                                  // this is where the garbage collection comes into picture  
           }//At this point Dispose Function will be called Explicitly


           
                                
            Console.WriteLine("End of the Program");                     
        }
    }
}
