//using System;
//using System.Collections.Generic;
//using System.Linq;
//class Program
//{
//    static void Main()
//    {
//        int n = int.Parse(Console.ReadLine());

//        var pages = new List<string>();
//        string[] q = new string[n];
//        int now = -1;
//        for (int i = 0; i < n; i++)
//        {
//            q[i] = Console.ReadLine();
//            if (q[i].Contains("go to "))
//            {
//                now++;
//                pages.Add(q[i].Substring(6));
//            }
//            else if (q[i] == "use the back button")
//            {
//                pages.RemoveAt(now);
//                now--;
//            }
//            Console.WriteLine(pages[now]);
//        }
//    }
//}