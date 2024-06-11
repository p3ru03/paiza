//using System;
//using System.Text;
//using System.Collections.Generic;
//using System.Linq;
//class Program
//{

//    static void Main()
//    {
//        int N = int.Parse(Console.ReadLine());
//        string[] datas = Console.ReadLine().Split(' ');
//        int H = int.Parse(datas[0]);
//        int W = int.Parse(datas[1]);

//        char[,] room = new char[H, W];
//        for (int i = 0; i < H; i++)
//        {
//            string data = Console.ReadLine();
//            for (int j = 0; j < W; j++)
//            {
//                room[i, j] = data[j];
//            }
//        }

//        int ans = 0;
//        string[] directions = { "右", "下", "左", "上" };
//        int now = 0;
//        int x = 0;
//        int y = 0;

//        for (int t = 0; t < N; t++)
//        {
//            int dx = x;
//            int dy = y;
//            //掃除
//            if (room[y, x] == '#')
//            {
//                ans++;
//            }
//            room[y, x] = 'c';
//            //移動
//            int counter = 0;
//            do
//            {
//                if (directions[now] == "右")
//                {
//                    dx++;
//                }
//                else if (directions[now] == "下")
//                {
//                    dy++;
//                }
//                else if (directions[now] == "左")
//                {
//                    dx--;
//                }
//                else if (directions[now] == "上")
//                {
//                    dy--;
//                }
//                //掃除済みか壁の場合
//                if (dx == -1 || dy == -1 || dx == W || dy == H || room[dy, dx] == 'c')
//                {
//                    now++;
//                    counter++;
//                    //もうどこもいけない
//                    if (counter == 4)
//                    {
//                        break;
//                    }
//                    if (now == 4)
//                    {
//                        now = 0;
//                    }
//                    dx = x;
//                    dy = y;
//                }
//                //移動完了
//                else
//                {
//                    x = dx;
//                    y = dy;
//                    break;
//                }
//            } while (true);
//        }
//        Console.WriteLine(ans);
//    }
//}