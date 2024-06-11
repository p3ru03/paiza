//using System;
//using System.Text;
//using System.Collections.Generic;
//using System.Linq;
//class Program
//{
//    static void Main()
//    {
//        string[] datas = Console.ReadLine().Split(' ');
//        string s1 = datas[0];
//        string s2 = datas[1];

//        int s1len = s1.Length;
//        int s2len = s2.Length;

//        char[] data = { 'A', 'B', 'C', 'D', 'E' };
//        int s1int = 0;
//        int s2int = 0;
//        //10進数に
//        for (int k = 0; k < s1len; k++)
//        {
//            for (int i = 0; i < data.Length; i++)
//            {
//                if (data[i] == s1[k])
//                {
//                    s1int += i * (int)Math.Pow(5, s1len - 1 - k);
//                }

//            }
//        }
//        for (int k = 0; k < s2len; k++)
//        {
//            for (int i = 0; i < data.Length; i++)
//            {
//                if (data[i] == s2[k])
//                {
//                    s2int += i * (int)Math.Pow(5, s2len - 1 - k);
//                }

//            }
//        }

//        int sum = s1int + s2int;
//        var changed = new List<int>();
//        //5進数に
//        while (true)
//        {
//            changed.Add(sum % 5);
//            sum = sum / 5;
//            if (sum == 0)
//            {
//                break;
//            }
//        }

//        for (int i = changed.Count - 1; i >= 0; i--)
//        {
//            Console.Write(data[changed[i]]);
//            if (i == 0)
//            {
//                Console.WriteLine();
//            }
//        }
//    }
//}