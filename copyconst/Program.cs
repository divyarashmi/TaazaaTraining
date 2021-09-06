using System;

namespace copyconst
{
    class Person
    {
        public String Resume{get;set;}
        public Person(String rm)
        {
            Resume = rm;
        }
        public Person()
        {

        }
    }
    class rnd1
    {
        static void Main()
        {
            Person Divya = new Person ("My Resume is prepared");
            Person Dibu = new Person();
            Console.WriteLine(Dibu.Resume+" "+ Divya.Resume);
            Console.ReadLine();
            Dibu=Divya;
            Console.WriteLine(Dibu.Resume);
            Dibu.Resume="Show 1 months of experience";
            Console.WriteLine(Divya.Resume);
            Console.ReadLine();
            
        }
    }


}
