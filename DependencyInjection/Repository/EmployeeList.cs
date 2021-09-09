using DependencyInjection.Models;
namespace DependencyInjection.Repository
{
    public class EmployeeList:IEmployeeList
    {
        public int CreateEmployee(Employee obj)
        {
            return 1;
        }
    }
}