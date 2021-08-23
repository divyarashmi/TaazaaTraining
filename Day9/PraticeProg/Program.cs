using System;
using PraticeProg.ContactList;
using System.Collections.Generic;

namespace PraticeProg
{
    class Program
    {
        static void Main(string[] args)
        {
          Contact ObjectContact = new Contact();
          ObjectContact.id=101;
          ObjectContact.Name="Divya";
            Contact ObjectContact1 = new Contact();
          ObjectContact1.id=102;
          ObjectContact1.Name="Dia";

          ContList ObjList = new ContList();
          ObjList.ContactDetails(ObjectContact);
          ObjList.ContactDetails(ObjectContact1);
          List<Contact> temp = ObjList.DisplayList();
        }
    }
}
