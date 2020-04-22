using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        public static void Main(string[] args)
        {

            try
            {
                StreamWriter sw = new StreamWriter(@"C:\Users\kz\Downloads\TimeMultInt1000.txt");
                int n = 1000;

                int[,] matriz = new int[n, n];

                for (int i = 0; i < 100; i++)
                {

                    sw.WriteLine(MultiplicacionInt(matriz, n));
                    //sw.WriteLine(sumaIntLocal());
                }
                sw.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }


        }

        public static double MultiplicacionInt(int[,] matriz, int n)
        {

            int Mul = 0;

            Stopwatch sw = new Stopwatch();

            sw.Restart();
            sw.Start();

            for (int i = 0; i < matriz.GetLength(0); i++)
            {

                for (int j = 0; j < matriz.GetLength(0); j++)
                {

                    Mul *= matriz[i, j];

                }

            }

            sw.Stop();

            long tiempo = (long)(sw.Elapsed.TotalMilliseconds * 1000000);

            return tiempo;
        }

    }
}

