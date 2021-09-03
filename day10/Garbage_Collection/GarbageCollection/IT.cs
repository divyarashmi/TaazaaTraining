using System;
namespace Garbage_Collection.GarbageCollection
{
    public class IT:IDisposable
    {
       public void databaseCollect() // to connect to databse we need so many resourrces
       {
          Console.WriteLine("let me a write a code to connect to database");
       }

        public void Dispose()
        {
             Console.WriteLine("Destructor is working now!!");
        }

       // ~ IT() //finalize act as a destructor
      // {
         //  Console.WriteLine("Destructor is working now!!");
       //}
    }
}