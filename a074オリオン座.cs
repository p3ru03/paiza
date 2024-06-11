//using System;
//class Program
//{
//    static void Main()
//    {
//        //空の大きさ
//        string[] scale = Console.ReadLine().Trim().Split(' ');
//        int h = int.Parse(scale[0]);
//        int w = int.Parse(scale[1]);

//        long ans = 0;

//        //星を格納
//        char[,] stars = new char[h, w];
//        for (int i = 0; i < h; i++)
//        {
//            string data = Console.ReadLine();
//            for (int j = 0; j < w; j++)
//            {
//                //文字列のj番目の文字を読み取る
//                stars[i, j] = data[j];
//            }
//        }

//        for (int i = 1; i < h - 1; i++)
//        {
//            for (int j = 1; j < w - 3; j++)
//            {
//                int a = 0;
//                int b = 0;
//                int c = 0;
//                int d = 0;

//                //星が3つ並んでいたら
//                if (stars[i, j] == '*' && stars[i, j + 1] == '*' && stars[i, j + 2] == '*')
//                {
//                    //左上
//                    for (int ra = 0; ra < i; ra++)
//                    {
//                        for (int ca = 0; ca < j; ca++)
//                        {
//                            if (stars[ra, ca] == '*')
//                            {
//                                a++;
//                            }
//                        }
//                    }
//                    //右上
//                    for (int rb = 0; rb < i; rb++)
//                    {
//                        for (int cb = j + 3; cb < w; cb++)
//                        {
//                            if (stars[rb, cb] == '*')
//                            {
//                                b++;
//                            }
//                        }
//                    }
//                    //左下
//                    for (int rc = i + 1; rc < h; rc++)
//                    {
//                        for (int cc = 0; cc < j; cc++)
//                        {
//                            if (stars[rc, cc] == '*')
//                            {
//                                c++;
//                            }
//                        }
//                    }
//                    //右下
//                    for (int rd = i + 1; rd < h; rd++)
//                    {
//                        for (int cd = j + 3; cd < w; cd++)
//                        {
//                            if (stars[rd, cd] == '*')
//                            {
//                                d++;
//                            }
//                        }
//                    }
//                    ans += (long)a * b * c * d;
//                }
//            }
//        }
//        Console.WriteLine(ans);
//    }
//}

