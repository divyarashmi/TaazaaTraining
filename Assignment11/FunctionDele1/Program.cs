using System;

namespace FunctionDele1
{
    class Program
    {
        static int Subtract(int a, int b)
        {
            return a - b;
        }
        static void Main(string[] args)
        {
            Func<int, int, int> sub = Subtract;
            int result = sub(30, 10);
            Console.WriteLine(result);
        }
    
    }
}
