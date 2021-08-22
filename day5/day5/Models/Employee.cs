namespace day5.Models
{
    public class Employee
    {
        private int Eid;
        private double Salary;

        public int Employeeid //properties
        {
            get //Access
            {
                return Eid;
                
            }
            set //Assign
            {
                Eid = value;// value is a reserved keyword to assign the data of a variable
            }

        }
         public double Employeesalary//properties
        {
            get //Access
            {
                return Salary;
                
            }
            set //Assign
            {
                Salary= value;// value is a reserved keyword to assign the data of a variable
            }
        
    }
    } 
} 