//using System;
//using System.Text;
//class Program
//{
//    static void Main()
//    {
//        string[] datas = Console.ReadLine().Split(' ');
//        int a = int.Parse(datas[0]);
//        int b = int.Parse(datas[1]);
//        int n = int.Parse(datas[2]);

//        datas = Console.ReadLine().Split(' ');
//        int[] pins = new int[n];
//        for (int i = 0; i < n; i++)
//        {
//            if (datas[i] == "G")
//            {
//                datas[i] = "0";
//            }
//            pins[i] = int.Parse(datas[i]);
//        }

//        int[] point = new int[a];
//        int flame = 0;
//        int now = 0;
//        string[] storsp = new string[a];
//        bool stst = false;
//        while (flame != a)
//        {
//            point[flame] += pins[now];
//            if (flame >= 1)
//            {
//                if (storsp[flame - 1] == "st" || storsp[flame - 1] == "sp")
//                {
//                    point[flame - 1] += pins[now];
//                }
//                if (stst)
//                {
//                    point[flame - 2] += pins[now];
//                    stst = false;
//                }
//            }
//            //ストライク
//            if (point[flame] == b)
//            {
//                storsp[flame] = "st";
//                //連続ストライク
//                if (flame >= 1)
//                {
//                    if (storsp[flame - 1] == "st")
//                    {
//                        stst = true;
//                    }
//                }
//                //最終フレーム
//                if (flame == a - 1)
//                {
//                    now++;
//                    point[flame] += 2 * pins[now];
//                    if (stst)
//                    {
//                        point[flame - 1] += pins[now];
//                    }
//                    //さらにスペア
//                    if (pins[now] == b)
//                    {
//                        now++;
//                        point[flame] += 3 * pins[now];
//                    }
//                    else
//                    {
//                        now++;
//                        point[flame] += 2 * pins[now];
//                    }
//                }
//            }
//            else
//            {
//                now++;
//                point[flame] += pins[now];
//                if (flame >= 1)
//                {
//                    if (storsp[flame - 1] == "st")
//                    {
//                        point[flame - 1] += pins[now];
//                    }
//                }
//                //スペア
//                if (point[flame] == b)
//                {
//                    storsp[flame] = "sp";
//                    //最終フレームなら
//                    if (flame == a - 1)
//                    {
//                        now++;
//                        point[flame] += 2 * pins[now];
//                    }
//                }
//            }
//            flame++;
//            now++;
//        }

//        int sum = 0;
//        for (int i = 0; i < a; i++)
//        {
//            sum += point[i];
//        }
//        Console.WriteLine(sum);
//    }
//}