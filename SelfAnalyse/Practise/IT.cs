namespace SelfAnalyse.Practise
{
    public class IT
    {
        double Salary;
        readonly int Empid;
        static string Cafeteria;
        public IT(int eid, double sal)
        {
            Salary=sal;
            Empid=eid;
        }
        static IT()
        {
            Cafeteria = "500 Sqft";
        }
        public int Employeeid()
        {
            return Empid;
        }
        public static string Coffeehouse()
        {
            return Cafeteria;
        }
        public double EmployeeSalary()
        {
            return Salary;
        }
    }
}