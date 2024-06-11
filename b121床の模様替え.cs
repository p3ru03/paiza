//using System;
//class Program
//{
//    static void Main()
//    {
//        int N = int.Parse(Console.ReadLine());

//        int[,] tile = new int[N, N];

//        for (int i = 0; i < N; i++)
//        {
//            string[] datas = Console.ReadLine().Split(' ');
//            for (int j = 0; j < N; j++)
//            {
//                tile[i, j] = int.Parse(datas[j]);
//            }
//        }

//        string[] data = Console.ReadLine().Split(' ');
//        int r = int.Parse(data[0]) - 1;
//        int c = int.Parse(data[1]) - 1;
//        int s = int.Parse(data[2]);
//        int d = int.Parse(data[3]) / 90;

//        //時計回り90度回転をd回やる
//        for (int t = 0; t < d; t++)
//        {
//            string[] copy = new string[s];
//            for (int i = r; i < r + s; i++)
//            {
//                for (int j = c; j < c + s; j++)
//                {
//                    copy[i - r] += tile[i, j];
//                }
//            }
//            //変更を反映
//            for (int i = r; i < r + s; i++)
//            {
//                for (int j = c; j < c + s; j++)
//                {
//                    tile[r + j - c, c + s - 1 - (i - r)] = int.Parse(copy[i - r][j - c].ToString());
//                }
//            }
//        }

//        for (int i = 0; i < N; i++)
//        {
//            for (int j = 0; j < N; j++)
//            {
//                Console.Write(tile[i, j]);
//                if (j != N - 1)
//                {
//                    Console.Write(" ");
//                }
//            }
//            Console.WriteLine();
//        }
//    }
//}
