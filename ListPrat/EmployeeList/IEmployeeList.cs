namespace ListPrat.EmployeeList
{
    public interface IEmployeeList
    {
         void createList(EmpList objContact);
        void updateList();
        void deleteList();
        List<EmpList> DisplayList();

    }
}