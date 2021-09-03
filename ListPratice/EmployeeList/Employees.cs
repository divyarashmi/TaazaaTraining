using System;
using ListPratice.Models;
using System.Collections.Generic;
namespace ListPratice.EmployeeList
{
    public class Employees
    {
        List<Employee> ObjectList = new List<Employee>();
        public Employees()
        {
            ObjectList=new List<Employee>();
        }
        public void EmployeeName(Employee objectEmployee)
        {
            ObjectList.Add(objectEmployee);
        }
        public void EmployeeId(Employee ObjectId)
        {
            ObjectList.Add(ObjectId);
        }
        public List<Employees> DisplayDetails()
        {
            return 1;
        }
        

        
    }
}