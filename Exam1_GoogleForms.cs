using System;
using System.IO;

namespace Exam1_GoogleForms
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] del1 = new char[] { ',', ' ' };
            string arr;
            int i = 0;
            Console.WriteLine("How read coordinates? Cosole(c) or file(f)?");
            char coor = Convert.ToChar(Console.ReadLine());
            if (coor == 'c')
            {
                Console.WriteLine("Count of pairs: ");
                int n = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter array: ");
                arr =Convert.ToString(Console.ReadLine());
                
                string[] pairXY = new string[n * 2];
                foreach (string pairs in arr.Split(del1))
                {
                    pairXY[i] = pairs;
                    i++;
                }
                Show(pairXY);
                Correct(pairXY);
                Show(pairXY);
            }
            if (coor == 'f')
            {
                string path = @"text.txt";
                string path2 = @"text2.txt";
                arr=File.ReadAllText(path);
                string[] pairXY = new string[arr.Length];
                StreamWriter file2 = new StreamWriter(path2);
                foreach (string pairs in arr.Split(del1))
                {
                    pairXY[i] = pairs;
                    if (i % 2 == 0) file2.Write($"X: {pairXY[i]}, ");
                    else file2.Write($"Y: {pairXY[i]}\n");
                    i++;
                }
                Correct(pairXY);
                Saving(pairXY, file2);
            }
        }

        public static void Show(string[] XY)
        {
            int j = 0;
            foreach (string numers in XY)
            {
                if (j % 2 == 0)
                {
                    Console.Write($"X:{numers} ");
                }
                else Console.Write($"Y:{numers}\n");
                j++;
            }
        }
        public static void Correct(string[] XY)
        {
            Console.WriteLine("Do you want to correct? yes/no: ");
            string s = Console.ReadLine();
            if (s == "yes")
            {
                Console.WriteLine("Сhoose pair: ");
                int k = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Change X: ");
                XY[(k * 2) - 2] = Console.ReadLine();
                Console.WriteLine("Сhange Y: ");
                XY[(k * 2) - 1] = Console.ReadLine();
            }
            if (s == "no")
            {
                Console.WriteLine("That's all");
            }
        }
        public static void Saving(string[] XY, StreamWriter file)
        {
            int k = 0;
            foreach (string pairs in XY)
            {
                XY[k] = pairs;
                if (k % 2 == 0) file.Write($"X: {XY[k]}, ");
                else file.Write($"Y: {XY[k]}\n");
                k++;
            }
            file.Close();
        }
    }
}
            //23.8976,12.3218 25.76,11.9463 24.8293,12.2

