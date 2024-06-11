//using System;

//class Program
//{
//    static void Main()
//    {
//        char winner = 'D';
//        char[,] board = new char[5, 5];

//        for (int i = 0; i < 5; i++)
//        {
//            string data = Console.ReadLine();
//            for(int j = 0; j < 5; j++)
//            {
//                board[i, j] = data[j];
//            }
//        }
//        //横
//        for(int i = 0; i < 5; i++)
//        {
//            int rowCount = 0;
//            for(int j = 0; j +1 < 5; j++)
//            {
//                if(board[i, j] == board[i, j + 1])
//                {
//                    rowCount++;
//                }
//            }
//            if(rowCount == 4)
//            {
//                winner = board[i, 0];
//            }
//        }
//        //縦
//        for(int j =0; j < 5; j++)
//        {
//            int columnCount = 0;
//            for(int i =0; i+1 < 5; i++)
//            {
//                if (board[i, j] == board[i+1, j])
//                {
//                    columnCount++;
//                }
//            }
//            if (columnCount == 4)
//            {
//                winner = board[0, j];
//            }
//        }
//        //斜め1
//        int count1 = 0;
//        for (int k = 0; k+1 < 5; k++)
//        {
//            if (board[k, k] == board[k + 1, k+1])
//            {
//                count1++;
//            }        
//        }
//        if(count1 == 4)
//        {
//            winner = board[0,0];
//        }
//        //斜め2
//        int count2 = 0;
//        for (int k = 0; k + 1 < 5; k++)
//        {
//            if (board[4-k, k] == board[4 - k - 1, k + 1])
//            {
//                count2++;
//            }
//        }
//        if (count2 == 4)
//        {
//            winner = board[0, 0];
//        }
//        //'.'が5つ並んでいたとき
//        if(winner == '.')
//        {
//            winner = 'D';
//        }

//        Console.WriteLine(winner);
//    }
//}