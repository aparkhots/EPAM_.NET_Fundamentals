using System;
using System.Collections.Generic;
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
            List<string> pairXY = new List<string>();
            Console.WriteLine("How read coordinates? Cosole(c) or file(f)?");
            char coor = Convert.ToChar(Console.ReadLine());
            if (coor == 'c')
            {
                Console.WriteLine("Enter array: ");
                arr =Convert.ToString(Console.ReadLine());
                foreach (string pairs in arr.Split(del1))
                {
                    pairXY.Add(pairs);
                    i++;
                }
                Show(pairXY);
                Correct(pairXY);
                Console.WriteLine("After changes: ");
                Show(pairXY);
            }
            if (coor == 'f')
            {
                string path = @"text.txt";
                string path2 = @"text2.txt";
                try
                {
                    FileStream Creater = new FileStream(path, FileMode.Open);
                    Creater.Close();
                }
                catch(FileNotFoundException)
                {
                    StreamWriter Creater = new StreamWriter(path);
                    Console.WriteLine("Write coordinats: ");
                    string str = Console.ReadLine();
                    Creater.Write(str);
                    Creater.Close();
                }
                arr=File.ReadAllText(path); 
                StreamWriter file2 = new StreamWriter(path2);
                foreach (string pairs in arr.Split(del1))
                {
                    pairXY.Add(pairs);
                    if (i % 2 == 0) file2.Write($"X: {pairs}, ");
                    else file2.Write($"Y: {pairs}\n");
                    i++;
                }
                Correct(pairXY);
                Saving(pairXY, file2);
                file2.Close();
            }
        }

        public static void Show(List<string> XY)
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

        public static void Correct(List<string> XY)
        {
            Console.WriteLine("Do you want to correct? yes/no: ");
            string s = Console.ReadLine();
            if (s == "yes")
            {
                try
                {
                    Console.WriteLine("Сhoose pair: ");
                    int k = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Change X: ");
                    XY[(2 * k) - 2] = Console.ReadLine();
                    Console.WriteLine("Сhange Y: ");
                    XY[(k * 2) - 1] = Console.ReadLine();
                }
                catch(Exception e)
                {
                    Console.WriteLine("Wrong symbols or your pair is not available");
                }
            }
            if (s == "no")
            {
                Console.WriteLine("That's all");
            }
        }

        public static void Saving(List<string> XY, StreamWriter file)
        {
            file.WriteLine("After changes: ");
            int k = 0;
            foreach (string pairs in XY)
            {
                if (k % 2 == 0) file.Write($"X: {pairs} ");
                else file.Write($"Y: {pairs}\n");
                k++;
            }
        }
    }
}
            //23.8976,12.3218 25.76,11.9463 24.8293,12.2