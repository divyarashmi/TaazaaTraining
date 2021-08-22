using System;
using  collectionA.Assig;

namespace collectionA
{
    class Program
    {
        static void Main()
        {
            var list = new EmployeeList();
            var emplist = list.Employeedetails();
            int count = emplist.Count;
            for(int i=0; i<count; i++)
            {
                Console.WriteLine(emplist[i]);
            }
        
        }
    }
}
