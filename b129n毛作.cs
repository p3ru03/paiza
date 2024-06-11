//using System;
//using System.Collections.Generic;
//using System.Linq;
//class Program
//{
//    static void Main()
//    {
//        string[] data = Console.ReadLine().Split(' ');
//        int n = int.Parse(data[0]);
//        int m = int.Parse(data[1]);

//        data = Console.ReadLine().Split(' ');
//        int h = int.Parse(data[0]);
//        int w = int.Parse(data[1]);

//        string[,] field = new string[h, w];

//        int[,] harvests = new int[n, 5];
//        for (int i = 0; i < n; i++)
//        {
//            data = Console.ReadLine().Split(' ');
//            for (int j = 0; j < 5; j++)
//            {
//                harvests[i, j] = int.Parse(data[j]);
//            }
//        }

//        int[] crops = new int[m];

//        for (int i = 0; i < n; i++)
//        {
//            for (int i2 = harvests[i, 0] - 1; i2 < harvests[i, 1]; i2++)
//            {
//                for (int j = harvests[i, 2] - 1; j < harvests[i, 3]; j++)
//                {
//                    //収穫
//                    if (field[i2, j] != null)
//                    {
//                        crops[int.Parse(field[i2, j]) - 1]++;
//                    }
//                    //植える
//                    field[i2, j] = harvests[i, 4].ToString();
//                }
//            }
//        }

//        for (int i = 0; i < m; i++)
//        {
//            Console.WriteLine(crops[i]);
//        }

//        for (int i = 0; i < h; i++)
//        {
//            for (int j = 0; j < w; j++)
//            {
//                if (field[i, j] == null)
//                {
//                    field[i, j] = ".";
//                }
//                Console.Write(field[i, j]);
//            }
//            Console.WriteLine();
//        }
//    }
//}

