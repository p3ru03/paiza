//using System;
//using System.Text;
//class Program
//{
//    static void Main()
//    {
//        int N = int.Parse(Console.ReadLine());

//        string[] names = new string[N];
//        for (int i = 0; i < N; i++)
//        {
//            names[i] = Console.ReadLine();
//        }

//        int max = 0;
//        //i個目とj個目の名前を比べる
//        for (int i = 0; i < N; i++)
//        {
//            for (int j = i + 1; j < N; j++)
//            {
//                for (int i2 = 0; i2 < names[i].Length; i2++)
//                {
//                    for (int j2 = 0; j2 < names[j].Length; j2++)
//                    {
//                        if (names[i][i2] == names[j][j2])
//                        {
//                            int count = 0;
//                            do
//                            {
//                                count++;
//                                if (i2 + count >= names[i].Length || j2 + count >= names[j].Length)
//                                {
//                                    break;
//                                }

//                            } while (names[i][i2 + count] == names[j][j2 + count]);

//                            max = Math.Max(max, count);
//                        }
//                    }
//                }
//            }
//        }

//        Console.WriteLine(max);
//    }
//}