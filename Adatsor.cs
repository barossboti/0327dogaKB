using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eutazas
{
    internal class Adatsor
    {
        public int sorszam { get; set; }
        public string datum { get; set; }
        public int azonosito { get; set; }
        public string jegy { get; set; }
        public int ervenyesseg { get; set; }
        public Adatsor(string sor)
        {
            string[] sz = sor.Split(' ');
            sorszam=Convert.ToInt32(sz[0]);
            datum= sz[1];
            azonosito = Convert.ToInt32(sz[2]);
            jegy = sz[3];
            ervenyesseg = Convert.ToInt32(sz[4]);

        }
    }
}
