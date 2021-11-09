using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Введіть висоту и ширину матриці: ");

                int size1 = Convert.ToInt32(Console.ReadLine());
                int size2 = Convert.ToInt32(Console.ReadLine());
                int[,] massive = new int[size1, size2];

                MatrixFirst matrixFirst = new MatrixFirst(size1, size2, massive, "Одинична матриця");
                matrixFirst.Matrix1();
                Console.Write("\n");
                MartixSecond martixSecond = new MartixSecond(size1, size2, massive, "Верхня трикутна матриця");
                martixSecond.Matrix2();
            }
            catch
            {
                Console.WriteLine("З'явилось виключення");
            }

            Console.ReadKey();
        }
    }
    public class Matrix
    {
        public int Size1 { get; set; }
        public int Size2 { get; set; }
        public int[,] AMatrix { get; set; }

        public Matrix(int s1, int s2, int[,] matrix)
        {
            this.Size1 = s1;
            this.Size2 = s2;
            this.AMatrix = matrix;
        }

        public virtual void Matrix1()
        {
            int firstarg = AMatrix.GetLength(0);
            int secondarg = AMatrix.GetLength(1);
            for (int i = 0; i < firstarg; i++)
            {
                for (int j = 0; j < secondarg; j++)
                {
                    if (i == j)
                    {
                        AMatrix[i, j] = 1;
                    }
                    else
                    {
                        AMatrix[i, j] = 0;
                    }

                    Console.Write(AMatrix[i, j] + "\t");
                }
                Console.Write("\n");
            }
        }
        public virtual void Matrix2()
        {
            int firstarg = AMatrix.GetLength(0);
            int secondarg = AMatrix.GetLength(1);
            for (int i = 0; i < firstarg; i++)
            {
                for (int j = 0; j < secondarg; j++)
                {
                    AMatrix[i, j] = 1;
                }
            }
            for (int i = 0; i < firstarg; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < secondarg; j++)
                {

                    if (i <= j)
                        Console.Write(AMatrix[i, j] + "\t");
                    else
                        Console.Write("0\t");
                }
            }
        }
    }
    class MatrixFirst : Matrix
    {
        public string MName { get; set; }
        public MatrixFirst(int s1, int s2, int[,] matrix, string mname)
            : base(s1, s2, matrix)
        {
            this.MName = mname;
        }

        public override void Matrix1()
        {
            Console.WriteLine($"Matrix name = {MName}");
            base.Matrix1();
        }
    }
    class MartixSecond : Matrix
    {
        public string MName { get; set; }
        public MartixSecond(int s1, int s2, int[,] matrix, string mname)
            : base(s1, s2, matrix)
        {
            this.MName = mname;
        }
        public override void Matrix2()
        {
            Console.WriteLine($"Matrix name = {MName}");
            base.Matrix2();
        }
    }
}
