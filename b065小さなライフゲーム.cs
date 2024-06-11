//using System;
//using System.Text;
//using System.Collections.Generic;
//using System.Linq;
//class Program
//{
//    static void Main()
//    {
//        string[] datas = Console.ReadLine().Split(' ');
//        string S = datas[0];
//        string T = datas[1];

//        char[] start = new char[S.Length];
//        char[] copy = new char[S.Length];
//        char[] copy2 = new char[S.Length];
//        for (int i = 0; i < S.Length; i++)
//        {
//            start[i] = S[i];
//            copy[i] = S[i];
//        }

//        var checker = new List<string>();
//        while (true)
//        {
//            //更新
//            for (int i = 0; i < S.Length; i++)
//            {
//                //左端
//                if (i == 0)
//                {
//                    if (copy[S.Length - 1] == '-')
//                    {
//                        if (copy[i + 1] == '-')
//                        {
//                            copy2[i] = T[0];
//                        }
//                        else if (copy[i + 1] == '+')
//                        {
//                            copy2[i] = T[1];
//                        }
//                    }
//                    else if (copy[S.Length - 1] == '+')
//                    {
//                        if (copy[i + 1] == '-')
//                        {
//                            copy2[i] = T[2];
//                        }
//                        else if (copy[i + 1] == '+')
//                        {
//                            copy2[i] = T[3];
//                        }
//                    }
//                }
//                //右端
//                else if (i == S.Length - 1)
//                {
//                    if (copy[i - 1] == '-')
//                    {
//                        if (copy[0] == '-')
//                        {
//                            copy2[i] = T[0];
//                        }
//                        else if (copy[0] == '+')
//                        {
//                            copy2[i] = T[1];
//                        }
//                    }
//                    else if (copy[i - 1] == '+')
//                    {
//                        if (copy[0] == '-')
//                        {
//                            copy2[i] = T[2];
//                        }
//                        else if (copy[0] == '+')
//                        {
//                            copy2[i] = T[3];
//                        }
//                    }
//                }
//                else if (copy[i - 1] == '-')
//                {
//                    if (copy[i + 1] == '-')
//                    {
//                        copy2[i] = T[0];
//                    }
//                    else if (copy[i + 1] == '+')
//                    {
//                        copy2[i] = T[1];
//                    }
//                }
//                else if (copy[i - 1] == '+')
//                {
//                    if (copy[i + 1] == '-')
//                    {
//                        copy2[i] = T[2];
//                    }
//                    else if (copy[i + 1] == '+')
//                    {
//                        copy2[i] = T[3];
//                    }
//                }
//            }
//            //コピー
//            string x = null;
//            for (int i = 0; i < copy.Length; i++)
//            {
//                copy[i] = copy2[i];
//                x += copy[i];
//            }
//            //初期に戻れた
//            if (x == S)
//            {
//                Console.WriteLine("YES");
//                break;
//            }
//            //作ったことのあるやつになった（ループするってこと）
//            else if (checker.Contains(x))
//            {
//                Console.WriteLine("NO");
//                break;
//            }
//            checker.Add(x);
//        }
//    }
//}