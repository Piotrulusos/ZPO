using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal class Drzewo
    {
        public Wezel korzen;
        int LiczbaWezlow;
        int LiczbaPoziomow;

        public Drzewo(int wartosc)
        {
            this.LiczbaWezlow = 1;
            this.LiczbaPoziomow = 1;
            var w = new Wezel(wartosc);
            this.korzen = w;
        }

    }
}
