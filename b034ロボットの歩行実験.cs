//using System;
//using System.Collections.Generic;
//using System.Linq;
//class Program
//{
//    static void Main()
//    {
//        string[] datas = Console.ReadLine().Split(' ');
//        int x = int.Parse(datas[0]);
//        int y = int.Parse(datas[1]);

//        datas = Console.ReadLine().Split(' ');
//        int df = int.Parse(datas[0]);
//        int dr = int.Parse(datas[1]);
//        int db = int.Parse(datas[2]);
//        int dl = int.Parse(datas[3]);

//        int N = int.Parse(Console.ReadLine());

//        string[,] orders = new string[N, 2];
//        for (int i = 0; i < N; i++)
//        {
//            datas = Console.ReadLine().Split(' ');
//            orders[i, 0] = datas[0];
//            orders[i, 1] = datas[1];
//        }

//        string[] directions = { "北", "東", "南", "西" };
//        int now = 0;
//        for (int i = 0; i < N; i++)
//        {
//            //移動
//            if (orders[i, 0] == "m")
//            {
//                if (directions[now] == "北")
//                {
//                    if (orders[i, 1] == "F")
//                    {
//                        y += df;
//                    }
//                    else if (orders[i, 1] == "R")
//                    {
//                        x += dr;
//                    }
//                    else if (orders[i, 1] == "B")
//                    {
//                        y -= db;
//                    }
//                    else if (orders[i, 1] == "L")
//                    {
//                        x -= dl;
//                    }
//                }
//                else if (directions[now] == "東")
//                {
//                    if (orders[i, 1] == "F")
//                    {
//                        x += df;
//                    }
//                    else if (orders[i, 1] == "R")
//                    {
//                        y -= dr;
//                    }
//                    else if (orders[i, 1] == "B")
//                    {
//                        x -= db;
//                    }
//                    else if (orders[i, 1] == "L")
//                    {
//                        y += dl;
//                    }
//                }
//                else if (directions[now] == "南")
//                {
//                    if (orders[i, 1] == "F")
//                    {
//                        y -= df;
//                    }
//                    else if (orders[i, 1] == "R")
//                    {
//                        x -= dr;
//                    }
//                    else if (orders[i, 1] == "B")
//                    {
//                        y += db;
//                    }
//                    else if (orders[i, 1] == "L")
//                    {
//                        x += dl;
//                    }
//                }
//                else if (directions[now] == "西")
//                {
//                    if (orders[i, 1] == "F")
//                    {
//                        x -= df;
//                    }
//                    else if (orders[i, 1] == "R")
//                    {
//                        y += dr;
//                    }
//                    else if (orders[i, 1] == "B")
//                    {
//                        x += db;
//                    }
//                    else if (orders[i, 1] == "L")
//                    {
//                        y -= dl;
//                    }
//                }
//            }
//            //方向転換
//            else if (orders[i, 0] == "t")
//            {
//                if (orders[i, 1] == "R")
//                {
//                    now += 1;
//                }
//                else if (orders[i, 1] == "B")
//                {
//                    now += 2;
//                }
//                else if (orders[i, 1] == "L")
//                {
//                    now -= 1;
//                }
//                //0 <= now <= 3
//                if (now > 3)
//                {
//                    now -= 4;
//                }
//                else if (now < 0)
//                {
//                    now += 4;
//                }
//            }
//        }
//        Console.WriteLine(x + " " + y);
//    }
//}

