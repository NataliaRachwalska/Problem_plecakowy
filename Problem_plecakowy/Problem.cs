using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
[assembly: InternalsVisibleTo("Test"), InternalsVisibleTo("GUI")]
namespace Problem_plecakowy
{
    internal class Problem
    {
        public int liczba_przedmiotow;
        public List<Przedmiot> lista_przedmiotow ;
        public int nasiono;

        public string ToString()
        {
            string Problem = "";
            foreach (Przedmiot P in lista_przedmiotow)
            {
                Problem += $"Nr. {P.numer} Weight: {P.waga} Value: {P.wartosc}\n";
            }
            return Problem;
        }
        public Problem(int liczba, int nasiono, List<Przedmiot> lista_przedmiotow)
        {
            this.nasiono = nasiono;
            this.liczba_przedmiotow = liczba;
            this.lista_przedmiotow = lista_przedmiotow;
        }
   
            public List<Przedmiot> Losowanie(int nasiono, int liczba)
        {
            List<Przedmiot> lp = new List<Przedmiot>();
            Random random = new Random(nasiono);

            for (int i = 0; i < liczba; i++)
            {
                int waga = random.Next(1, 11);
                int wartosc = random.Next(1, 11);
                int numer = i;
                lp.Add(new Przedmiot(waga,wartosc,numer));          
            }

            return lp;
        }
        public void Sortowanie()
        {
            lista_przedmiotow.Sort((x, y) => ((double)y.wartosc/y.waga).CompareTo((double)x.wartosc / x.waga));
        }
        public Wynik Rozwiazanie(int pojemnosc)
        {         
            List<Przedmiot> plecak = new List<Przedmiot>();
            int waga_sumaryczna = 0;
            int wartosc_sumaryczna = 0;
            for(int i = 0; i < liczba_przedmiotow; i++)
            {
                if (lista_przedmiotow[i].waga <= pojemnosc)
                {
                    plecak.Add(lista_przedmiotow[i]);
                    pojemnosc = pojemnosc - lista_przedmiotow[i].waga;
                    waga_sumaryczna += lista_przedmiotow[i].waga;
                    wartosc_sumaryczna += lista_przedmiotow[i].wartosc;
                    lista_przedmiotow[i].czy_w_plecaku = 1;
                    
                }
            }
            Wynik wyn = new Wynik(plecak, waga_sumaryczna, wartosc_sumaryczna);
            wyn.liczba_przedmiotow=plecak.Count;
            return wyn;
        }
    }
}
