using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;


namespace Problem_plecakowy
{
    internal class Przedmiot
    {
        public int waga;
        public int wartosc;
        public int numer;
        public int czy_w_plecaku = 0;
       public Przedmiot(int waga, int wartosc, int numer)
        {
            this.waga = waga;
            this.wartosc = wartosc;
            this.numer = numer;
        }
        public override string ToString()
        {
            return $"Nr. {numer} Weight: {waga} Value: {wartosc}";
        }
    }
}
