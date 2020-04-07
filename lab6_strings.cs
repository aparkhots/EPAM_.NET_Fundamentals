using System;
using System.IO;

namespace lab6_strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"inletin.txt";
            string path2 = @"outletout.txt";
            char[] del1 = new char[] { ' ', '\r' };
            char[] del2 = new char[] { '\n' };
            try
            {
                FileStream Creater = new FileStream(path, FileMode.Open);
                Creater.Close();
            }
            catch (FileNotFoundException)
            {
                StreamWriter Creater = new StreamWriter(path);
                Console.WriteLine("Not found file. Generate new file with a text");
                Creater.Write("bag rama can sugar\ndog big night ge in\nfree cat soon\nplus house yep\n3");
                Creater.Close();
            }
            string arr = File.ReadAllText(path);
            int k = Convert.ToInt32(arr[arr.Length - 1] - 48);
            Console.WriteLine(k);
            Console.ReadKey();
            StreamWriter file2 = new StreamWriter(path2);
            foreach (string str in arr.Split(del2))
            {
                bool i = false;
                foreach (string words in str.Split(del1))
                {
                    if (words.Length <= k)
                    {
                        Console.WriteLine(words);
                        file2.Write($"{words} ");
                        i = true;
                    }
                }
                if (i) file2.WriteLine();
            }
            file2.Close();
        }
    }
}