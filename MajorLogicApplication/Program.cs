// 31/08/2021(Major topic)
using System;

namespace MajorLogicApplication
{
    public class Employee
    {
        private int empcode;
        private string empName;
        // creating wrapper for accessing the private variable (method 1)
        public int employeeCode // wrapper for empcode
        {
            get
            {
                return empcode;
           }
            set{
                empcode=value;
           }
        }
        public string employeeName // wrapper for empcode
        {
            get
            {
                return empName;
           }
            set{
                empName=value;
           }
        }
    }
    class Program
    {
       public static void Main()
       {
           Employee employee=new Employee();
           employee.employeeCode=102;//set
           employee.employeeName="Divya Rashmi";//set
           Console.WriteLine(employee.employeeCode);//get
           Console.WriteLine(employee.employeeName);//get
           //doing same task using indexer
       }
    }
}
