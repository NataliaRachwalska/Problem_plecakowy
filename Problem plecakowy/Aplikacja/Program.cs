using System.Runtime.CompilerServices;


namespace Problem_plecakowy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Enter the number of items :");
            int liczba_przedmiotow = int.Parse(Console.ReadLine());
            Console.WriteLine(" Enter the seed :");
            int nasionko = int.Parse(Console.ReadLine());
            List<Przedmiot> lista_przedmiotow = new List<Przedmiot>();
            Problem pp = new Problem(liczba_przedmiotow, nasionko,lista_przedmiotow);
            pp.lista_przedmiotow = pp.Losowanie(nasionko, liczba_przedmiotow);
            Console.WriteLine(pp.ToString());
            pp.Sortowanie();
            Console.WriteLine("Sorted:");
            Console.WriteLine(pp.ToString());
            Console.WriteLine(" Enter the capacity :");
            int pojemnosc = int.Parse(Console.ReadLine());
            List<Przedmiot> plecak = new List<Przedmiot>();
            int waga_sumaryczna = 0;
            int wartosc_sumaryczna = 0;
            Wynik wyn = new Wynik(plecak, waga_sumaryczna, wartosc_sumaryczna);
            wyn = pp.Rozwiazanie(pojemnosc);
            Console.WriteLine(wyn);
        }
    }
}
