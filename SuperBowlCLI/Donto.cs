using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperBowlCLI
{
    internal class Donto
    {
        public RomaiSorszam SSz { get; set; }
        public DateTime Datum { get; set; }
        public string Gyoztes { get; set; }
        public (int Gy, int V) Eredmeny { get; set; }
        public string Vesztes { get; set; }
        public string Helyszin { get; set; }
        public (string V, string A) VarosAllam { get; set; }
        public int Nezoszam { get; set; }

        public Donto(string s)
        {
            var v = s.Split(';');
            SSz = new RomaiSorszam(v[0]);
            Datum = DateTime.Parse(v[1]);
            Gyoztes = v[2];
            var ev = v[3].Split('-');
            Eredmeny = (int.Parse(ev[0]), int.Parse(ev[1]));
            Vesztes = v[4];
            Helyszin = v[5];
            var vav = v[6].Split(',');
            VarosAllam = (vav[0].Trim(), vav[1].Trim());
            Nezoszam = int.Parse(v[7]);
        }
    }
}
