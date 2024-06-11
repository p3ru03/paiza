//using System;
//class Program
//{
//    static void Main()
//    {
//        string[] datas = Console.ReadLine().Split(' ');
//        int H = int.Parse(datas[0]);
//        int W = int.Parse(datas[1]);

//        char[,] room = new char[H, W];
//        for (int i = 0; i < H; i++)
//        {
//            string data = Console.ReadLine();
//            for (int j = 0; j < W; j++)
//            {
//                room[i, j] = data[j];
//            }
//        }

//        for (int i = 0; i < H; i++)
//        {
//            for (int j = 0; j < W; j++)
//            {
//                int power = 0;
//                //爆弾を見つけたら
//                if (int.TryParse(room[i, j].ToString(), out power))
//                {
//                    int up = 1;
//                    int down = 1;
//                    int left = 1;
//                    int right = 1;
//                    int count = 0;
//                    int checker = 0;
//                    do
//                    {
//                        //上方向の爆破
//                        if (room[i - up, j] != '#')
//                        {
//                            //爆弾じゃないなら
//                            if (!int.TryParse(room[i - up, j].ToString(), out checker))
//                            {
//                                room[i - up, j] = 'R';
//                            }
//                            up++;
//                        }
//                        //下方向の爆破
//                        if (room[i + down, j] != '#')
//                        {
//                            if (!int.TryParse(room[i + down, j].ToString(), out checker))
//                            {
//                                room[i + down, j] = 'R';
//                            }
//                            down++;
//                        }
//                        //左方向の爆破
//                        if (room[i, j - left] != '#')
//                        {
//                            if (!int.TryParse(room[i, j - left].ToString(), out checker))
//                            {
//                                room[i, j - left] = 'R';
//                            }
//                            left++;
//                        }
//                        //右方向の爆破
//                        if (room[i, j + right] != '#')
//                        {
//                            if (!int.TryParse(room[i, j + right].ToString(), out checker))
//                            {
//                                room[i, j + right] = 'R';
//                            }
//                            right++;
//                        }

//                        count++;
//                        if (count == power)
//                        {
//                            break;
//                        }
//                    } while (true);
//                }
//            }
//        }

//        string ans = "YES";
//        for (int i = 0; i < H; i++)
//        {
//            for (int j = 0; j < W; j++)
//            {
//                //敵が残っていれば
//                if (room[i, j] == 'X')
//                {
//                    ans = "NO";
//                }
//            }
//        }
//        Console.WriteLine(ans);
//    }
//}
