using System;
 using Day9.Models;
 using Day9.ContactList;
 using System.Collections.Generic;

namespace Day9
{
    class Program
    {
        static void Main()
        {
            Contact obj=new Contact();
            obj.id=101;
            obj.Name="Divya";
            
            Contact obj1=new Contact();
            obj1.id=102;
            obj1.Name="Dibu";
            ContactsListcs objContactsListcs = new ContactsListcs();
            objContactsListcs.createContact(obj);
            objContactsListcs.createContact(obj1);
            List<Contact> objectContact = objContactsListcs.DisplayList();
            foreach (var item in objectContact)
            {
                Console.WriteLine(item.id+" "+item.Name);
            }
        }
    }
}
