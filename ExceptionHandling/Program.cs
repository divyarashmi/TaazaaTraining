using System;
using ExceptionHandling.Customer;

namespace ExceptionHandling
{
    class Program
    {
        static void Main()
        {
           Customers customers= new Customers();
           customers.getData(10,5);
        }
    }
}
