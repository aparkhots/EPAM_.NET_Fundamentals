using System;

namespace lab7_exceptions
{
    class Matrix
    {
        public int i1, j1, i2,j2;

        public int[,] CreateMatrix(int i, int j)
        {
            Random rnd = new Random();
            int[,] matrix = new int[i, j];

            for (int k = 0; k < i; k++)
            {
                for (int m = 0; m < j; m++)
                {
                    matrix[k, m] = rnd.Next(6);
                }
            }
            return matrix;
        }


        public int[,] SumMatrix(int[,] mat1, int[,] mat2)
        {
            Console.WriteLine("Sum of matrices:");
            int[,] mat3 = new int[i1, j1];
            try
            {
                if (i1 == i2 && j1 == j2)
                {
                    for (int k = 0; k < i1; k++)
                    {
                        for (int m = 0; m < j1; m++)
                        {
                            mat3[k, m] = mat1[k, m] + mat2[k, m];
                            //Console.Write($"\t{mat1[k, m]} ");
                        }
                        //Console.WriteLine();
                    }
                    return mat3;
                }
                else throw new Exception("Error");
            }
            catch (Exception)
            {
                Console.WriteLine($"\nThis action is impossible with these matrices\nYour matrices are {i1}x{j1} and {i2}x{j2}");
                return EmptyMatrix(i1, j1);
            }
        }


        public int[,] DiffMatrix(int[,] mat1, int[,] mat2)
        {
            Console.WriteLine("Diff of matrices:");
            int[,] mat3 = new int[i1, j1];
            try
            {
                if (i1 == i2 && j1 == j2)
                {
                    for (int k = 0; k < i1; k++)
                    {
                        for (int m = 0; m < j1; m++)
                        {
                            mat3[k, m] = mat1[k, m] - mat2[k, m];
                            //Console.Write($"\t{mat1[k, m]} ");
                        }
                        //Console.WriteLine();
                    }
                    return mat3;
                }
                else throw new Exception("Error");
            }
            catch (Exception)
            {
                Console.WriteLine($"\nThis action is impossible with these matrices\nYour matrices are {i1}x{j1} and {i2}x{j2}");
                return EmptyMatrix(i1, j1);
            }
        }


        public static int[,] EmptyMatrix(int i, int j)
        {
            int[,] mat3 = new int[i, j];
            for (int k = 0; k < i; k++)
            {
                for (int m = 0; m < j; m++)
                {
                    mat3[k, m] = 0;
                }
            }
            return mat3;
        }

        public int[,] MultiplicationMatrix(int[,] mat1, int[,] mat2)
        {
            Console.WriteLine("Multiplication: ");
            int[,] mat3 = new int[i1, j2];
            try
            {
                if (j2 == i1)
                {
                    for (int k = 0; k < i1; k++)
                    {
                        for (int l = 0; l < j2; l++)
                        {
                            for (int n = 0; n < i2; n++)
                            {
                                mat3[k, l] += mat1[k, n] * mat2[n, l];
                            }
                        }
                    }
                    return mat3;
                }
                else throw new Exception("Error");
            }
            catch(Exception)
            {
                Console.WriteLine($"\nThis action is impossible with these matrices\nYour matrices are {i1}x{j1} and {i2}x{j2}");
                return EmptyMatrix(i1, j2);
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int i1=0, j1=0, i2=0, j2=0;
            byte s = 1;
            while (s!=0)
            {
                try
                {
                    Console.Write("Enter size of 1st matrix: ");
                    i1 = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();
                    Console.Write($"Enter size of 1st matrix: {i1} x ");
                    j1 = Convert.ToInt32(Console.ReadLine());
                    Console.Write($"Enter size of 2st matrix: ");
                    i2 = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();
                    Console.Write($"Enter size of 1st matrix: {i1} x {j1}\nEnter size of 2st matrix: {i2} x ");
                    j2 = Convert.ToInt32(Console.ReadLine());
                    s=0;
                }
                catch
                {
                    Console.WriteLine("incorrect type size of matrix");
                }
            }
            Matrix matrix = new Matrix()
            {
                i1 = i1,
                i2 = i2,
                j1 = j1,
                j2 = j2
            };

            int[,] matrix1 = matrix.CreateMatrix(i1, j1);
            int[,] matrix2 = matrix.CreateMatrix(i2, j2);
            Console.WriteLine("1st matrix:");
            ToShow(matrix1, i1, j1);
            Console.WriteLine("2nd matrix:");
            ToShow(matrix2, i2, j2);
            bool flag=true;

            while (flag)
            {
                Console.WriteLine("1.sum\n2.diff\n3.empty\n4.Multiplication\n5.Exit\n");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        ToShow(matrix.SumMatrix(matrix1, matrix2), i1, j1);
                        break;
                    case 2:
                        ToShow(matrix.DiffMatrix(matrix1, matrix2), i1, j1);
                        break;
                    case 3:
                        Console.WriteLine("Which matrix make empty\n1st\n2nd\n3.Default");
                        int emptChoise = Convert.ToInt32(Console.ReadLine());
                        if (emptChoise == 1)
                        {
                            Console.WriteLine("Empty matrix:");
                            ToShow(Matrix.EmptyMatrix(i1, j1), i1, j1);
                        }
                        if (emptChoise == 2)
                        {
                            Console.WriteLine("Empty matrix:");
                            ToShow(Matrix.EmptyMatrix(i2, j2), i2, j2);
                        }
                        if (emptChoise == 3)
                        {
                            Console.WriteLine("i:");
                            int i3 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("j:");
                            int j3= Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Empty matrix:");
                            ToShow(Matrix.EmptyMatrix(i3, j3), i3, j3);
                        }
                        break;
                    case 4:
                        ToShow(matrix.MultiplicationMatrix(matrix1, matrix2), i1,j2);
                        break;
                    case 5:
                        flag = false;
                        break;
                }
            }
            Console.WriteLine("Thats all, good bye");

        }

        public static void ToShow(int[,] matrix, int i, int j)
        {
            for (int k = 0; k < i; k++)
            {
                for (int m = 0; m < j; m++)
                {
                    Console.Write($"\t{matrix[k, m]} ");
                }
                Console.WriteLine();
            }
        }

    }
}