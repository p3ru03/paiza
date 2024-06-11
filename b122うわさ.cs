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

//        string[,] houses = new string[H, W];
//        for (int i = 0; i < H; i++)
//        {
//            string data = Console.ReadLine();
//            for (int j = 0; j < W; j++)
//            {
//                houses[i, j] = data[j].ToString();
//            }
//        }

//        int ans = 0;
//        bool isOk = false;
//        bool isNo = false;
//        string[,] copy = new string[H, W];
//        string[,] temp = new string[H, W];

//        Array.Copy(houses, copy, houses.Length);
//        Array.Copy(houses, temp, houses.Length);

//        while (true)
//        {
//            for (int i = 0; i < H; i++)
//            {
//                for (int j = 0; j < W; j++)
//                {
//                    if (houses[i, j] != "#")
//                    {
//                        goto notyet1;
//                    }
//                }
//                if (i == H - 1)
//                {
//                    isOk = true;
//                }
//            }
//            //全家庭に噂が広まった
//            if (isOk)
//            {
//                break;
//            }
//        notyet1:;

//            //噂を広める
//            for (int i = 0; i < H; i++)
//            {
//                for (int j = 0; j < W; j++)
//                {
//                    if (houses[i, j] == "#")
//                    {
//                        continue;
//                    }

//                    int num = int.Parse(houses[i, j]);
//                    int count = 0;
//                    Check(houses, ref count, i, j, H, W);
//                    if (count >= num)
//                    {
//                        temp[i, j] = "#";
//                    }
//                }

//            }
//            Array.Copy(temp, houses, temp.Length);
//            ans++;

//            //これ以上広まらないなら
//            for (int i = 0; i < H; i++)
//            {
//                for (int j = 0; j < W; j++)
//                {
//                    if (houses[i, j] != copy[i, j])
//                    {
//                        goto notyet2;
//                    }
//                }
//                if (i == H - 1)
//                {
//                    isNo = true;
//                }
//            }
//            if (isNo)
//            {
//                break;
//            }
//        notyet2:;
//            Array.Copy(houses, copy, houses.Length);
//        }

//        if (isNo)
//        {
//            Console.WriteLine("No");

//        }
//        else
//        {
//            Console.WriteLine(ans);
//        }
//    }

//    static void Check(string[,] houses, ref int count, int i, int j, int H, int W)
//    {
//        if (i - 1 >= 0)
//        {
//            if (houses[i - 1, j] == "#")
//            {
//                count++;
//            }
//        }
//        if (i + 1 < H)
//        {
//            if (houses[i + 1, j] == "#")
//            {
//                count++;
//            }
//        }
//        if (j - 1 >= 0)
//        {
//            if (houses[i, j - 1] == "#")
//            {
//                count++;
//            }
//        }
//        if (j + 1 < W)
//        {
//            if (houses[i, j + 1] == "#")
//            {
//                count++;
//            }
//        }

//    }
//}