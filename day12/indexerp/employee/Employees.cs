namespace indexerp.Employees
{
    public class Employee
    {
        public int Eid;
        public int Empid
        {
            get
            {
                return Eid;
            }
            set
            {
                Eid=value;//value is a keyword 
            }
        }
    }
}