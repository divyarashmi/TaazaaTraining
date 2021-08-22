using System;
using System.Collections.Generic;

namespace SwitchExample
{
    class Program
    {
        public static void Main()
        {
        List<string> obj=new List<string>();
        for(int i=0;i<3;i++)
        {
           switch(i)
           {
               case 1:
               obj.Add("Geetika");
               obj.Add("Dibu");
               System.Console.WriteLine("Name added");
               break;
               case 2:
               if(obj.Contains("Dibu"))
               {
               Console.WriteLine("Found");
               }
               else
               {
               Console.WriteLine("Not Found");
               }
               break;
           }
        }
       
        }
    }
}
