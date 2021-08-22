using System.Collections;
using System.Collections.Generic;
namespace collectionA.Assig
{
    public class collection
    {
        private int Eid;
        private string Ename;
    }
    public class EmployeeList
    {
        public ArrayList Employeedetails()
        {
            ArrayList arrayList = new ArrayList();
            arrayList.Add("Divya");
            arrayList.Add("Geetika");
            arrayList.Add("Deepak");
            return arrayList;
        }
    }
}