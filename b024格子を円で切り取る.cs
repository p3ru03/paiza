//using System;
//using System.Text;
//using System.Collections.Generic;
//using System.Linq;
//class Program
//{
    
//    static void Main()
//    {
//        double r = double.Parse(Console.ReadLine());;

//        int ans = 0;
//        //円の右上だけ考え，格子点を数える
//        //半径内にある格子点が左下となる四角形は塗られる
//        for (int i = 0; i < r; i++)
//        {
//            for (int j = 0; j < r; j++)
//            {
//                if (r > Math.Pow(i * i + j * j, 0.5))
//                {
//                    ans++;
//                }
//            }
//        }
//        ans *= 4;
//        Console.WriteLine(ans);
//    }
//}