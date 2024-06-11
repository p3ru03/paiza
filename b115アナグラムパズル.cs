//using System;
//using System.Collections.Generic;
//using System.Linq;
//class Program
//{
//    static void Main()
//    {
//        int N = int.Parse(Console.ReadLine());

//        string[] words = new string[N];
//        for (int i = 0; i < N; i++)
//        {
//            words[i] = Console.ReadLine();
//        }

//        int answer = 0;

//        for (int i = 0; i < N; i++)
//        {
//            //使われている文字を数える
//            var counter = new Dictionary<char, int>();
//            for (int j = 0; j < words[i].Length; j++)
//            {
//                if (counter.ContainsKey(words[i][j]))
//                {
//                    counter[words[i][j]]++;
//                }
//                else
//                {
//                    counter.Add(words[i][j], 1);
//                }

//            }
//            //j番目とk番目の組み合わせを考える
//            for (int j = 0; j < N; j++)
//            {
//                for (int k = j; k < N; k++)
//                {
//                    var tester = new Dictionary<char, int>();
//                    for (int m = 0; m < words[j].Length; m++)
//                    {
//                        if (tester.ContainsKey(words[j][m]))
//                        {
//                            tester[words[j][m]]++;
//                        }
//                        else
//                        {
//                            tester.Add(words[j][m], 1);
//                        }

//                    }
//                    for (int m = 0; m < words[k].Length; m++)
//                    {
//                        if (tester.ContainsKey(words[k][m]))
//                        {
//                            tester[words[k][m]]++;
//                        }
//                        else
//                        {
//                            tester.Add(words[k][m], 1);
//                        }

//                    }
//                    if (counter.OrderBy(x => x.Key).SequenceEqual(tester.OrderBy(x => x.Key)))
//                    {
//                        answer++;
//                    }
//                }
//            }
//        }
//        Console.WriteLine(answer);
//    }
//}

