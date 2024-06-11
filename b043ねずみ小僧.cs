//using System;
//using System.Text;
//using System.Collections.Generic;
//using System.Linq;
//class Program
//{
//    static void Main()
//    {
//        string[] datas = Console.ReadLine().Split(' ');
//        int H = int.Parse(datas[0]);
//        int W = int.Parse(datas[1]);

//        datas = Console.ReadLine().Split(' ');
//        int h = int.Parse(datas[0]) - 1;
//        int w = int.Parse(datas[1]) - 1;

//        char[,] town = new char[H, W];
//        for (int i = 0; i < H; i++)
//        {
//            string data = Console.ReadLine();
//            for (int j = 0; j < W; j++)
//            {
//                town[i, j] = data[j];
//            }
//        }

//        string[] directions = { "北", "東", "南", "西" };
//        int now = 0;

//        do
//        {
//            if (town[h, w] == '.')
//            {
//                town[h, w] = '*';
//                now++;
//                if (now == 4)
//                {
//                    now = 0;
//                }
//            }
//            else
//            {
//                town[h, w] = '.';
//                now--;
//                if (now == -1)
//                {
//                    now = 3;
//                }
//            }
//            //移動
//            if (directions[now] == "北")
//            {
//                h--;
//            }
//            else if (directions[now] == "東")
//            {
//                w++;
//            }
//            else if (directions[now] == "南")
//            {
//                h++;
//            }
//            else if (directions[now] == "西")
//            {
//                w--;
//            }
//            //町の外
//            if (h < 0 || h > H - 1 || w < 0 || w > W - 1)
//            {
//                break;
//            }
//        } while (true);

//        for (int i = 0; i < H; i++)
//        {
//            for (int j = 0; j < W; j++)
//            {
//                Console.Write(town[i, j]);
//            }
//            Console.WriteLine();
//        }
//    }
//}