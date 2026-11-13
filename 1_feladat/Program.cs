using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_feladat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] szamok = new int[10];
            Random rnd = new Random();
            for (int i = 0; i < szamok.Length; i++)
            {
                szamok[i] = rnd.Next(1,100);
            }
            Console.WriteLine(String.Join(" ",szamok));
            int parosdb = 0;
            int paratlandb = 0;
            for (int i = 0; i < szamok.Length; i++)
            {
                if (szamok[i]%2==0)
                {
                    parosdb++;
                }
                else { paratlandb++; }
            }
            Console.WriteLine($"Páros számok száma: {parosdb}");
            Console.WriteLine($"Páratlan számok száma: {paratlandb}");
            Console.ReadKey();  
        }
    }
}
