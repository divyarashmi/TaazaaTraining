using System;
using ListAssignment.Model;
using System.Collections.Generic;


namespace ListAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Contact> list =new List<Contact>();
            list.Add(new Contact{
                cid=101,
                cname ="Divya",
                cphoneno = 9123
            });
            list.Add(new Contact{
                cid=102,
                cname ="Deepu",
                cphoneno = 912
            });
             var count = list.Count;
             for (int i=0;i<count;i++)
             {
                 Console.WriteLine(list[i].cid+" "+list[i].cname+" "+list[i].cphoneno);
             }
             int tar=1;
             if(list.[tar]ContainsKey()==1)
             {
                 Console.WriteLine("Found"+list[tar].cid+" "+list[tar].cname+" "+list[tar].cphoneno);
             }
             int tgr = 1;
             list[tgr].cid=105;
             list[tgr].cname="Shalu";
             Console.WriteLine("Updated Record" +list[tgr].cid+" "+list[tgr].cname);

             
             

        
        }
    }
}
