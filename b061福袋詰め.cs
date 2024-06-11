//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Security.Cryptography;

//class Program
//{
//    static void Main()
//    {
//        //自分の得意な言語で
//        //Let's チャレンジ！！
//        int S = int.Parse(Console.ReadLine());
//        int N = int.Parse(Console.ReadLine());
//        List<int> V = new List<int>();
//        int ans = 0;

//        for (int v = 0; v < N; v++)
//        {
//            V.Add(int.Parse(Console.ReadLine()));
//        }
//        V.Sort();

//        //絶対にv番目の商品は追加するとする
//        for (int v = 0; v < N; v++)
//        {
//            //一つの商品でS以上ならば条件を絶対に満たす
//            if (V[v] >= S)
//            {
//                ans++;
//            }
//            //S未満ならv番目以外の商品も追加する
//            else
//            {
//                ans += CalCombination(V, v + 1, V[v], S, v);
//            }
//        }
//        Console.WriteLine(ans);
//    }

//    static int CalCombination(List<int> V, int start, int value, int S, int realStart)
//    {
//        int ans = 0;

//        //商品を追加する
//        for (int v = start; v < V.Count; v++)
//        {
//            //v番目の商品を追加
//            value += V[v];

//            //S以上ならば
//            if (value >= S)
//            {
//                //過剰の条件も満たすならば
//                if (value - V[realStart] < S)
//                {
//                    //OK
//                    ans++;
//                }

//                //v番目の商品を追加した組合せはもう探索しないので消しておく
//                value -= V[v];
//            }

//            //S未満ならばさらに商品を追加していく
//            else
//            {
//                //再帰呼び出しして一つずつ追加する
//                ans += CalCombination(V, v + 1, value, S, realStart);

//                //vの商品を追加した場合の組合せは全て探索したので消す
//                value -= V[v];
//            }
//        }
//        return ans;
//    }
//}
