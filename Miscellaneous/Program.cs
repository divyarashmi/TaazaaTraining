using System;
using  Miscellaneous.IT;
namespace Miscellaneous
{
    class Program
    {
        static void Main()
        {
          var Mohan = new Taazaa(101,1000);
          var Sachin = new Taazaa(102,2000);
          var sal=Mohan.EmployeeSalary();
          Console.WriteLine(sal);

          var sal1=Sachin.EmployeeSalary();
          Console.WriteLine(sal1);

          var caf = Taazaa.Coffeehouse();
          Console.WriteLine(caf);

          Console.WriteLine(Taazaa.Coffeehouse());
        }
    }
}
