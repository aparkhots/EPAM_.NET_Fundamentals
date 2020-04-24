using System;

namespace lab9_interfaces
{
    interface IConvertible
    {
        string ConvertToCSharp(string s);
        string ConvertToVB(string s);
    }

    interface ICodeChecker
    {
        bool CheckCodeSyntax(string str, string lang);
    }

    class ProgramConverter : IConvertible
    {
        public string ConvertToCSharp(string s)
        {
            if (s== "Dim x As Integer")
            {
                return "int x";
            }
            if(s== "Dim x As Long")
            {
                return "long x";
            }
            else
            {
                return "Not a code";
            }

        }

        public string ConvertToVB(string s)
        {
            if (s == "int x")
            {
                return "Dim x As Integer";
            }
            if (s == "long x")
            {
                return "Dim x As Long";
            }
            else
            {
                return  "Not a code";
            }
        }
    }

    class ProgramHelper : ProgramConverter, ICodeChecker
    {
        public bool CheckCodeSyntax(string str, string lang)
        {
            if ((str == "Dim x As Integer" || str == "Dim x As Long") && lang == "C#")
            {
                return true;
            }
            if((str== "int x"|| str == "long x")&& lang=="VB")
            {
                return true;
            }
            else return false;
        }
    }



    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose language:\n1.C#\n2.VB");
            int x= Convert.ToInt32(Console.ReadLine());
            string lan;
            if (x == 1)
            {
                lan = "C#";
            }
            else
            {
                lan = "VB";
            }
            Console.WriteLine("Enter code to translate");
            string code = Convert.ToString(Console.ReadLine());

            ProgramConverter[] arr = new ProgramConverter[5];
            for (int i = 0; i < 5; i++)
            {

                if(i%2==0)
                {
                    arr[i] = new ProgramHelper();
                }
                else
                {
                    arr[i] = new ProgramConverter();
                }



                if (arr[i]is ICodeChecker)
                {
                    Console.WriteLine($"Принадлежит интерфейсу {i}");
                    ProgramHelper ch = new ProgramHelper();
                    if(ch.CheckCodeSyntax(code, lan))
                    {
                        if(lan=="C#")
                        {
                            Console.WriteLine(ch.ConvertToCSharp(code));
                        }
                        else
                        {
                            Console.WriteLine(ch.ConvertToVB(code));
                        }
                    }
                }
                else
                {
                    Console.WriteLine($"Не принадлежит интерфейсу {i}");
                    if (lan == "C#")
                    {
                        Console.WriteLine(arr[i].ConvertToCSharp(code));
                    }
                    else
                    {
                        Console.WriteLine(arr[i].ConvertToVB(code));
                    }
                }
            }
        }
    }
}