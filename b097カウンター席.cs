//using System;
//using System.Text;
//using System.Collections.Generic;
//using System.Linq;
//class Program
//{
//    static void Main()
//    {
//        int N = int.Parse(Console.ReadLine());
//        int M = int.Parse(Console.ReadLine());

//        int[][] groups = new int[M][];
//        for (int i = 0; i < M; i++)
//        {
//            string[] datas = Console.ReadLine().Split(' ');
//            groups[i] = new int[int.Parse(datas[0])];
//            for (int j = 0; j < int.Parse(datas[0]); j++)
//            {
//                groups[i][j] = int.Parse(datas[j + 1]);
//            }
//        }

//        int ans = 0;
//        int[] counter = new int[N];
//        for (int g = 0; g < M; g++)
//        {
//            //必要な席を数える
//            int needseats = groups[g].Length;
//            bool isOpen = false;

//            //空いてる席の左端を決める
//            for (int i = 0; i < N; i++)
//            {
//                if (isOpen)
//                {
//                    break;
//                }
//                if (counter[i] != 0)
//                {
//                    continue;
//                }
//                //空いてる席を数える
//                int seatscount = 1;
//                for (int i2 = i + 1; i2 < N; i2++)
//                {
//                    if (counter[i2] != 0)
//                    {
//                        break;
//                    }
//                    seatscount++;
//                }
//                //席に座らせる
//                if (seatscount >= needseats)
//                {
//                    isOpen = true;
//                    for (int i3 = i; i3 < i + needseats; i3++)
//                    {
//                        counter[i3] = groups[g][i3 - i];
//                    }
//                }
//            }
//            //座れる席がない
//            if (!isOpen)
//            {
//                Eating(counter);
//                ans++;
//                g--;
//            }
//        }
//        //全員が食べ終わるまで待つ
//        while (true)
//        {
//            int zerocount = 0;
//            for (int i = 0; i < counter.Length; i++)
//            {
//                if (counter[i] == 0)
//                {
//                    zerocount++;
//                }
//            }
//            if (zerocount == N)
//            {
//                break;
//            }
//            Eating(counter);
//            ans++;
//        }
//        Console.WriteLine(ans);
//    }

//    static void Eating(int[] counter)
//    {
//        for (int i = 0; i < counter.Length; i++)
//        {
//            if (counter[i] > 0)
//            {
//                counter[i]--;
//            }
//        }
//    }
//}