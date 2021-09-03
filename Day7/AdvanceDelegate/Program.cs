using System;
using AdvanceDelegate.Airthmetic;
delegate void AirthmeticDelegate(double D1, double D2);
namespace AdvanceDelegate
{
    class Program
    {
        static void Main()
        {
            var obj=new AirthmeticDelegate(AirthmeticOperation.Addition);
            //obj.Invoke(5,4);//invoke function will addition function
            obj+=AirthmeticOperation.Multiply;
            obj.Invoke(2,3);
          
        }
    }
}
