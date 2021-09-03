using System;
using System.Collections.Generic;
namespace ListApplication
{
    public class Employee
    {
        public int Eid{get;set;}
        public string Ename{get;set;}
    }

    public class EmployeeList
    {
      List<Employee> list = new List<Employee>();
     public int AddEmployee(Employee employee)
    {
        list.Add(employee);
        return 1;
    }
    class Program
    {
        static void Main()
        {
            Employee obj = new Employee();
            obj.Eid = 101;
            obj.Ename = "Divya";

            Employee obj1 = new Employee();
            obj1.Eid = 102;
            obj1.Ename = "Sakshi";
            
            EmployeeList employeeList = new EmployeeList();
            int x = employeeList.AddEmployee(obj);
            if(x==1)
            {
               Console.WriteLine("one record is added");
  
            }
           


        }
        

    }
        
    }
}
