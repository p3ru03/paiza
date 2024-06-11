//using System;
//using System.Collections.Generic;
//using System.Linq;

//class Program
//{
//    static void Main()
//    {
//        int n = int.Parse(Console.ReadLine());
//        var Group = new Dictionary<string, int>();

//        for (int i = 0; i < n; i++)
//        {
//            string[] data = Console.ReadLine().Split(' ');
//            //既に存在するかどうか
//            if (Group.ContainsKey(data[0]))
//            {
//                Group[data[0]] += int.Parse(data[1]);
//            }
//            else
//            {
//                Group.Add(data[0], int.Parse(data[1]));
//            }
//        }
//        //降順にソート
//        var newGroup = Group.OrderByDescending(x => x.Value);

//        foreach (var i in newGroup)
//        {
//            Console.WriteLine(i.Key + " " + i.Value);
//        }
//    }
//}



