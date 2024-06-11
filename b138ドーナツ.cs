//using System;

//class Program
//{
//    static void Main()
//    {
//        string[] inputs = Console.ReadLine().Split(' ');
//        int H = int.Parse(inputs[0]);
//        int W = int.Parse(inputs[1]);
//        string[,] geoglyph = new string[H, W];
//        for (int i = 0; i < H; i++)
//        {
//            string input = Console.ReadLine();
//            for (int j = 0; j < W; j++)
//            {
//                geoglyph[i, j] = input[j].ToString();
//            }
//        }

//        int ans = 0;
//        int[,] checker = { { -1, -1 }, { -1, 0 }, { -1, 1 },
//                            { 0, -1 },             { 0, 1 },
//                            { 1, -1 }, { 1, 0 }, { 1, 1 } };
//        for (int i = 1; i < H - 1; i++)
//        {
//            for (int j = 1; j < W - 1; j++)
//            {
//                //ドーナツの中心をi,j
//                if (geoglyph[i, j] != ".")
//                {
//                    continue;
//                }

//                for (int k = 0; k < 8; k++)
//                {
//                    int di = checker[k, 0];
//                    int dj = checker[k, 1];

//                    if (geoglyph[i + di, j + dj] != "#")
//                    {
//                        break;
//                    }
//                    if (k == 7)
//                    {
//                        ans++;

//                    }

//                }

//            }
//        }

//        Console.WriteLine(ans);
//    }
//}
