//using System;
//using System.Linq;
//using System.Collections.Generic;
//class Program
//{
//    static void Main()
//    {
//        string[] datas = Console.ReadLine().Split(' ');
//        double h = double.Parse(datas[0]);
//        double s = double.Parse(datas[1]);
//        double θ = double.Parse(datas[2]);

//        datas = Console.ReadLine().Split(' ');
//        double x = double.Parse(datas[0]);
//        double y = double.Parse(datas[1]);
//        double a = double.Parse(datas[2]);

//        //矢の位置
//        double arrow = h + x * Math.Tan(θ * (Math.PI / 180))
//            - 9.8 * x * x / 2 / s / s / Math.Pow(Math.Cos(θ * (Math.PI / 180)), 2);

//        string ans = "Miss";
//        if (arrow >= y - a / 2 && arrow <= y + a / 2)
//        {
//            ans = "Hit";
//            Console.WriteLine(ans + " " + (Math.Abs(arrow - y)).ToString("0.0"));

//        }
//        else
//        {
//            Console.WriteLine(ans);
//        }
//    }
//}
