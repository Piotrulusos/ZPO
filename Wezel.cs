using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal class Wezel
    {
        Wezel WezelLewe;
        Wezel WezelPrawe;
        Wezel rodzic;
        int wartosc;
        int id;

        public Wezel(int wartosc)
        {
            this.wartosc = wartosc;
        }

        public override string ToString()
        {

            return $"[{this.wartosc}]";
        }

    }


}
