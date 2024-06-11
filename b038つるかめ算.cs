//using System;
//using System.Text;
//using System.Collections.Generic;
//using System.Linq;
//class Program
//{
//    static void Main()
//    {
//        string[] datas = Console.ReadLine().Split(' ');
//        int sumleg = int.Parse(datas[0]);
//        int sumhead = int.Parse(datas[1]);
//        int craneleg = int.Parse(datas[2]);
//        int turtleleg = int.Parse(datas[3]);

//        int crane;
//        int turtle;

//        if (craneleg == turtleleg)
//        {
//            if (sumhead == 2)
//            {
//                Console.WriteLine(1 + " " + 1);
//            }
//            else
//            {
//                Console.WriteLine("miss");
//            }
//        }
//        else
//        {
//            if ((sumleg - craneleg * sumhead) % (turtleleg - craneleg) == 0)
//            {
//                turtle = (sumleg - craneleg * sumhead) / (turtleleg - craneleg);
//                crane = sumhead - turtle;
//                //鶴か亀のどちらも1匹以上
//                if (crane >= 1 && turtle >= 1)
//                {
//                    Console.WriteLine(crane + " " + turtle);
//                }
//                else
//                {
//                    Console.WriteLine("miss");
//                }
//            }
//            //亀が整数にならない
//            else
//            {
//                Console.WriteLine("miss");
//            }

//        }
//    }
//}