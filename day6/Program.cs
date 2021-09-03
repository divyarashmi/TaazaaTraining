using System;
using day6.Collections;
namespace day6
{
    class Program
    {
        static void Main(string[] args)
        {
            var Can = new Candidates();
            
            var Str= Can.AddCandidatesName();
            Console.WriteLine(Str);
            Can.AddCandidatesName();
        }
    }
}
