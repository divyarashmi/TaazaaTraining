using System;
using  CollectionP.Models;
using CollectionP.EmployeeList;

namespace CollectionP
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            emp.EmpId=101;
            emp.EmpName="Divya";
            emp.EmpSalary=2000;

             Employee emp1 = new Employee();
            emp1.EmpId=102;
            emp1.EmpName="Deepak";
            emp1.EmpSalary=4000;

            EmpList obj1 = new EmpList();
            obj1.AddEmployee(emp);

            var temp = obj1.EmpDisplayList();
            foreach(var i in temp)
            {
                Console.WriteLine(i.EmpId+" "+i.EmpName+" "+i.EmpSalary);
            }
            Employee empsearch=obj1.EmpSearch(101);
            Console.WriteLine(empsearch.EmpId+""+empsearch.EmpName+""+empsearch.EmpSalary);
        }
    }
}
