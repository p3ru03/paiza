//using System;
//using System.Collections.Generic;
//using System.Linq;

//class Program
//{
//    static void Main()
//    {
//        int n = int.Parse(Console.ReadLine());
//        var user = new Dictionary<string, string>();

//        for (int i = 0; i < n; i++)
//        {
//            string[] data = Console.ReadLine().Split(' ');
//            user.Add(data[0], data[1]);
//        }

//        int m = int.Parse(Console.ReadLine());
//        var destiny = new Dictionary<string, string>();

//        for (int i = 0; i < m; i++)
//        {
//            string[] data = Console.ReadLine().Split(' ');
//            destiny.Add(data[0], data[1]);
//        }

//        foreach (var i in user)
//        {
//            var name = i.Key;
//            var bloodType = user[name];
//            Console.WriteLine(name + " " + destiny[bloodType]);
//        }
//    }
//}
