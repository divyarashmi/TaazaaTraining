using System;

namespace SpecialTopic
{
    class Program
    {
        public static int Add(params int[] M)
        {
            int sum =0;
            foreach(int x in M)
            {
                sum=sum+x;
                
            }
            return sum;
        }
        static void Main(string[] args)
        {
            int y=Add(5,6,7,8);
            Console.WriteLine(y);
        }

    }
}
