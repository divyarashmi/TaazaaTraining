using System;

namespace OptionalPara
{
    class Program
    {
       public static void Name_add(string str1,string str2="Divya");
       {
           
           Console.WriteLine(str1+str2);
       }
       public static void Main()
       {
           Name_add("Divya");
           Name_add("Rashmi","Geetika")
       }
    }
}
