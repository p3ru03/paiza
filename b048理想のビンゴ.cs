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
//        int[,] bingo = new int[N, N];
//        for (int i = 0; i < N; i++)
//        {
//            datas = Console.ReadLine().Split(' ');
//            for (int j = 0; j < N; j++)
//            {
//                bingo[i, j] = int.Parse(datas[j]);
//            }
//        }
//        int[] opens = new int[M - 1];
//        for (int i = 0; i < M - 1; i++)
//        {
//            opens[i] = int.Parse(Console.ReadLine());
//        }

//        //M-1までオープン
//        bool[,] isOpens = new bool[N, N];
//        for (int k = 0; k < M - 1; k++)
//        {
//            for (int i = 0; i < N; i++)
//            {
//                for (int j = 0; j < N; j++)
//                {
//                    if (opens[k] == bingo[i, j])
//                    {
//                        isOpens[i, j] = true;
//                    }
//                }
//            }
//        }
//        int max = 0;
//        for (int i = 0; i < N; i++)
//        {
//            for (int j = 0; j < N; j++)
//            {
//                //まだあいていないところを探す
//                if (!isOpens[i, j])
//                {
//                    //試しにあける
//                    isOpens[i, j] = true;
//                    int mcount = 0;
//                    //横チェック
//                    for (int i2 = 0; i2 < N; i2++)
//                    {
//                        int j2 = 0;
//                        int bcount = 0;
//                        do
//                        {
//                            if (isOpens[i2, j2])
//                            {
//                                bcount++;
//                            }
//                            //あいてないか，ビンゴしたら抜ける
//                            if (!isOpens[i2, j2] || bcount == N)
//                            {
//                                if (bcount == N)
//                                {
//                                    mcount++;
//                                }
//                                break;
//                            }
//                            j2++;
//                        } while (true);

//                    }
//                    //縦チェック
//                    for (int j2 = 0; j2 < N; j2++)
//                    {
//                        int i2 = 0;
//                        int bcount = 0;
//                        do
//                        {
//                            if (isOpens[i2, j2])
//                            {
//                                bcount++;
//                            }
//                            //あいてないか，ビンゴしたら抜ける
//                            if (!isOpens[i2, j2] || bcount == N)
//                            {
//                                if (bcount == N)
//                                {
//                                    mcount++;
//                                }
//                                break;
//                            }
//                            i2++;
//                        } while (true);
//                    }
//                    //斜めチェック1
//                    for (int n = 0; n < N; n++)
//                    {
//                        if (!isOpens[n, n])
//                        {
//                            break;
//                        }
//                        else
//                        {
//                            if (n == N - 1)
//                            {
//                                mcount++;
//                            }
//                        }

//                    }
//                    //斜めチェック2
//                    for (int n = 0; n < N; n++)
//                    {
//                        if (!isOpens[N - 1 - n, n])
//                        {
//                            break;
//                        }
//                        else
//                        {
//                            if (n == N - 1)
//                            {
//                                mcount++;
//                            }
//                        }
//                    }
//                    //最大値を更新
//                    max = Math.Max(max, mcount);
//                    //元に戻す
//                    isOpens[i, j] = false;
//                }
//            }
//        }
//        Console.WriteLine(max);
//    }
//}