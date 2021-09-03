using System;

namespace day3
{
    class Hclinfosystem
    {
        public static void Main()
        {
            object x="rahul";// x is a variable of object type
            string y =(string)x;// at this point conversion takes placeat this time we explicitly convert into string
            Console.WriteLine(y);


            //using dynamic
             dynamic x1="rahul";// x is a variable of object type
            string y1=x1;
            Console.WriteLine(y1);


            //using var
            var x2="Rahul";
            Console.WriteLine(x2);
        }
            
            
        }
        
    }
           
        

 
