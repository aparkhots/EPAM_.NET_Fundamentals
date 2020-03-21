using System;
using System.Collections.Generic;

namespace Exam1
{
    class Program
    {
        static void Main(string[] args)
        {
               Console.WriteLine("Enter your number: ");
               int changeNum = Convert.ToInt32(Console.ReadLine());
               Console.WriteLine("Number {0} in 2system is ", changeNum);
               Sys2.Change(changeNum);
               Sys2.MyChange(changeNum);
               Console.ReadKey();
           }
       }
    class Sys2
    {
        public static void Change(int a)
        {
            string str = Convert.ToString(a, 2);
            Console.WriteLine(str);
        }
        public static void MyChange(int a)
        {
            string str1 = "1";
            if (a == 0) str1 = "0";
            if (a > 1)
            {
                string str2 = "";
                while (a != 1)
                {
                    if (a % 2 == 0) str2 += 0;
                    else str2 += 1;
                    a /= 2;
                }
                for (int j = str2.Length - 1; j >= 0; j--)
                {
                    str1 += str2[j];
                }
            }
            Console.Write("My method: {0}", str1);
        }
    }
}
