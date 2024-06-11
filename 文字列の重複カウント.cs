//using System;
//class Program
//{
//    static void Main()
//    {
//        string c = Console.ReadLine();
//        string n = Console.ReadLine();

//        int ans = 0;

//        for (int i = 0; i < n.Length; i++)
//        {
//            int count = 0;
//            for (int j = 0; j < c.Length; j++)
//            {
//                if (i + j >= n.Length)
//                    break;
//                if (n[i + j] == c[j])
//                {
//                    count++;
//                    if (count == c.Length)
//                    {
//                        ans++;
//                        break;
//                    }
//                }
//            }
//        }
//        Console.WriteLine(ans);
//    }
//}

