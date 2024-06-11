//using System;

//class Program
//{
//    static void Main()
//    {

//        //仕事を受けた数 
//        int n = int.Parse(Console.ReadLine());

//        int[,] days = new int[n, 2];
        
//        //連勤数
//        int sum = 0;
//        int sumtest = 0;

//        int max = 0;       


//        //仕事の日数を格納
//        for (int i = 0; i < n; i++)
//        {
//            string[] data = Console.ReadLine().Trim().Split(' ');
//            for (int j = 0; j < 2; j++)
//            {
//                days[i, j] = int.Parse(data[j]);
//                if (days[i, j] > max)
//                {
//                    max = days[i, j];
//                }
//            }

            
//        }

//        bool[] isWork = new bool[max];
        
        
//        for (int i = 0; i < n; i++)
//        {
//            int now = days[i, 0];
//            do
//            {
//                isWork[now - 1] = true;
//                now++;
//            } while (now != days[i, 1] + 1);
//        }

//        for (int i = 0; i < isWork.Length; i++)
//        {
        
//            if (!isWork[i])
//            {
//                //最大連勤数を更新
//                if (sumtest >= sum)
//                {
//                    sum = sumtest;
//                }
//                sumtest = 0;
//            }
//            else
//                sumtest++;
//        }

//        sum = Math.Max(sumtest, sum);
        
//        Console.WriteLine(sum);
//    }

//}
