using System;
using System.Collections;
using Collectionp.Taazaa;

namespace Collectionp
{
    class Program
    {
        static void Main()
        {
           /*  var Obj = new Candidatelist();
           var arrayList= Obj.Candidatedetails();
            int count=arrayList.Count;
            for(int i=0;i<count;i++)
            {
               Console.WriteLine(arrayList[i]); */
           /* } */
            var Objlist = new Candidatelist();
            var list= Objlist.Candidatedetail();
            int count=list.Count;
            for(int i=0;i<count;i++)
            {
               Console.WriteLine(list[i].Cid + " "+list[i].Cname);
           }
        }
    }
}
