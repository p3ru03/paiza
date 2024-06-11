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

//        string[,] dungeon = new string[H + 2, W + 2];
//        for (int i = 1; i < H + 1; i++)
//        {
//            string data = Console.ReadLine();
//            for (int j = 1; j < W + 1; j++)
//            {
//                dungeon[i, j] = data[j - 1].ToString();
//            }
//        }

//        datas = Console.ReadLine().Split(' ');
//        int x = int.Parse(datas[0]);
//        int y = int.Parse(datas[1]);

//        int N = int.Parse(Console.ReadLine());
//        string[] moves = new string[N];
//        for (int i = 0; i < N; i++)
//        {
//            moves[i] = Console.ReadLine();
//        }

//        for (int n = 0; n < N; n++)
//        {
//            int x2 = 0;
//            int y2 = 0;
//            if (moves[n] == "U")
//            {
//                y2 = -1;
//            }
//            else if (moves[n] == "R")
//            {
//                x2 = 1;
//            }
//            else if (moves[n] == "D")
//            {
//                y2 = 1;
//            }
//            else if (moves[n] == "L")
//            {
//                x2 = -1;
//            }

//            do
//            {
//                //移動する先に壁がある場合
//                if (dungeon[y + y2, x + x2] == null)
//                {
//                    break;
//                }
//                x += x2;
//                y += y2;
//                //土の床に移動した場合か，次の移動先が壁の場合
//                if (dungeon[y, x] == "." || dungeon[y + y2, x + x2] == null)
//                {
//                    break;
//                }
//            } while (true);
//        }

//        Console.WriteLine(x + " " + y);
//    }
//}