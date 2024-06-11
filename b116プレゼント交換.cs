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
//        int T = int.Parse(datas[2]);

//        string[,] field = new string[H + 1, W + 1];
//        //プレゼントの履歴
//        string[] M = new string[H + 1];
//        string[] F = new string[W + 1];
//        for (int i = 1; i < H + 1; i++)
//        {
//            M[i] = "M" + i;
//        }
//        for (int j = 1; j < W + 1; j++)
//        {
//            F[j] = "F" + j;
//        }

//        int tcount = 1;
//        int x = 1;
//        int y = 1;
//        int xchange = 1;
//        int ychange = 1;

//        do
//        {
//            //男の移動
//            for (int i = 1; i < H + 1; i++)
//            {
//                field[i, x] += "M" + i;
//                field[i, x - xchange] = null;
//            }
//            //女の移動
//            for (int j = 1; j < W + 1; j++)
//            {
//                field[y, j] += "F" + j;
//                field[y - ychange, j] = null;
//            }

//            //交換
//            for (int i = 1; i < H + 1; i++)
//            {
//                for (int j = 1; j < W + 1; j++)
//                {
//                    if (field[i, j] != null)
//                    {
//                        string tmp;
//                        //移動が被っていたら
//                        if (field[i, j].Contains("M") && field[i, j].Contains("F"))
//                        {
//                            tmp = M[i];
//                            M[i] = F[j];
//                            F[j] = tmp;
//                        }
//                    }

//                }
//            }

//            if (x == W)
//            {
//                xchange = -1;
//            }
//            else if (x == 0)
//            {
//                xchange = 1;
//            }
//            if (y == H)
//            {
//                ychange = -1;
//            }
//            else if (y == 0)
//            {
//                ychange = 1;
//            }
//            x += xchange;
//            y += ychange;

//            tcount++;
//        } while (tcount <= T);

//        for (int i = 1; i < H + 1; i++)
//        {
//            Console.WriteLine(M[i].Substring(0, 1) + " " + M[i].Substring(1));
//        }
//        for (int j = 1; j < W + 1; j++)
//        {
//            Console.WriteLine(F[j].Substring(0, 1) + " " + F[j].Substring(1));
//        }
//    }
//}