//using System;
//class Program
//{
//    static void Main()
//    {
//        //空間の大きさ
//        string[] scale = Console.ReadLine().Trim().Split(' ');
//        int h = int.Parse(scale[0]);
//        int w = int.Parse(scale[1]);

//        string ans = null;

//        //初期座標
//        int sr = 0;
//        int sc = 0;

//        int r = 0;
//        int c = 0;

//        //データを格納
//        char[,] pillars = new char[h, w];
//        for (int i = 0; i < h; i++)
//        {
//            string data = Console.ReadLine();
//            for (int j = 0; j < w; j++)
//            {
//                //文字列のj番目の文字を読み取る
//                pillars[i, j] = data[j];
//                //スタート地点を記録
//                if (data[j] == 'S')
//                {
//                    sr = r = i;
//                    sc = c = j;
//                }
//            }
//        }

//        do
//        {
//            //端に'S'のとき
//            if (r == 0 || r == h - 1 || c == 0 || c == w - 1)
//            {
//                if (pillars[r, c] == 'S')
//                {
//                    ans = "YES";
//                    break;
//                }
//            }
//            //端に行ったとき
//            if (r == 0 || r == h - 1 || c == 0 || c == w - 1)
//            {
//                //脱出
//                if (pillars[r, c] == '.')
//                {
//                    ans = "YES";
//                    break;
//                }
//                else
//                {
//                    for (int i = 0; i < h; i++)
//                    {
//                        for (int j = 0; j < w; j++)
//                        {
//                            //'X'は通ったとこ
//                            if (pillars[i, j] == 'X')
//                            {
//                                pillars[i, j] = '.';
//                            }
//                        }
//                    }
//                    //'Y'は二度と通らないとこ
//                    pillars[r, c] = 'Y';
//                    r = sr;
//                    c = sc;
//                }
//            }
//            //下に移動
//            if (pillars[r + 1, c] == '.')
//            {
//                pillars[r, c] = 'X';
//                r = r + 1;
//            }
//            //上に移動
//            else if (pillars[r - 1, c] == '.')
//            {
//                pillars[r, c] = 'X';
//                r = r - 1;
//            }
//            //右に移動
//            else if (pillars[r, c + 1] == '.')
//            {
//                pillars[r, c] = 'X';
//                c = c + 1;
//            }
//            //左に移動
//            else if (pillars[r, c - 1] == '.')
//            {
//                pillars[r, c] = 'X';
//                c = c - 1;
//            }
//            //どこにも動けないとき
//            else
//            {
//                for (int i = 0; i < h; i++)
//                {
//                    for (int j = 0; j < w; j++)
//                    {
//                        if (pillars[i, j] == 'X')
//                        {
//                            pillars[i, j] = '.';
//                        }
//                    }
//                }
//                pillars[r, c] = 'Y';
//                r = sr;
//                c = sc;
//            }
//            //どのルートも無理だったとき(初期位置が'Y'になっている)
//            if (pillars[sr, sc] == 'Y')
//            {
//                ans = "NO";
//            }
//        } while (ans == null);

//        Console.WriteLine(ans);
//    }
//}