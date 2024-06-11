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
//        int M = int.Parse(datas[1]);
//        string[,] field = new string[N, M];
//        for (int i = 0; i < N; i++)
//        {
//            string data = Console.ReadLine();
//            for (int j = 0; j < M; j++)
//            {
//                field[i, j] = data[j].ToString();
//            }
//        }

//        string[,] block = new string[3, 3];
//        int countmax = 0;
//        for (int i = 0; i < 3; i++)
//        {
//            string data = Console.ReadLine();
//            for (int j = 0; j < 3; j++)
//            {
//                block[i, j] = data[j].ToString();
//                if (block[i, j] == "#")
//                {
//                    countmax++;
//                }
//            }
//        }

//        string ans = "No";
//        bool isOk = false;
//        for (int r = 0; r < 4; r++)
//        {
//            //左上の位置[i,j]
//            for (int i = 0; i < N; i++)
//            {
//                for (int j = 0; j < M; j++)
//                {
//                    int count = 0;
//                    bool isOut = false;
//                    for (int i2 = 0; i2 < 3; i2++)
//                    {
//                        for (int j2 = 0; j2 < 3; j2++)
//                        {
//                            //挿入
//                            if (block[i2, j2] == "#" && i + i2 < N && j + j2 < M && field[i + i2, j + j2] == ".")
//                            {
//                                count++;
//                                if (count == countmax)
//                                {
//                                    ans = "Yes";
//                                    isOk = true;
//                                    break;
//                                }
//                            }
//                            else if (block[i2, j2] == "#")
//                            {
//                                isOut = true;
//                                break;
//                            }
//                        }
//                        if (isOut)
//                        {
//                            break;
//                        }
//                    }
//                    if (isOk)
//                    {
//                        break;
//                    }
//                }
//                if (isOk)
//                {
//                    break;
//                }
//            }
//            if (isOk)
//            {
//                break;
//            }
//            //回転
//            Rotate(block);
//        }
//        Console.WriteLine(ans);
//    }

//    static void Rotate(string[,] block)
//    {
//        string[,] copy = (string[,])block.Clone();
//        for (int i = 0; i < 3; i++)
//        {
//            for (int j = 0; j < 3; j++)
//            {
//                block[j, 2 - i] = copy[i, j];
//            }
//        }
//    }
//}