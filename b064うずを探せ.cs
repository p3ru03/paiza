//using System;
//using System.Linq;
//using System.Collections.Generic;
//using System.Globalization;
//class Program
//{
//    static void Main()
//    {
//        string[] datas = Console.ReadLine().Split(' ');
//        int H = int.Parse(datas[0]);
//        int W = int.Parse(datas[1]);

//        string[,] winds = new string[H, W];
//        for (int i = 0; i < H; i++)
//        {
//            string data = Console.ReadLine();
//            for (int j = 0; j < W; j++)
//            {
//                winds[i, j] = data[j].ToString();
//            }
//        }

//        int ans = 0;
//        string[,] copy = new string[H, W];
//        Array.Copy(winds, copy, winds.Length);
//        for (int i = 0; i < H; i++)
//        {
//            for (int j = 0; j < W; j++)
//            {
//                int x = j;
//                int y = i;
//                while (true)
//                {
//                    int dx = 0;
//                    int dy = 0;
//                    //移動先
//                    if (winds[y, x] == "R")
//                    {
//                        dx++;
//                    }
//                    else if (winds[y, x] == "L")
//                    {
//                        dx--;
//                    }
//                    else if (winds[y, x] == "U")
//                    {
//                        dy--;
//                    }
//                    else if (winds[y, x] == "D")
//                    {
//                        dy++;
//                    }
//                    //渦スタート
//                    else if (winds[y, x] == ".")
//                    {
//                        break;
//                    }
//                    winds[y, x] = ".";
//                    x += dx;
//                    y += dy;
//                    //境界外
//                    if (x == -1 || x == W || y == -1 || y == H)
//                    {
//                        break;
//                    }
//                    //渦になった
//                    if (y == i && x == j)
//                    {
//                        ans++;
//                        Array.Copy(winds, copy, winds.Length);
//                        break;
//                    }
//                    //途中で戻ってきた
//                    if (winds[y, x] == ".")
//                    {
//                        break;
//                    }

//                }
//                Array.Copy(copy, winds, copy.Length);
//            }
//        }

//        Console.WriteLine(ans);
//    }
//}


