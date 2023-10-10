using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperBowlCLI
{
    internal class Program
    {
        static void Main()
        {
            var dontok = new List<Donto>();
            using (var sr = new StreamReader(@"..\..\src\SuperBowl.txt"))
            {
                _ = sr.ReadLine();
                while (!sr.EndOfStream) dontok.Add(new Donto(sr.ReadLine()));
            }

            Console.WriteLine($"4. feladat: Dointők száma: {dontok.Count}");

            var f5 = dontok.Average(d => d.Eredmeny.Gy - d.Eredmeny.V);
            Console.WriteLine($"5. feladat: Átlagos pontkülönbség: {f5:0.0}");

            var f6 = dontok.OrderBy(d => d.Nezoszam).Last();
            Console.WriteLine("6. feladat: Legmagasabb nézőszám a döntők során:");
            Console.WriteLine($"\tSorszám (dátum): {f6.SSz.ArabSsz} ({f6.Datum.ToString("yyyy.MM.dd.")})");
            Console.WriteLine($"\tGyőztes csapat: {f6.Gyoztes}, szerzett pontok: {f6.Eredmeny.Gy}");
            Console.WriteLine($"\tVesztes csapat: {f6.Vesztes}, szerzett pontok: {f6.Eredmeny.V}");
            Console.WriteLine($"\tHelyszín: {f6.Helyszin}");
            Console.WriteLine($"\tVáros, Állam: {f6.VarosAllam.V}, {f6.VarosAllam.A}");
            Console.WriteLine($"\tNézőszám: {f6.Nezoszam}");

            using (var sw = new StreamWriter(@"..\..\src\SuperBowlNew.txt"))
            {
                sw.WriteLine("Ssz;Dátum;Győztes;Eredmény;Vesztes;Nézőszám");
                var dic = new Dictionary<string, int>();
                foreach (var d in dontok)
                {
                    if (!dic.ContainsKey(d.Gyoztes)) dic.Add(d.Gyoztes, 1);
                    else dic[d.Gyoztes]++;
                    if (!dic.ContainsKey(d.Vesztes)) dic.Add(d.Vesztes, 1);
                    else dic[d.Vesztes]++;

                    sw.WriteLine(
                        $"{d.SSz.ArabSsz};" +
                        $"{d.Datum.ToString("yyyy.MM.dd.")};" +
                        $"{d.Gyoztes} ({dic[d.Gyoztes]});" +
                        $"{d.Eredmeny.Gy}.{d.Eredmeny.V};" +
                        $"{d.Vesztes} ({dic[d.Vesztes]});" +
                        $"{d.Nezoszam}");
                }
            }
            
            Console.ReadKey(true);
        }
    }
}
