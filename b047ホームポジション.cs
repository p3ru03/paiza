//using System;
//using System.Linq;
//using System.Collections.Generic;
//using System.Globalization;
//class Program
//{
//    static void Main()
//    {
//        string S = Console.ReadLine();
//        int miss = 0;

//        string[,] keyboard = { { "q", "w", "e", "r", "t", "y", "u", "i", "o", "p" },
//                               {"a", "s", "d", "f", "g", "h", "j", "k", "l", "-1" } ,
//                               {"z", "x", "c", "v", "b", "n", "m", "-1", "-1", "-1" } };
//        string hand = null;
//        int icopy = -100;
//        int jcopy = -100;
//        bool missed = false;

//        for (int i = 0; i < S.Length; i++)
//        {
//            //�^�C�v����L�[
//            string input = S[i].ToString();
//            //���O�Ɠ����^�C�s���O
//            if (i > 0 && input == S[i - 1].ToString())
//            {
//                if (missed)
//                {
//                    miss++;
//                }
//                continue;
//            }

//            bool found = false;
//            for (int i2 = 0; i2 < 3; i2++)
//            {
//                //���������甲����
//                if (found)
//                {
//                    break;
//                }

//                for (int j = 0; j < 10; j++)
//                {
//                    if (keyboard[i2, j] == input)
//                    {
//                        //���O�Ɨאڂ����^�C�s���O
//                        if ((i2 == icopy - 1 && j == jcopy) ||
//                            (i2 == icopy && j == jcopy + 1) ||
//                            (i2 == icopy + 1 && j == jcopy) ||
//                            (i2 == icopy && j == jcopy - 1))
//                        {
//                            if (hand == "right")
//                            {
//                                if (j < 5)
//                                {
//                                    miss++;
//                                    missed = true;
//                                }
//                                else
//                                {
//                                    missed = false;
//                                }
//                            }
//                            else
//                            {
//                                if (j > 4)
//                                {
//                                    miss++;
//                                    missed = true;
//                                }
//                                else
//                                {
//                                    missed = false;
//                                }
//                            }
//                        }
//                        else
//                        {
//                            missed = false;
//                            //��̍X�V
//                            if (j > 4)
//                            {
//                                hand = "right";
//                            }
//                            else
//                            {
//                                hand = "left";
//                            }
//                        }

//                        icopy = i2;
//                        jcopy = j;

//                        found = true;
//                        break;
//                    }
//                }
//            }
//        }
//        Console.WriteLine(miss);
//    }
//}


