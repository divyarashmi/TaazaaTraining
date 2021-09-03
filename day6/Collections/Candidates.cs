using System.Collections;
using System;
using System.Collections.Generic;
namespace day6.Collections
{
    public class Candidates
    {
       public string AddCandidatesName()
       {
           ArrayList arrayList = new ArrayList();
           arrayList.Add("Divya");
           arrayList.Add("Divya Rashmi");
           string Name= (string)arrayList[1];// unboxing
           //Console.WriteLine(Name);
           return Name;
       } 
        public void AddCandidatesNames()
       {
          List<string> obj = new List<string>();
          obj.Add("Divya");
          obj.Add("Divya Rashmi");
           if (obj.Contains("Divya Rashmi"))  
            {  
                Console.WriteLine("Name found!");  
            }  
          string name = obj[0];
          Console.WriteLine(name);
       } 
    }
}