using System;

namespace Array1
{
    class Program
    {
        static int sum(int []arr, int n)
    {
         
        int sum = 0; 
         
        
        
        for (int i = 0; i < n; i++)
            sum += arr[i];
         
        return sum;
    }
     
    // Driver method
    public static void Main()
    {
         
        int []arr = {12,3,4,15};
        int n = arr.Length;
         
        Console.Write("Sum of given array is "+ sum(arr, n));
    }
 
    }
}
