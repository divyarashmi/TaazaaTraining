using System;
using SelfAnalyse.Practise;

namespace SelfAnalyse
{
    class Program
    {
        static void Main()
        {
            var Shalu = new IT (105,2000);
            var Deepak = new IT(102,3000);
            var sal = Shalu.EmployeeSalary();
            Console.WriteLine(sal);

            var sal1 =  Deepak.EmployeeSalary();
            Console.WriteLine(sal1);

            Console.WriteLine(IT.Coffeehouse());
        }
    }
}
