//using System;

//class Program
//{
//    static void Main()
//    {
//        string[] inputs = Console.ReadLine().Split(' ');
//        int H = int.Parse(inputs[0]);
//        int W = int.Parse(inputs[1]);
//        string[,] cage = new string[H, W];
//        for (int i = 0; i < H; i++)
//        {
//            string input = Console.ReadLine();
//            for (int j = 0; j < W; j++)
//            {
//                cage[i, j] = input[j].ToString();
//            }
//        }
//        int N = int.Parse(Console.ReadLine());
//        int[,] bait = new int[N, 2];
//        for (int i = 0; i < N; i++)
//        {
//            inputs = Console.ReadLine().Split(' ');
//            bait[i, 0] = int.Parse(inputs[0]) - 1;
//            bait[i, 1] = int.Parse(inputs[1]) - 1;
//        }

//        int ans_count = 0;
//        if (Check(0, 0, bait, N))
//        {
//            ans_count++;
//        }
//        int x = 0;
//        int y = 0;
//        cage[y, x] = "X";
//        string[,] cage_copy = new string[H, W];
//        Array.Copy(cage, cage_copy, cage.Length);
//        while (true)
//        {
//            if (y - 1 >= 0 && cage[y - 1, x] == "#")
//            {
//                y--;
//                cage[y, x] = "X";
//                if (Check(y, x, bait, N))
//                {
//                    ans_count++;
//                }
//            }
//            else if (y + 1 < H && cage[y + 1, x] == "#")
//            {
//                y++;
//                cage[y, x] = "X";
//                if (Check(y, x, bait, N))
//                {
//                    ans_count++;
//                }
//            }
//            else if (x + 1 < W && cage[y, x + 1] == "#")
//            {
//                x++;
//                cage[y, x] = "X";
//                if (Check(y, x, bait, N))
//                {
//                    ans_count++;
//                }
//            }
//            else if (x - 1 >= 0 && cage[y, x - 1] == "#")
//            {
//                x--;
//                cage[y, x] = "X";
//                if (Check(y, x, bait, N))
//                {
//                    ans_count++;
//                }
//            }
//            else if (x == 0 && y == 0)
//            {
//                break;
//            }
//            else
//            {
//                cage_copy[y, x] = ".";
//                x = 0;
//                y = 0;
//                Array.Copy(cage_copy, cage, cage.Length);
//            }
//        }

//        if (ans_count == N)
//        {
//            Console.WriteLine("YES");
//        }
//        else
//        {
//            Console.WriteLine("NO");
//        }
//    }

//    static bool Check(int y, int x, int[,] bait, int N)
//    {
//        for (int i = 0; i < N; i++)
//        {
//            if (bait[i, 0] == y && bait[i, 1] == x)
//            {
//                bait[i, 0] = -1;
//                bait[i, 1] = -1;
//                return true;
//            }
//        }
//        return false;
//    }
//}
