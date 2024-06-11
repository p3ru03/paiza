//using System;
//using System.Text;
//using System.Collections.Generic;
//using System.Linq;
//class Program
//{
//    private class Student
//    {
//        public string name { get; set; }
//        public int height { get; set; }
//        public int born { get; set; }

//        public Student(string Name, int Height, int Born)
//        {
//            name = Name;
//            height = Height;
//            born = Born;
//        }
//    }

//    static void Main()
//    {
//        int N = int.Parse(Console.ReadLine());

//        var list = new List<Student>();

//        for (int i = 0; i < N; i++)
//        {
//            string[] datas = Console.ReadLine().Split(' ');
//            list.Add(new Student(datas[0], int.Parse(datas[1]), int.Parse(datas[2])));
//        }

//        foreach (Student student in list.OrderBy(x => x.height).ThenByDescending(x => x.born).ThenBy(x => x.name))
//        {
//            Console.WriteLine(student.name);
//        }

//    }
//}