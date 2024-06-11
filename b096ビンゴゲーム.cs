//using System;
//using System.Linq;
//class Program
//{
//    bool[,] isOpen = new bool[4, 4];
//    static void Main()
//    {
//        Program obj = new Program();
//        int N = int.Parse(Console.ReadLine());
//        int[,] bingo = new int[4, 4];
//        for (int i = 0; i < 4; i++)
//        {
//            string[] datas = Console.ReadLine().Split(' ');
//            for (int j = 0; j < 4; j++)
//            {
//                bingo[i, j] = int.Parse(datas[j]);
//            }
//        }

//        for (int n = 0; n < N; n++)
//        {
//            int open = int.Parse(Console.ReadLine());
//            for (int i = 0; i < 4; i++)
//            {
//                for (int j = 0; j < 4; j++)
//                {
//                    if (open == bingo[i, j])
//                    {
//                        obj.isOpen[i, j] = true;
//                    }
//                }
//            }
//        }

//        int fbingo = obj.bingoCheck();

//        string ans = "no";
//        bool found = false;
//        for (int i = 0; i < 4; ++i)
//        {
//            for (int j = 0; j < 4; j++)
//            {
//                if (!found && !obj.isOpen[i, j])
//                {
//                    obj.isOpen[i, j] = true;
//                    int sbingo = obj.bingoCheck();

//                    //ビンゴが増えていたら
//                    if (sbingo > fbingo)
//                    {
//                        ans = bingo[i, j].ToString();
//                        found = true;
//                    }
//                    obj.isOpen[i, j] = false;
//                }
//            }
//        }
//        Console.WriteLine(ans);
//    }

//    int bingoCheck()
//    {
//        int bingoCount = 0;
//        //行チェック
//        for (int i = 0; i < 4; i++)
//        {
//            int count = 0;
//            for (int j = 0; j < 4; j++)
//            {
//                if (this.isOpen[i, j])
//                {
//                    count++;
//                }
//            }
//            if (count == 4)
//            {
//                bingoCount++;
//            }
//        }
//        //列チェック
//        for (int j = 0; j < 4; j++)
//        {
//            int count = 0;
//            for (int i = 0; i < 4; i++)
//            {
//                if (this.isOpen[i, j])
//                {
//                    count++;
//                }
//            }
//            if (count == 4)
//            {
//                bingoCount++;
//            }
//        }
//        //斜めチェック
//        if (this.isOpen[0, 0] && this.isOpen[1, 1] && this.isOpen[2, 2] && this.isOpen[3, 3])
//        {
//            bingoCount++;
//        }
//        if (this.isOpen[0, 3] && this.isOpen[1, 2] && this.isOpen[2, 1] && this.isOpen[3, 0])
//        {
//            bingoCount++;
//        }

//        return bingoCount;
//    }
//}
