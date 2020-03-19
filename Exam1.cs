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
    public class Sys2
    { 
        public static void Change(int a)
        {
            string str=Convert.ToString(a, 2);
            Console.WriteLine(str);
        }
        public static void MyChange(int a)
        {
            string str1 = "1";
            if(a==0) str1 = "0"; 
            {
                List<char> zerone = new List<char>();
                int i = 0;
                while (a != 1)
                {
                    if (a % 2 == 0) zerone.Add('0');
                    else zerone.Add('1');
                    a /= 2;
                    i++;
                }
                zerone.Reverse();
                for (int j = 0; j < i; j++)
                {
                    str1 += zerone[j];
                }
            }
            Console.Write("My method: {0}", str1);
        }
    }
}
