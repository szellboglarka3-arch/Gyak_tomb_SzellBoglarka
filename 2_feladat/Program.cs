using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_feladat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] homerseklet = { 12, 8, -1, 5, 14, 7, 2 };
                Console.WriteLine($"A legalacsonyabb hőmérséklet: {homerseklet.Min()} °C");
                Console.WriteLine($"A legalacsonyabb hőmérséklet: {homerseklet.Max()} °C");
                Console.WriteLine($"A legalacsonyabb hőmérséklet: {homerseklet.Average():F1} °C");
            Console.ReadKey();
        }
    }
}
