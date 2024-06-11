//using System;
//using System.Linq;
//class Program
//{
//    static void Main()
//    {
//        string[] datas = Console.ReadLine().Split(' ');
//        string a = null;
//        for (int i = 0; i < 7; i++)
//        {
//            a += datas[i];
//        }
//        datas = Console.ReadLine().Split(' ');
//        string b = null;
//        for (int i = 0; i < 7; i++)
//        {
//            b += datas[i];
//        }

//        string[] tmp = { "1111110", "0110000", "1101101", "1111001", "0110011",
//            "1011011", "1011111", "1110010", "1111111", "1111011" };

//        string ans1 = "No";
//        if (tmp.Contains(a) && tmp.Contains(b))
//        {
//            ans1 = "Yes";
//        }
        
//        string ans2 = "No";
//        string a2 = null;
//        string b2 = null;
//        int[] symmetry = { 0, 5, 4, 3, 2, 1, 6 };
//        //対称移動
//        for (int i = 0; i < 7; i++)
//        {
//            a2 += b[symmetry[i]];
//            b2 += a[symmetry[i]];
//        }
//        if (tmp.Contains(a2) && tmp.Contains(b2))
//        {
//            ans2 = "Yes";
//        }

//        string ans3 = "No";
//        string a3 = null;
//        string b3 = null;
//        int[] rotate = { 3, 4, 5, 0, 1, 2, 6 };
//        //回転移動
//        for (int i = 0; i < 7; i++)
//        {
//            a3 += b[rotate[i]];
//            b3 += a[rotate[i]];
//        }
//        if (tmp.Contains(a3) && tmp.Contains(b3))
//        {
//            ans3 = "Yes";
//        }

//        Console.WriteLine(ans1);
//        Console.WriteLine(ans2);
//        Console.WriteLine(ans3);
//    }
//}
