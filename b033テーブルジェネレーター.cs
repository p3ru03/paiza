//using System;
//using System.Text;
//using System.Collections.Generic;
//using System.Linq;
//class Program
//{
//    static void Main()
//    {
//        int W = int.Parse(Console.ReadLine());
//        string[] Header = new string[W];
//        string[] datas = Console.ReadLine().Split(' ');
//        for (int j = 0; j < W; j++)
//        {
//            Header[j] = datas[j];
//        }

//        int H = int.Parse(Console.ReadLine());

//        string[,] data = new string[H, W];
//        for (int i = 0; i < H; i++)
//        {
//            datas = Console.ReadLine().Split(' ');
//            for (int j = 0; j < W; j++)
//            {
//                data[i, j] = datas[j];
//            }
//        }

//        //文字列の最大値を測定
//        int[] maxlen = new int[W];
//        for (int j = 0; j < W; j++)
//        {
//            maxlen[j] = Math.Max(maxlen[j], Header[j].Length);
//            for (int i = 0; i < H; i++)
//            {
//                maxlen[j] = Math.Max(maxlen[j], data[i, j].Length);
//            }
//        }

//        //見出しの出力
//        for (int j = 0; j < W; j++)
//        {
//            Console.Write("|" + " " + Header[j] + " ");
//            for (int k = 0; k < maxlen[j] - Header[j].Length; k++)
//            {
//                Console.Write(" ");
//            }
//            //最後の列
//            if (j == W - 1)
//            {
//                Console.Write("|");
//                Console.WriteLine();
//            }
//        }

//        //区切りの出力
//        for (int j = 0; j < W; j++)
//        {
//            Console.Write("|");
//            for (int k = 0; k < maxlen[j] + 2; k++)
//            {
//                Console.Write("-");
//            }
//            //最後の列
//            if (j == W - 1)
//            {
//                Console.Write("|");
//                Console.WriteLine();
//            }
//        }

//        //データの出力
//        for(int i = 0; i < H; i++)
//        {
//            for (int j = 0; j < W; j++)
//            {
//                Console.Write("|" + " " + data[i,j] + " ");
//                for (int k = 0; k < maxlen[j] - data[i, j].Length; k++)
//                {
//                    Console.Write(" ");
//                }
//                //最後の列
//                if (j == W - 1)
//                {
//                    Console.Write("|");
//                    Console.WriteLine();
//                }
//            }
//        }
//    }
//}