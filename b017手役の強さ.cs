//using System;
//using System.Collections.Generic;
//using System.Linq;
//class Program
//{
//    static void Main()
//    {
//        string cards = Console.ReadLine();
//        string[] hands = { "NoPair", "OnePair", "TwoPair", "ThreeCard", "FourCard" };

//        int max = 0;
//        bool isTwo = false;

//        for (int i = 0; i < cards.Length; i++)
//        {
//            int count = 0;

//            for (int j = i + 1; j < cards.Length; j++)
//            {
//                if (cards[i] == cards[j])
//                {
//                    count++;
//                }
//            }
//            if (count > max)
//            {
//                max = count;
//            }
//            //既にワンペアでもうワンペアあるとき
//            else if (count == 1 && max == 1)
//            {
//                max = 2;
//                isTwo = true;
//            }
//        }
//        //ワイルドカードが存在したら
//        if (cards.IndexOf("*") != -1)
//        {
//            max++;
//        }
//        //twopairじゃないけど自分以外で同じ数が2枚以上
//        if (!isTwo && (max == 2 || max == 3))
//        {
//            max++;
//        }

//        Console.WriteLine(hands[max]);
//    }
//}