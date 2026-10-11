using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;
using System.Security.Cryptography.X509Certificates;
using System.Net;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Lecsó Állatmenhely Adatkezelő Rendszer";
            osztalyok.menu();

            string valasz = Console.ReadLine();

            if (valasz == "1")
            {
                osztalyok.fajlbeolvasas();
                osztalyok.vissza();
            }
            else if (valasz == "2")
            {
                osztalyok.felvetel();
                osztalyok.vissza();
            }
            else
            {
                Console.WriteLine("ErROr!");
            }
        }
    }
}
