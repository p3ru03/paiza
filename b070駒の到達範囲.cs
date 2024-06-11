//using System;
//using System.Text;
//using System.Collections.Generic;
//using System.Linq;
//class Program
//{
//    static void Main()
//    {
//        string[] datas = Console.ReadLine().Split(' ');
//        int N = int.Parse(datas[0]);
//        int H = int.Parse(datas[1]) - 1;
//        int W = int.Parse(datas[2]) - 1;
//        int K = int.Parse(datas[3]);

//        int ans = 0;
//        bool[,] field = new bool[N, N];
//        bool[,] field_copy = new bool[N, N];
//        field[H, W] = true;
//        Array.Copy(field, field_copy, field.Length);

//        //移動回数
//        for (int k = 0; k < K; k++)
//        {
//            for (int i = 0; i < N; i++)
//            {
//                for (int j = 0; j < N; j++)
//                {
//                    if (field[i, j])
//                    {
//                        Move(i, j, field_copy, N);
//                    }
//                }
//            }
//            Array.Copy(field_copy, field, field.Length);
//        }


//        for (int i = 0; i < N; i++)
//        {
//            for (int j = 0; j < N; j++)
//            {
//                if (field[i, j])
//                {
//                    ans++;
//                }
//            }
//        }

//        Console.WriteLine(ans);
//    }

//    static void Move(int i, int j, bool[,] copy, int N)
//    {
//        //上
//        if (i - 1 >= 0)
//        {
//            copy[i - 1, j] = true;
//        }
//        //下
//        if (i + 1 < N)
//        {
//            copy[i + 1, j] = true;
//        }
//        if (j - 1 >= 0)
//        {
//            copy[i, j - 1] = true;

//        }
//        if (j + 1 < N)
//        {
//            copy[i, j + 1] = true;

//        }
//        //左上
//        int a = 1;
//        while (i - a >= 0 && j - a >= 0)
//        {
//            copy[i - a, j - a] = true;
//            a++;
//        }
//        a = 1;
//        while (i - a >= 0 && j + a < N)
//        {
//            copy[i - a, j + a] = true;
//            a++;
//        }
//        a = 1;
//        while (i + a < N && j - a >= 0)
//        {
//            copy[i + a, j - a] = true;
//            a++;
//        }
//        a = 1;
//        while (i + a < N && j + a < N)
//        {
//            copy[i + a, j + a] = true;
//            a++;
//        }
//    }
//}