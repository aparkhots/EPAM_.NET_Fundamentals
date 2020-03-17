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
    class Sys2 //класс перевода в двоичную систему
    {
        public static void Change(int a)
        {
            string str=Convert.ToString(a, 2);
            Console.WriteLine("Standard method: {0}", str);
        }
        public static void MyChange(int a)
        {
            List<char> zerone = new List<char>();//список 0 и 1
            int i = 0;
            do
            {
                if (a % 2 == 0) zerone.Insert(i, '0');
                else zerone.Insert(i, '1');
                a /= 2;
                i++;
            }
            while (a != 1);
            zerone.Insert(i, '1');
            zerone.Reverse();
            Console.Write("My method: ");
            for (int j=0; j<=i;j++)
            {
                Console.Write(zerone[j]);
            }
        }
    }
}