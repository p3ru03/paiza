//using System;
//using System.Linq;
//using System.Collections.Generic;
//using System.Globalization;
//class Program
//{
//    static void Main()
//    {
//        int N = int.Parse(Console.ReadLine());
//        int[,] task = new int[N, 3];
//        for (int i = 0; i < N; i++)
//        {
//            string[] datas = Console.ReadLine().Split(' ');
//            for (int j = 0; j < 3; j++)
//            {
//                task[i, j] = int.Parse(datas[j]);
//            }
//        }

//        string ans = "YES";
//        int count = 0;
//        int nowday = 0;
//        while (true)
//        {
//            nowday++;
//            int nowtask = int.MaxValue;
//            for (int i = 0; i < N; i++)
//            {
//                //今日できるタスクを見つける
//                if (nowday >= task[i, 1] && task[i, 0] > 0)
//                {
//                    //優先度を比較
//                    nowtask = Math.Min(nowtask, i);
//                }
//            }

//            //今できるタスクがないとき
//            if (nowtask == int.MaxValue)
//            {
//                continue;
//            }

//            task[nowtask, 0]--;
//            //タスクが終了したとき
//            if (task[nowtask, 0] == 0)
//            {
//                //期限を過ぎていたら
//                if (task[nowtask, 2] < nowday)
//                {
//                    ans = "NO";
//                    break;
//                }

//                count++;
//                //全タスクが終了したら
//                if (count == N)
//                {
//                    break;
//                }
//            }
//        }
//        Console.WriteLine(ans);
//    }
//}


