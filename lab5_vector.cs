using System;

namespace lab5_vector
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter size of array: ");
            int N = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter array: ");
            int[] count = new int[N];
            char[] delimit = new char[] { ' ' };
            int i = 0, minValue, maxValue;
            bool flag = false;
            string arr = Convert.ToString(Console.ReadLine());
            foreach (string numbers in arr.Split(delimit))
            {
                if (i < N)
                {
                    count[i] = Convert.ToInt32(numbers);
                    i++;
                }
            }
            if (i == N)
            {
                Console.Write("Your correct array: ");

                for (int j = 0; j < i; j++)
                {
                    Console.Write($"{count[j]} ");
                }

                for (int k = 0; k < N; k++)
                {
                    if (count[k] > 0)
                    {
                        i = k;
                        flag = true;
                        break;
                    }
                }

                if (flag)
                {
                    minValue = maxValue = count[i];
                    for (int j = 0; j < N; j++)
                    {
                        if (count[j] > 0)
                        {
                            if (count[j] < minValue) minValue = count[j];
                            if (count[j] > maxValue) maxValue = count[j];
                        }
                    }
                    Console.WriteLine($"\nMinimum length: {maxValue - minValue}");
                }
                else Console.WriteLine("\nNot positive numbers");
            }
            else Console.WriteLine("Incorrect array");
        }
    }
}
