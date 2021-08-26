using System;
using Delegate2.Models;

delegate void StudentsDelegate(string A, string B);

namespace Delegate2
{
    class Program
    {

    
    static void Main(string[] args)
    {
        StudentsDelegate Obj = new StudentsDelegate(StudentsList.StudentsName);
        Obj.Invoke("Divya","Rashmi");
        StudentsDelegate student =(string A, string B)=>
        {
            Console.WriteLine(A+" "+B);
        };
        StudentsDelegate Std = delegate (string A, string B)
        {
            Console.WriteLine(A+" "+B);
        };
        student("Shalu","Tiwari");
        Std("Geetika","Shukla");
    }
    }
}