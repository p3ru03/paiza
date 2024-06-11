//using System;
//using System.Linq;
//using System.Collections.Generic;
//using System.Globalization;
//public class Member
//{
//    public int Id { get; set; }
//    public string Mes { get; set; }
//}
//class Program
//{
//    static void Main()
//    {
//        string[] datas = Console.ReadLine().Split(' ');
//        int n = int.Parse(datas[0]);
//        int g = int.Parse(datas[1]);
//        int m = int.Parse(datas[2]);

//        int[,] group = new int[g, n];
//        for (int i = 0; i < g; i++)
//        {
//            datas = Console.ReadLine().Split(' ');
//            for (int j = 0; j < int.Parse(datas[0]); j++)
//            {
//                group[i, j] = int.Parse(datas[j + 1]);
//            }
//        }

//        List<Member> Group = new List<Member>();
//        for (int i = 0; i < m; i++)
//        {
//            datas = Console.ReadLine().Split(' ');
//            //個別送信
//            if (int.Parse(datas[1]) == 0)
//            {
//                Member mem = new Member();
//                mem.Id = int.Parse(datas[0]);
//                mem.Mes = datas[3];
//                Group.Add(mem);

//                mem = new Member();
//                mem.Id = int.Parse(datas[2]);
//                mem.Mes = datas[3];
//                Group.Add(mem);
//            }
//            //グループ送信
//            else if (int.Parse(datas[1]) == 1)
//            {
//                for (int j = 0; j < n; j++)
//                {
//                    int id = group[int.Parse(datas[2]) - 1, j];
//                    if (id == 0)
//                    {
//                        break;
//                    }
//                    Member mem = new Member();
//                    mem.Id = id;
//                    mem.Mes = datas[3];
//                    Group.Add(mem);
//                }
//            }
//        }

//        //出力
//        for (int i = 1; i <= n; i++)
//        {
//            foreach (var x in Group)
//            {
//                if (x.Id == i)
//                {
//                    Console.WriteLine(x.Mes);
//                }
//            }
//            if (i != n)
//            {
//                Console.WriteLine("--");
//            }
//        }
//    }

//}
