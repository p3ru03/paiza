//using System;
//class Program
//{
//    static void Main()
//    {
//        string n = Console.ReadLine();

//        int ans = 0;

//        //データを格納
//        int[,] points = new int[int.Parse(n), 2];
//        for (int i = 0; i < int.Parse(n); i++)
//        {
//            string[] data = Console.ReadLine().Split(' ');
//            for (int j = 0; j < 2; j++)
//            {
//                //文字列のj番目の文字を読み取る
//                points[i, j] = int.Parse(data[j]);
//            }
//        }

//        for (int i = 0; i < int.Parse(n); i++)
//        {
//            if( points[i, 0] == points[i, 1])
//            {
//                ans += points[i, 0] * points[i, 1];
//            }
//            else
//            {
//                ans += points[i, 0] + points[i, 1];
//            }
//        }


//        Console.WriteLine(ans);
//    }
//}
