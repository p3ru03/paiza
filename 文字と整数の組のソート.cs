//using System;
//using System.Collections.Generic;
//using System.Linq;

//public class Member
//{
//    public int D { get; set; }
//    public string S { get; set; }
//}

//class Program
//{
//    static void Main()
//    {
//        int n = int.Parse(Console.ReadLine());
//        List<Member> Group = new List<Member>();

//        for (int i = 0; i < n; i++)
//        {
//            Member m = new Member();
//            string[] data = Console.ReadLine().Split(' ');
//            m.S = data[0];
//            m.D = int.Parse(data[1]);
//            Group.Add(m);
//        }

//        Group = Group.OrderBy(x => x.D).ToList();

//        foreach (var i in Group)
//        {
//            Console.WriteLine(i.S);
//        }
//    }
//}



