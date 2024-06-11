//using System;
//using System.Collections.Generic;
//using System.Linq;

//class Program
//{
//    static void Main()
//    {
//        int q = int.Parse(Console.ReadLine());
//        var fib = new Dictionary<int, int>();
//        fib[0] = 1;
//        fib[1] = 1;

//        int[] data = new int[q];
//        int max = 0;

//        for (int i = 0; i < q; i++)
//        {
//            data[i] = int.Parse(Console.ReadLine());
//            if(data[i] > max)
//            {
//                max = data[i];
//            }
//        }

//        for(int i = 2; i < max; i++)
//        {
//            fib[i] = fib[i - 1] + fib[i-2];
//        }
        
//        foreach (var i in data)
//        {
//            Console.WriteLine(fib[i-1]);
//        }
//    }
//}
