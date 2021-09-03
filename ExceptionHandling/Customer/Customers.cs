using System;
namespace ExceptionHandling.Customer
{
    //Exception class in C# is a base class in Exception Handling which can handle all the exceptions.
    //Airthmetic Exception is a base class of DividebyZeroException that's why base class can handle the dervied class exception. 
    public class Customers
    {
        int result;
        public Customers()
        {
            result=0;
        }
        public void getData(int x, int y)
        {
            try{
                result=x/y;
            }
            catch(ArithmeticException ex)
            {
                Console.WriteLine("Hello",ex);
            }
            finally{
                Console.WriteLine(result);
            }
        }
    }
}