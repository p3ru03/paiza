//using System;

//class Program
//{
//    static void Main()
//    {
//        string[] DataCount = Console.ReadLine().Trim().Split(' ');

//        int dc1 = int.Parse(DataCount[0]);
//        int dc2 = int.Parse(DataCount[1]);

//        int[,] Fee = new int[dc1, dc2];

//        int sum = 0;

//        //現在地
//        int now = 0;

//        //料金を格納
//        for (int i = 0; i < dc1; i++)
//        {
//            string[] sFee = Console.ReadLine().Trim().Split(' ');
//            for(int j = 0; j < dc2; j++)
//            {
//                Fee[i,j] = int.Parse(sFee[j]);
//            }
//        }

//        //ゴールまでに経由すべき駅の数を表す整数 
//        int x = int.Parse(Console.ReadLine());

//        //料金計算
//        for (int i = 0; i < x; i++)
//        {
//            //目的地
//            string[] sRoot = Console.ReadLine().Trim().Split(' ');
//            //スタート時は呼ばない
//            if (now != 0)
//                now--;

//            sum += Math.Abs(Fee[int.Parse(sRoot[0]) - 1, int.Parse(sRoot[1]) - 1] - Fee[int.Parse(sRoot[0]) - 1, now]);

//            //現在地の更新
//            now = int.Parse(sRoot[1]);
//        }

//        Console.WriteLine(sum);
//    }

//}
