using System;
using System.Collections;

namespace HashtableProgram
{
    class Program
    {
        static void Main(string[] args) {
         Hashtable ht = new Hashtable();
         
         ht.Add("001", "Divya");
         ht.Add("002", "Deepak");
         ht.Add("003", "Yamini");
         
         
         if (ht.ContainsValue("Yamini")) {
            Console.WriteLine("This student name is already in the list");
         } else {
            ht.Add("004", "Geetika");
         }
         
         // Get a collection of the keys.
         ICollection key = ht.Keys;
         
         foreach (string k in key) {
            Console.WriteLine(k + ": " + ht[k]);
         }
         Console.ReadKey();
      }
    }
}
