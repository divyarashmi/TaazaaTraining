using System.Collections.Generic;
using Day9.Models;
namespace Day9.ContactList
{
    public class ContactsListcs
    {
       List<Contact> objList;
       public ContactsListcs()
       {
           objList =new List<Contact>();

       }
       public void createContact (Contact objContact)
       {
           objList.Add(objContact); 
    
            
       }
       public List<Contact> DisplayList()
       {
           return objList;
       }
    }
}