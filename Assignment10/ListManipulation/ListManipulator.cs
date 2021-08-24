using Assignment10.Models;
using System.Collections.Generic;

namespace Assignment10.ListManipulation
{
    public class ListManipulator
    {
        List<Contact> objList;

        public ListManipulator()
        {
            objList=new List<Contact>();
        }

        public void createList(Contact objContact)
        {
            objList.Add(objContact);
        
        }

        public void updateList()
        {
            
        }
         public void deleteList()
        {
            
        }


        public List<Contact> DisplayList()
        {
            return objList;
        }
    }
}