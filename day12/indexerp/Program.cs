using System;
using indexerp.Employees;

namespace indexerp
{
    class Program
    {
        public static void Main()
        {
            Employee employee = new Employee();
            employee.Empid=101; // at this time set will be called
            Console.WriteLine(employee.Empid);// at this point get will be called
        }
    }
}
