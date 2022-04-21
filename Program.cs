using System;

namespace Donguler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "C#";
            string kurs2 = "Algoritma";
            string kurs3 = "Java";

            //array - dizi 

            string[] kurslar = new string[] {  "Algoritma", "Java", "Python", "C++" };


            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("------$$------");

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }
            Console.WriteLine("");

            Console.WriteLine("Sayfa Sonu - footer");
        }
    }
}
