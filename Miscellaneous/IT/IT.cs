namespace Miscellaneous.IT
{
    public class Taazaa
    {
      double Salary;
      readonly int EmpId;
      static string Cafeteria;
      public Taazaa(int eid, double Sal)
      {
          Salary=Sal;
          EmpId=eid;
      }
      static Taazaa()
      {
          Cafeteria = "100 Sqft";
      }
      public int Employeeid()
      {
          return EmpId;
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