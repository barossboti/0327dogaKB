using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace eutazas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] f = File.ReadAllLines("utasadat.txt");
            List<Adatsor> adatok = new List<Adatsor>();

            for (int i = 0; i < f.Length; i++)
            {
                adatok.Add(new Adatsor(f[i]));
            }
            Console.WriteLine("2. feladat");
            Console.WriteLine($"A buszra {adatok.Count} utas akart felszállni.");


            Console.WriteLine("3. feladat");
            int db = 0;
            foreach (var i in adatok)
            {
                if (i.ervenyesseg.ToString() == "JGY")
                {
                    db++;
                }
            }
            Console.WriteLine($"A buszra {db} utas nem szállhatott fel ");


            Console.WriteLine("4. feladat");
            var legtobbfelszallo = adatok.GroupBy(x => x.sorszam).OrderByDescending(x => x.Count()).ToList();
            Console.WriteLine($"A legtöbb utas {legtobbfelszallo[0].Count()} fő a 8. megállóban próbált felszállni.");

            Console.WriteLine("5. feladat");
            var ingyen = adatok.Where(x => x.jegy == "NYP" || x.jegy == "RVS" || x.jegy == "GYK" ).Count();
            var kedvezmeny = adatok.Where(x => x.jegy == "TAB" || x.jegy == "NYB").Count();

            Console.WriteLine($"Ingyenesen utazók száma: {ingyen}");
            Console.WriteLine($"Kedvezményesen utazok száma: {kedvezmeny}");
            Console.ReadKey();
        }
    }
}
