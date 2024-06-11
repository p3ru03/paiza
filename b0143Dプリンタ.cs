//using System;
//class Program
//{
//    static void Main()
//    {
//        string[] datas = Console.ReadLine().Split(' ');
//        int X = int.Parse(datas[0]);
//        int Y = int.Parse(datas[1]);
//        int Z = int.Parse(datas[2]);

//        char[,] input = new char[X, Y];
//        char[,] ans = new char[Z, Y];

//        for (int z = 0; z < Z; z++)
//        {
//            for (int x = 0; x < X; x++)
//            {
//                string data = Console.ReadLine();
//                for (int y = 0; y < Y; y++)
//                {
//                    input[x, y] = data[y];
//                    if (input[x, y] == '#')
//                    {
//                        ans[z, y] = '#';
//                    }
//                }
//            }
//            Console.ReadLine();
//        }
//        //Zは逆から出力
//        for (int i = Z - 1; i >= 0; i--)
//        {
//            for (int j = 0; j < Y; j++)
//            {
//                if (ans[i, j] != '#')
//                {
//                    ans[i, j] = '.';
//                }
//                Console.Write(ans[i, j]);
//            }
//            Console.WriteLine();
//        }
//    }
//}
