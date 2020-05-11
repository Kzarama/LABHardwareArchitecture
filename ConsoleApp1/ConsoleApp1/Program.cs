using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ConsoleAppWeek13
{
    class ProgramLabSem13_gr103
    {
        public static void Main(string[] args)
        {
            try
            {
                StreamWriter sw = new
                StreamWriter(@"C:\Users\kz\Documents\git\LABHardwareArchitecture\ConsoleApp1\TimeSem13_1000local.txt");

                int n = 3000;
                //int[,] matriz = new int[n, n]; //para MultIntvarGlobal()
                for (int i = 0; i < 100; i++)
                {
                    //sw.WriteLine(MultIntvarGlobal(matriz,n)); //variable global
                    sw.WriteLine(MultIntvarLocal()); //variable local
                }
                sw.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
        }
        public static double MultIntvarGlobal(int[,] matriz, int n)
        {
            int mul = 1;
            Stopwatch sw = new Stopwatch();
            sw.Restart();
            sw.Start();
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(0); j++)
                {
                    mul *= matriz[j, i];
                }
            }
            sw.Stop();
            long tiempo = (long)(sw.Elapsed.TotalMilliseconds * 1000000);
            return tiempo;
        }
        public static double MultIntvarLocal()
        {
            int n = 1000; //<--defina aquí el tamaño de la matriz
            int[,] matriz = new int[n, n];
            int mul = 1;
            Stopwatch sw = new Stopwatch();
            sw.Restart();
            sw.Start();
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(0); j++)
                {
                    mul *= matriz[j,i];
                }
            }
            sw.Stop();
            long tiempo = (long)(sw.Elapsed.TotalMilliseconds * 1000000);
            return tiempo; // Math.Pow(n, 2);
        }
    }
}