using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    internal class Program
    {
        static List<Testek> testek = new List<Testek>();
        static void Main(string[] args)
        {
            testek.Add(new Teglatest(3, 6, 7));
            testek.Add(new Kocka(4));
            testek.Add(new Henger(3, 8));
            

            foreach (var item in testek)
            {
                if (item.GetType().Equals(typeof(Teglatest)))
                {
                    Teglatest teglatest = (Teglatest)item;
                    Console.WriteLine($"A téglatest területe: {teglatest.Terfogat()}- felszíne:{teglatest.Felszin()}");
                }
                else if (item.GetType().Equals(typeof(Kocka)))
                {
                    Kocka kocka = (Kocka)item;
                    Console.WriteLine($"A kocka térfogata: {kocka.Terfogat()}- felszíne: {kocka.Felszin()}");
                }
                else if (item.GetType().Equals(typeof(Henger)))
                {
                    Henger henger = (Henger)item;
                    Console.WriteLine($"A kocka térfogata: {henger.Terfogat()}- felszíne: {henger.Felszin()}");
                }
            }



            Console.WriteLine("program vége");
            Console.ReadLine();
        }
    }
}
