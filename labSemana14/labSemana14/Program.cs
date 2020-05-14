using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeLabSem14
{
    class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                int n = 1000;
                    int[,] A = new int[n, n];
                    //int[,] A = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
                    int[,] B = new int[n, n];
                    //int[,] B = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
                    int[,] C = new int[n, n];

                    for (int i = 0; i < 3; i++)
                    {
                        Algorithm3(n, A, B, C);
                    }

                /*foreach (int n in sizes)
                {
                    int[,] A = new int[n, n];
                    //int[,] A = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
                    int[,] B = new int[n, n];
                    //int[,] B = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
                    int[,] C = new int[n, n];

                    for (int i = 0; i < 3; i++)
                    {
                        Algorithm2(n, A, B, C);
                    }
                }

                foreach (int n in sizes)
                {
                    int[,] A = new int[n, n];
                    //int[,] A = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
                    int[,] B = new int[n, n];
                    //int[,] B = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
                    int[,] C = new int[n, n];

                    for (int i = 0; i < 3; i++)
                    {
                        Algorithm3(n, A, B, C);
                    }
                }*/
                //String wait = Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
        }

        public static void Algorithm1(int n, int[,] A, int[,] B, int[,] C)
        {
            int sum = 0;
            long tiempo = 0;
            //versión 1
            Stopwatch timeA = new Stopwatch();
            timeA.Restart();
            timeA.Start();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    sum = 0;
                    for (int k = 0; k < n; k++)
                    {
                        sum += A[i, k] * B[k, j];
                    }
                    C[i, j] += sum;
                }
            }

            timeA.Stop();

            tiempo = (long)(timeA.Elapsed.TotalMilliseconds * 1000000); //*1000000 ns; *1000 us
            Console.WriteLine(tiempo);
        }

        public static void Algorithm2(int n, int[,] A, int[,] B, int[,] C)
        {
            int sum = 0;
            long tiempo = 0;
            int r = 0;
            //versión 1
            Stopwatch timeA = new Stopwatch();
            timeA.Restart();
            timeA.Start();

            for (int k = 0; k < n; k++)
            {
                for (int i = 0; i < n; i++)
                {
                    r = A[i, k];
                    for (int j = 0; j < n; j++)
                    {
                        C[i, j] += r * B[k, j];
                    }
                }
            }
            timeA.Stop();

            tiempo = (long)(timeA.Elapsed.TotalMilliseconds * 1000000); //*1000000 ns; *1000 us
            Console.WriteLine(tiempo);
        }

        public static void Algorithm3(int n, int[,] A, int[,] B, int[,] C)
        {
            int sum = 0;
            long tiempo = 0;
            int r = 0;
            //versión 1
            Stopwatch timeA = new Stopwatch();
            timeA.Restart();
            timeA.Start();

            for (int j = 0; j < n; j++)
            {
                for (int k = 0; k < n; k++)
                {
                    r = B[k, j];
                    for (int i = 0; i < n; i++)
                    {
                        C[i, j] += A[i, k] * r;
                    }
                }
            }

            timeA.Stop();

            tiempo = (long)(timeA.Elapsed.TotalMilliseconds * 1000000); //*1000000 ns; *1000 us
            Console.WriteLine(tiempo);
        }

    }
}