using System;
using DelegatePractice.Noida;

delegate int BrokerDelegate();

namespace DelegatePractice
{
    class Program
    {
        static void Main(string[] args)
        {
            var obj1 = new Broker();
            BrokerDelegate cobj = new BrokerDelegate(obj1.Flat1);
            var temp1= cobj.Invoke();
            Console.WriteLine(temp1);
            cobj+=obj1.Flat3;
            var temp2 = cobj.Invoke();
            Console.WriteLine(temp2);
        }
    }
}
