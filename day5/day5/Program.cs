using System;
using day5.Models;

namespace day5
{
    class Program
    {
        static void Main()
        {
          var obj =new Employee();
          
          obj.Employeeid=101;//set is working
          Console.WriteLine(obj.Employeeid); //get the eid value
          obj.Employeesalary=5000;
          Console.WriteLine(obj.Employeesalary);
          
        }
    }
}
