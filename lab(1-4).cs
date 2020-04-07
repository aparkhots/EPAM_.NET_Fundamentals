using System;

namespace lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Variant 12\nChoose task(1-4): ");
            int task = Convert.ToInt32(Console.ReadLine());
            switch (task)
            {
                case 1:
                    ////////// task 1 //////

                    Console.WriteLine("Enter a: ");
                    int num1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter b: ");
                    int num2 = Convert.ToInt32(Console.ReadLine());
                    int res = num1 * num2;
                    Console.WriteLine("(a*b)^2 = {0}", res * res);
                    break;

                case 2:
                    ////////// task 2 ///////факториал

                    Console.WriteLine("Enter count of term: ");
                    int n = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter variable x: ");
                    int x = Convert.ToInt32(Console.ReadLine());
                    double result = 1;
                    double count = 1;
                    for (int j = 0; j < n; j++)
                    {
                        count *= (Math.Pow(2 * x, 2) / (((2 * j) + 1) * ((2 * j) + 2)));//рекуррентный метод
                        if (j % 2 == 0) result -= count;
                        else result += count;
                    }
                    Console.Write(result);
                    Console.ReadKey();
                    break;

                case 3:
                    ////////// task 3 ///////

                    float a = -4.5f;
                    float b = -3.5f;
                    float c;
                    while (b - a > 0.01f)
                    {
                        c = (a + b) / 2;
                        if ((c + 4) * (Math.Exp(c) - Math.Exp(-c)) == 18)
                        {
                            a = c;
                            b = c;
                        }
                        else
                        {
                            if ((((a + 4) * (Math.Exp(a) - Math.Exp(-a))) - 18) * ((c + 4) * (Math.Exp(c) - Math.Exp(-c)) - 18) < 0) b = c;
                            else a = c;
                        }
                    }
                    float x1 = (a + b) / 2;
                    Console.WriteLine("Корень уравнения равен: {0}", x1);
                    break;


                case 4:
                    //////////task4/////////

                    Console.WriteLine("Enter x: ");
                    float x2 = (float)Convert.ToDouble(Console.ReadLine());// ввод х
                    Console.WriteLine("Enter epsilon: ");
                    float epsilon = (float)Convert.ToDouble(Console.ReadLine());// epsilon, меньше которого выражение быть не может
                    int myFact, i;
                    myFact = 1;
                    i = 1;
                    double sum = 1;
                    bool flag = true;
                    while (flag)
                    {
                        if (((float)(Math.Cos(i * x2) / myFact)) > epsilon)
                        { 
                            sum += Math.Cos(i * x2) / myFact;
                            Console.WriteLine("{0}", Math.Cos(i * x2) / myFact);
                            Console.WriteLine("{0}, {1}, {2}\v", myFact, Math.Cos(i * x2), sum);
                            i++;
                            myFact *= i;
                        }
                        else flag = false;
                    }
                    break;
            }
            Console.ReadKey();
        }
    }
}
