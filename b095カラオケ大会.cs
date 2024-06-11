//using System;
//using System.Collections.Generic;
//using System.Linq;
//class Program
//{
//    static void Main()
//    {
//        string[] data = Console.ReadLine().Split(' ');

//        int n = int.Parse(data[0]);
//        int m = int.Parse(data[1]);

//        int[] answers = new int[m];
//        for (int i = 0; i < m; i++)
//        {
//            answers[i] = int.Parse(Console.ReadLine());
//        }

//        int max = 0;
//        int dif = 0;

//        for (int j = 0; j < n; j++)
//        {
//            int score = 100;

//            for (int i = 0; i < m; i++)
//            {
//                int challenge = int.Parse(Console.ReadLine());
//                dif = Math.Abs(answers[i] - challenge);
//                if (dif > 5 && dif <= 10)
//                {
//                    score -= 1;
//                }
//                else if (dif > 10 && dif <= 20)
//                {
//                    score -= 2;
//                }
//                else if (dif > 20 && dif <= 30)
//                {
//                    score -= 3;
//                }
//                else if (dif > 30)
//                {
//                    score -= 5;
//                }
//            }
//            if (score > max)
//            {
//                max = score;
//            }
//        }

//        //点数は最低0
//        if(max < 0)
//        {
//            max = 0;
//        }

//        Console.WriteLine(max);
//    }
//}

