using System;

class Program
{
    static void Main()
    {
        string[] inputs = Console.ReadLine().Split(' ');
        int L = int.Parse(inputs[0]);
        int N = int.Parse(inputs[1]);
        int M = int.Parse(inputs[2]);

        inputs = Console.ReadLine().Split(' ');
        int[,] seats = new int[N, 2];
        for (int i = 0; i < N; i++)
        {
            seats[i, 0] = int.Parse(inputs[i]);
        }
        inputs = Console.ReadLine().Split(' ');
        int[] sushi = new int[M];
        for (int i = 0; i < M; i++)
        {
            sushi[i] = int.Parse(inputs[i]);
        }

        int t = 0;
        bool sushiOut = false;
        while (true)
        {
            //席にあれば食べる．
            for (int i = 0; i < N; i++)
            {
                int index = Array.IndexOf(sushi, seats[i, 0]);
                if (index == -1 || seats[i, 1] > 0)
                {
                    continue;
                }
                seats[i, 1] = 10;
                sushi[index] = -1;
            }

            t++;
            if (sushiOut)
            {
                goto next;
            }
            int count = 0;
            for (int i = 0; i < M; i++)
            {
                if (sushi[i] == -1)
                {
                    count++;
                    continue;
                }
                sushi[i]++;
                if (sushi[i] == L)
                {
                    sushi[i] = 0;
                }
            }
            if (count == M)
            {
                sushiOut = true;
            }
        next:;
            for (int i = 0; i < N; i++)
            {
                if (seats[i, 1] > 0)
                {
                    seats[i, 1]--;

                }
            }
            //寿司もなく全員食べ終わったら
            if (sushiOut)
            {
                for (int i = 0; i < N; i++)
                {
                    if (seats[i, 1] > 0)
                    {
                        break;
                    }
                    goto end;
                }
            }

        }
    end:;
        Console.WriteLine(t);
    }
}
