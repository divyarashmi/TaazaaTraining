using System;
using PraticeProg.Models;
using System.Collections.Generic;
namespace PraticeProg.ContactList
{
    public class ContList
    {
       List<Contact> ObjectList;
       public ContList()
       {
           ObjectList = new List<Contact>();


       } 
       public void ContactDetails(Contact ObjectContact)
       {
           ObjectList.Add(ObjectContact);
       }
       public List<Contact> DisplayList()
       {
           return ObjectList;
       }
    }
   
}