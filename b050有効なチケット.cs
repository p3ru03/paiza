//using System;
//using System.Linq;
//using System.Collections.Generic;
//using System.Globalization;
//class Program
//{
//    static void Main()
//    {
//        int N = int.Parse(Console.ReadLine());
//        string S = Console.ReadLine();

//        string[] ticket = new string[N];
//        for (int i = 0; i < N; i++)
//        {
//            ticket[i] = Console.ReadLine();
//        }

//        string[] ans = new string[N];
//        //i�Ԗڂ̃`�P�b�g���݂�
//        for (int i = 0; i < N; i++)
//        {
//            int nowS = 0;
//            int back = 0;
//            bool isCheck = false;
//            ans[i] = "invalid";
//            for (int j = 0; j < ticket[i].Length; j++)
//            {
//                //��v
//                if (ticket[i][j] == S[nowS])
//                {
//                    nowS++;
//                }
//                //��ڂ̗]�v�ȕ���
//                else if (nowS != 0 && !isCheck)
//                {
//                    back = j - 1;
//                    isCheck = true;
//                }
//                //��ڂ̗]�v�ȕ���
//                else if (nowS != 0 && isCheck)
//                {
//                    //��ڂ̗]�v�ȕ����̂Ƃ�����T������
//                    j = back;
//                    nowS = 0;
//                    isCheck = false;
//                }

//                if (nowS == S.Length)
//                {
//                    ans[i] = "valid";
//                    break;
//                }
//            }
//        }

//        for (int i = 0; i < N; i++)
//        {
//            Console.WriteLine(ans[i]);
//        }
//    }
//}


