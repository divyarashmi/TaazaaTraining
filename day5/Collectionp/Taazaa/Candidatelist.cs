using System.Collections;
using System.Collections.Generic;
using Collectionp.Models;


namespace Collectionp.Taazaa

{
    public class Candidatelist
    {
        public ArrayList Candidatedetails()
        {
            
            ArrayList arrayList=new ArrayList();
            arrayList.Add("Salman");
            arrayList.Add("Divya");
            return arrayList;
        }
         public List<Candidate> Candidatedetail()
        {
            List<Candidate> Obj= new List<Candidate>();
            Obj.Add(new Candidate{
                Cid=101,
                Cname="Divya"
            });
            Obj.Add(new Candidate{
                Cid=102,
                Cname="Deepak"
            });
            return Obj;
            
        }
    }
}