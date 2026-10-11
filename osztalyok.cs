using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp3
{
    internal class osztalyok
    {
        public static void fajlbeolvasas()
        {
            string szoveg = File.ReadAllText("C:\\Users\\Levente\\source\\repos\\ConsoleApp3\\ConsoleApp3\\teszt.txt");

            string[] kiirtszoveg = szoveg.Split(';');

            foreach (var tulajdonsag in kiirtszoveg)
            {
                Console.WriteLine($"{tulajdonsag}");
            }
        }

        public static void menu()
        {
            Console.WriteLine("\n--> Üdvözöljük a Lecso Állatmenhely rendszerében! <--\n");
            Console.WriteLine(" 1. Állatok megtekintése");
            Console.WriteLine(" 2. Új állat felvétele");
            Console.WriteLine(" 3. Jelentkezők megtekintése");
            Console.WriteLine(" 4. Új jelentkezők felvétele");
            Console.WriteLine(" 5. Örökbefogadási párosítás");
            Console.WriteLine(" 6. Kötelező riportok\n");

            Console.Write("-> Válassz az opciók közül: ");

            string valasz = Console.ReadLine();
        }

        public static void vissza()
        {
            Console.Write("Vissza (I): ");
            string valasz = Console.ReadLine();
            if (valasz == "I" || valasz == "i")
            {
                Console.Clear();
                menu();
            }
            else
            {
                Console.WriteLine("Helytelen válasz!");
            }
        }

        public static void felvetel()
        {
            Console.Write("Új állat neve: ");
            string uj_allat_nev = Console.ReadLine();

            Console.Write($"{uj_allat_nev} fajtája: ");
            string uj_allat_faj = Console.ReadLine();

            Console.Write($"{uj_allat_nev} kora: ");
            string uj_allat_kor = Console.ReadLine();

            Console.Write($"{uj_allat_nev} (hozzászokott) lakhelye: ");
            string uj_allat_lak = Console.ReadLine();

            Console.Write($"{uj_allat_nev} dátum: ");
            string uj_allat_varakozasdatum = Console.ReadLine();

            File.AppendAllText("C:\\Users\\Levente\\source\\repos\\ConsoleApp3\\ConsoleApp3\\teszt.txt", $"\n{uj_allat_nev};");
            File.AppendAllText("C:\\Users\\Levente\\source\\repos\\ConsoleApp3\\ConsoleApp3\\teszt.txt", $"{uj_allat_faj};");
            File.AppendAllText("C:\\Users\\Levente\\source\\repos\\ConsoleApp3\\ConsoleApp3\\teszt.txt", $"{uj_allat_kor};");
            File.AppendAllText("C:\\Users\\Levente\\source\\repos\\ConsoleApp3\\ConsoleApp3\\teszt.txt", $"{uj_allat_lak};");
            File.AppendAllText("C:\\Users\\Levente\\source\\repos\\ConsoleApp3\\ConsoleApp3\\teszt.txt", $"{uj_allat_varakozasdatum};");
        }

        public static void torles()
        {
            Console.Write("Állat neve: ");
            string torles_allat = Console.ReadLine();
        }

        public static void allatok()
        {
            Console.WriteLine("Bodri egy macska");
        }
        public static void jelentkezok()
        {
            Console.WriteLine("Tamas egy jelentkezo");
        }
    }
}
