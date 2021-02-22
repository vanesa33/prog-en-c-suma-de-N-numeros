using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace SUMA_DE_N_NÚMEROS
{
    class Program
    {
        static void Main(string[] args)
        {
            byte CAN, K;
            int NUM;
            int SUM = 0;
            string linea;
            Console.Write("LÍMITE:"); linea = Console.ReadLine();
            CAN = byte.Parse(linea);
            for (K = 1; K <= CAN; K++)
            {
                Console.Write("DIGITE UN NÚMERO:"); linea = Console.ReadLine();
                NUM = int.Parse(linea);
                SUM += NUM;
            }
            Console.WriteLine("SUMA TOTAL ES : " + SUM);
            Console.WriteLine("MEDIA ARITMÉTICA: " + SUM / CAN);
            Console.Write("Pulse una Tecla:"); Console.ReadLine();
        }
    }
}