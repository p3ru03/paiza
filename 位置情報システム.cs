//using System;
//class Program
//{
//    static void Main()
//    {
//        var n = int.Parse(Console.ReadLine());

//        var now = 0;
//        var t = new int[n];
//        var x = new long[n];
//        var y = new long[n];

//        //データを格納
//        for (int i = 0; i < n; i++)
//        {
//            var data = Console.ReadLine().Split(' ');
//            t[i] = int.Parse(data[0]);
//            y[i] = long.Parse(data[1]);
//            x[i] = long.Parse(data[2]);
//        }

//        for (int i = 0; i <= 100; i++)
//        {
//            //現在時刻の座標が分かっていたら
//            if (i == t[now])
//            {
//                Console.WriteLine($"{y[now]} {x[now]}");
//                now++;
//            }
//            else
//            {
//                //最後に割らないといけない
//                var Y = y[now - 1] + (i - t[now - 1]) * (y[now] - y[now - 1]) / (t[now] - t[now - 1]);
//                var X = x[now - 1] + (i - t[now - 1]) * (x[now] - x[now - 1]) / (t[now] - t[now - 1]);
//                Console.WriteLine($"{Y} {X}");
//            }
//        }
//    }
//}

