using System;

using dele5.Models;

delegate void StudentDelegate (string A, string B);

namespace dele5
{
    class Program
    {
       static void Main(string args[])
       {
           StudentDelegate obj = new StudentDelegate(StudentList.student)
       }
    }
}
