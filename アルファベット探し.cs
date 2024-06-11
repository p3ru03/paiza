//using System;
//using System.Collections.Generic;
//using System.Linq;

//class Program
//{
//    static void Main()
//    {
//        string x = Console.ReadLine();
//        string y = Console.ReadLine();
//        string c = Console.ReadLine();

//        var list = new List<string>();
//        list.Add(x);
//        list.Add(y);
//        list.Add(c);

//        list = list.OrderBy(z => z).ToList();

//        //xとyの間にcがあるとき
//        if (list.IndexOf(c) > list.IndexOf(x) && list.IndexOf(c) < list.IndexOf(y))
//        {
//            Console.WriteLine("true");
//        }
//        //cがxまたはyと等しい時
//        else if (x == c || y == c)
//        {
//            Console.WriteLine("true");
//        }
//        else
//        {
//            Console.WriteLine("false");
//        }
//    }
//}