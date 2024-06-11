//using System;
//using System.Text;
//class Program
//{
//    static void Main()
//    {
//        string[] datas = Console.ReadLine().Split(' ');
//        int h = int.Parse(datas[0]);
//        int w = int.Parse(datas[1]);
//        int k = int.Parse(datas[2]);

//        char[,] numbers = new char[h, w];
//        for (int i = 0; i < h; i++)
//        {
//            string str = Console.ReadLine();
//            for (int j = 0; j < w; j++)
//            {
//                numbers[i, j] = str[j];
//            }
//        }

//        int max = 0;
//        for (int i = 0; i < h; i++)
//        {
//            for (int j = 0; j < w; j++)
//            {
//                if (j + k - 1 < w)
//                {
//                    int sum = 0;
//                    for (int x = 0; x < k; x++)
//                    {
//                        sum = sum * 10 + (numbers[i, j + x] - '0');
//                    }
//                    max = Math.Max(max, sum);
//                }
//                if (i + k - 1 < h)
//                {
//                    int sum = 0;
//                    for (int x = 0; x < k; x++)
//                    {
//                        sum = sum * 10 + (numbers[i + x, j] - '0');
//                    }
//                    max = Math.Max(max, sum);
//                }
//            }
//        }
//        Console.WriteLine(max);
//    }
//}