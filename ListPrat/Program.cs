using System.Collections.Generic;
using ListPrat.EmployeeList;
using ListPrat;
using System;
namespace practiceList.StudentList
{
    public class StudentLists
    {
        List<EmpList> list;
        public StudentLists()
        {
            list=new List<EmpList>();
        }
        public List<EmpList> AddStudentRecord()
        {
            list.Add(new EmpList{
                EmpId=12,
                EmpName="Geetika",
                StudentMail=""
            });
            list.Add(new Students{
                Studentrollno=14,
                StudentName="Deepti",
                StudentMail="Deepti@gmail.com"
            });
             list.Add(new Students{
                Studentrollno=16,
                StudentName="Divya",
                StudentMail="Divya@gmail.com"
            });
            return list;
        }
             public List<Students> updateRecord()
        {
            int target = 1;
            list[target].StudentName="Geetu";
            list[target].StudentMail="Geetu@gmail.com";
            return list;
        }
        public void deleteRecord()
        {
            int target =0;
            list.RemoveAt(target);
            Console.WriteLine("Record Deleted!");
        }
        public void searchRecord()
        {
                 int target = 1;
                list.FindIndex(student =>student.Studentrollno ==target);
                Console.WriteLine("Found");
                Console.WriteLine("Name => "+list[target].StudentName+"\nEmail => "+list[target].StudentMail);
        }

        }
    }
