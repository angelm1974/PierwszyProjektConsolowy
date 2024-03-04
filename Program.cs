using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PierwszyProjektConsolowy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello");
            Console.WriteLine("Hello World!");
            Console.WriteLine(Dodaj(2, 5));
            Utility.AddTwoNumbers(4, 6);
            Utility.MulltiplyThreeNumbers(3, 4, 1);
            Console.ReadKey();
        }

        /// <summary>
        /// Dodaje dwie liczby całkowite i zwraca ich sumę.
        /// </summary>
        /// <param name="liczba1">Pierwsza liczba do dodania.</param>
        /// <param name="liczba2">Druga liczba do dodania.</param>
        /// <returns>Suma dwóch liczb całkowitych.</returns>
        static int Dodaj(int liczba1, int liczba2)
        {
            return (int)(liczba1 + liczba2);
        }
    }
}
