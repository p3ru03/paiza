//using System;
//using System.Linq;
//using System.Collections.Generic;
//using System.Globalization;
//class Program
//{
//    static void Main()
//    {
//        string[] datas = Console.ReadLine().Split(' ');
//        int N = int.Parse(datas[0]);
//        int M = int.Parse(datas[1]);

//        int[] times = new int[N];
//        for (int i = 0; i < N; i++)
//        {
//            times[i] = int.Parse(Console.ReadLine());
//        }

//        int ans = 0;
//        int[] processing = new int[N];
//        for (int t = 0; t < int.MaxValue; t++)
//        {
//            //�J�E���^�[�ւ̊���U��
//            int min = checkMin(times, processing);
//            int x = 0;
//            while (true)
//            {
//                if (M == 0 || min == int.MaxValue)
//                {
//                    break;
//                }
//                if (times[x] == min && processing[x] == 0)
//                {
//                    processing[x] += times[x];
//                    min = checkMin(times, processing);
//                    x = -1;
//                    M--;
//                }
//                x++;
//            }
//            //���Ԍo��
//            int count = 0;
//            for (int i = 0; i < N; i++)
//            {
//                if (processing[i] > 0)
//                {
//                    processing[i]--;
//                }
//                else if (processing[i] == 0)
//                {
//                    count++;
//                }
//            }
//            //�S�����I�������
//            if (M == 0 && count == N)
//            {
//                ans = t;
//                break;
//            }
//        }
//        Console.WriteLine(ans);
//    }

//    //�������Ԃ̒Z���J�E���^�[��������
//    static int checkMin(int[] times, int[] processing)
//    {
//        int min = int.MaxValue;
//        for (int i = 0; i < times.Length; i++)
//        {
//            if (processing[i] == 0)
//            {
//                min = Math.Min(min, times[i]);
//            }
//        }
//        return min;
//    }
//}


