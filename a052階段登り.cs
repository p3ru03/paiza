//using System;
//using System.Collections.Generic;
//using System.Linq;
//class Program
//{
//    static void Main()
//    {
//        int N = int.Parse(Console.ReadLine());
//        string[] datas = Console.ReadLine().Split(' ');
//        int A = int.Parse(datas[0]);
//        int B = int.Parse(datas[1]);

//        bool[] isDirty = new bool[N + 1];

//        isDirty[0] = true;

//        for (int i = 0; i < isDirty.Length; i++)
//        {
//            if (isDirty[i])
//            {
//                if (i + A <= N)
//                {
//                    isDirty[i + A] = true;
//                }
//                if (i + B <= N)
//                {
//                    isDirty[i + B] = true;
//                }
//            }
//        }
//        isDirty[N] = true;

//        int sum = 0;
//        for (int i = 1; i < isDirty.Length; i++)
//        {
//            if (!isDirty[i])
//            {
//                sum++;
//            }
//        }
//        Console.WriteLine(sum);
//    }

//}
