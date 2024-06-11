//using System;
//using System.Collections.Generic;
//using System.Linq;
//class Program
//{
//    static void Main()
//    {
//        //車の数
//        int n = int.Parse(Console.ReadLine());

//        int answer = 0;

//        int[,] cars = new int[n, 2];
//        for (int i = 0; i < n; i++)
//        {
//            cars[i, 0] = int.Parse(Console.ReadLine());

//        }

//        int exit = 1;
//        int check = 0;

//        do
//        {
//            if (cars[check, 0] != exit)
//            {
//                cars[check, 1]++;
//            }
//            //車が出るとき
//            else
//            {
//                exit++;
//            }
//            check++;
//            if (check == n)
//            {
//                check = 0;
//            }
//        } while (exit <= n);


//        for (int i = 0; i < n; i++)
//        {
//            if (cars[i, 1] > answer)
//            {
//                answer = cars[i, 1];
//            }
//        }
//        Console.WriteLine(answer);
//    }
//}

