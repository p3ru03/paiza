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
//                //�����ł���^�X�N��������
//                if (nowday >= task[i, 1] && task[i, 0] > 0)
//                {
//                    //�D��x���r
//                    nowtask = Math.Min(nowtask, i);
//                }
//            }

//            //���ł���^�X�N���Ȃ��Ƃ�
//            if (nowtask == int.MaxValue)
//            {
//                continue;
//            }

//            task[nowtask, 0]--;
//            //�^�X�N���I�������Ƃ�
//            if (task[nowtask, 0] == 0)
//            {
//                //�������߂��Ă�����
//                if (task[nowtask, 2] < nowday)
//                {
//                    ans = "NO";
//                    break;
//                }

//                count++;
//                //�S�^�X�N���I��������
//                if (count == N)
//                {
//                    break;
//                }
//            }
//        }
//        Console.WriteLine(ans);
//    }
//}


