//using System;
//using System.Collections.Generic;
//using System.Linq;
//class Program
//{
//    static void Main()
//    {
//        int n = int.Parse(Console.ReadLine());
//        int[] heights = new int[n];
//        for (int i = 0; i < n; i++)
//        {
//            heights[i] = int.Parse(Console.ReadLine());
//        }

//        int count = 1;
//        int ans = 1;

//        for (int i = 0; i < n - 1; i++)
//        {
//            if (heights[i] >= heights[i + 1])
//            {
//                count++;
//                if (count > ans)
//                {
//                    ans = count;
//                }
//            }
//            else
//            {
//                count = 1;
//            }
//        }
//        Console.WriteLine(ans);
//    }
//}

