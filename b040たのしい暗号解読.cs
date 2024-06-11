//using System;
//using System.Collections.Generic;
//using System.Linq;
//class Program
//{
//    static void Main()
//    {
//        string[] datas = Console.ReadLine().Split(' ');
//        int n = int.Parse(datas[0]);
//        string T = datas[1];
//        string ex = "abcdefghijklmnopqrstuvwxyz";

//        string cipher = Console.ReadLine();

//        for (int N = 0; N < n; N++)
//        {
//            for (int i = 0; i < cipher.Length; i++)
//            {
//                if (cipher[i] != ' ')
//                {
//                    for (int j = 0; j < T.Length; j++)
//                    {
//                        if (T[j] == cipher[i])
//                        {
//                            cipher = cipher.Remove(i, 1).Insert(i, ex[j].ToString());
//                            break;
//                        }
//                    }
//                }
//            }
//        }

//        Console.WriteLine(cipher);
//    }
//}

