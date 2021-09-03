using System;
using System.Collections.Generic;
namespace ListPrat.EmployeeList
{
    public class EmpList
    {
        List<EmpList> objList;

        public EmpList()
        {
            objList=new List<EmpList>();
        }

        public void createList(EmpList objEmpList)
        {
            objList.Add(objEmpList);
        
        }

        public void updateList()
        {
            
        }
         public void deleteList()
        {
            
        }


        public List<EmpList> DisplayList()
        {
            return objList;
        }
    }
}