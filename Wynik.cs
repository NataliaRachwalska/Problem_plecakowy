using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Problem_plecakowy
{
    internal class Wynik
    {
        public List<Przedmiot> plecak;
        public int waga_sumaryczna;
        public int wartosc_sumaryczna;
        public int liczba_przedmiotow;

        public Wynik(List<Przedmiot> numery_przedmiotow, int waga_sumaryczna, int wartosc_sumaryczna)
        {
            this.plecak = numery_przedmiotow;
            this.waga_sumaryczna = waga_sumaryczna;
            this.wartosc_sumaryczna = wartosc_sumaryczna;
        }

        public override string ToString()
        {
            string wynik = "Numery:";
            foreach(Przedmiot P in plecak)
            {
                wynik += $" {P.numer} \n";
            }
            //wynik += $"Total Weight: { waga_sumaryczna} Total Value: { wartosc_sumaryczna}";
            return @$"{wynik} Total Weight: {waga_sumaryczna} Total Value: {wartosc_sumaryczna}";
        }
    }
}
