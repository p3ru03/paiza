//using System;
//class Program
//{
//    static void Main()
//    {
//        string[] datas = Console.ReadLine().Split(' ');
//        int N = int.Parse(datas[0]);
//        int M = int.Parse(datas[1]);

//        char[,] board = new char[N, N];
//        for (int i = 0; i < N; i++)
//        {
//            string data = Console.ReadLine();
//            for (int j = 0; j < N; j++)
//            {
//                board[i, j] = data[j];
//            }
//        }

//        string[] words = new string[M];
//        for (int i = 0; i < M; i++)
//        {
//            words[i] = Console.ReadLine();
//        }

//        int[,] ans = new int[M, 2];
//        //m番目の単語を探す
//        for (int m = 0; m < M; m++)
//        {
//            for (int i = 0; i < N; i++)
//            {
//                for (int j = 0; j < N; j++)
//                {
//                    //最初の文字が一致していたら
//                    if (board[i, j] == words[m][0])
//                    {
//                        int i2 = i;
//                        int j2 = j;
//                        int count = 0;
//                        while (i2 < N && j2 < N)
//                        {
//                            if (board[i2, j2] == words[m][count])
//                            {
//                                count++;
//                                i2++;
//                                j2++;
//                            }
//                            else
//                            {
//                                break;
//                            }
//                            if (count == words[m].Length)
//                            {
//                                ans[m, 0] = j + 1;
//                                ans[m, 1] = i + 1;
//                                break;
//                            }
//                        }
//                    }
//                }
//            }
//        }

//        for (int i = 0; i < M; i++)
//        {
//            Console.WriteLine(ans[i, 0] + " " + ans[i, 1]);
//        }
//    }
//}
