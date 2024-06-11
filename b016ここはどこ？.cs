//using System;
//using System.Text;
//class Program
//{
//    static void Main()
//    {
//        string[] datas = Console.ReadLine().Split(' ');
//        int w = int.Parse(datas[0]);
//        int h = int.Parse(datas[1]);
//        int n = int.Parse(datas[2]);

//        datas = Console.ReadLine().Split(' ');
//        int x = int.Parse(datas[0]);
//        int y = int.Parse(datas[1]);

//        string[] dir = new string[n];
//        int[] dis = new int[n];
//        for (int i = 0; i < n; i++)
//        {
//            datas = Console.ReadLine().Split(' ');
//            dir[i] = datas[0];
//            dis[i] = int.Parse(datas[1]);
//        }

//        for (int i = 0; i < n; i++)
//        {
//            if (dir[i] == "U")
//            {
//                y += dis[i];
//            }
//            else if (dir[i] == "D")
//            {
//                y -= dis[i];
//            }
//            else if (dir[i] == "R")
//            {
//                x += dis[i];
//            }
//            else if (dir[i] == "L")
//            {
//                x -= dis[i];
//            }
//            //一気に二周以上するときもある
//            x = (x % w + w) % w;
//            y = (y % h + h) % h;
//        }
//        Console.WriteLine(x + " " + y);
//    }
//}