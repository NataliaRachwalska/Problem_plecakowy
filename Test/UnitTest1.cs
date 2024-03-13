using Problem_plecakowy;
using System.Collections.Generic;
namespace Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1() //¿adne elementy nie znajduja sie w plecaku
        {
            int liczbaPrzedmiotow = 4;
            int nasiono = 1;
            List<Przedmiot> listaPrzedmiotow = new List<Przedmiot>
            {
                new Przedmiot(4, 5, 1),
                new Przedmiot(8, 7, 2),
                new Przedmiot(3, 3, 3),
                new Przedmiot(9, 10, 4),
            };

            Problem problem = new Problem(liczbaPrzedmiotow, nasiono, listaPrzedmiotow);
            problem.Sortowanie();
            int pojemnosc = 2;
            Wynik result = problem.Rozwiazanie(pojemnosc);
            Assert.AreEqual(0, result.plecak.Count);

        }
        [TestMethod]
        public void TestMethod2() //jakis element znajduje sie w plecaku
        {
            int liczbaPrzedmiotow = 4;
            int nasiono = 1;
            List<Przedmiot> listaPrzedmiotow = new List<Przedmiot>
            {
                new Przedmiot(4, 5, 1),
                new Przedmiot(8, 7, 2),
                new Przedmiot(3, 3, 3),
                new Przedmiot(9, 10, 4),
            };

            Problem problem = new Problem(liczbaPrzedmiotow, nasiono, listaPrzedmiotow);
            problem.Sortowanie();
            int pojemnosc = 7;
            Wynik result = problem.Rozwiazanie(pojemnosc);
            Assert.IsNotNull(result.plecak.Count);
        }
        [TestMethod]
        public void TestMethod3() //zmieniona kolejnosc przedmiotow
        {
            int liczbaPrzedmiotow = 4;
            int nasiono = 1;
            List<Przedmiot> listaPrzedmiotow1 = new List<Przedmiot>
            {
                new Przedmiot(4, 5, 1),
                new Przedmiot(8, 7, 2),
                new Przedmiot(3, 3, 3),
                new Przedmiot(9, 10, 4),
            };
            List<Przedmiot> listaPrzedmiotow2 = new List<Przedmiot>
            {
                new Przedmiot(8, 7, 2),
                new Przedmiot(9, 10, 4),
                new Przedmiot(3, 3, 3),
                new Przedmiot(4, 5, 1),
            };
            Problem problem1 = new Problem(liczbaPrzedmiotow, nasiono, listaPrzedmiotow1);
            Problem problem2 = new Problem(liczbaPrzedmiotow, nasiono, listaPrzedmiotow2);
            problem1.Sortowanie();
            problem2.Sortowanie();
            int pojemnosc = 7;
            Wynik result1 = problem1.Rozwiazanie(pojemnosc);
            Wynik result2 = problem2.Rozwiazanie(pojemnosc);
            Assert.AreEqual(result1.plecak.Count, result2.plecak.Count);
        }
        [TestMethod]
        public void TestMethod4() //poprawnosc dla konkretnej instancji
        {
            int liczbaPrzedmiotow = 4;
            int nasiono = 1;
            List<Przedmiot> listaPrzedmiotow = new List<Przedmiot>
            {
                new Przedmiot(4, 5, 1),
                new Przedmiot(8, 7, 2),
                new Przedmiot(3, 3, 3),
                new Przedmiot(9, 10, 4),
            };
         
            Problem problem = new Problem(liczbaPrzedmiotow, nasiono, listaPrzedmiotow);
            problem.Sortowanie();
            int pojemnosc = 7;
            Wynik result = problem.Rozwiazanie(pojemnosc);

            Assert.AreEqual(7,result.waga_sumaryczna);
            Assert.AreEqual(8,result.wartosc_sumaryczna);

        }
        [TestMethod]
        public void TestMethod5() /*czy jesli pojemnosc bedzie na tyle duza 
     ze zmiesci wszyskie przedmioty to czy wszystkie zostana w³ozone do plecaka*/
        {
            int liczbaPrzedmiotow = 4;
            int nasiono = 1;
            List<Przedmiot> listaPrzedmiotow = new List<Przedmiot>
            {
                new Przedmiot(4, 5, 1),
                new Przedmiot(8, 7, 2),
                new Przedmiot(3, 3, 3),
                new Przedmiot(9, 10, 4),
            };

            Problem problem = new Problem(liczbaPrzedmiotow, nasiono, listaPrzedmiotow);
            problem.Sortowanie();
            int pojemnosc = 24;
            Wynik result = problem.Rozwiazanie(pojemnosc);

            Assert.AreEqual(4,result.plecak.Count);

        }
        [TestMethod]
        public void TestMethod6() /*czy jeœli nie bedzie ¿adnych przedmiotów to plecak bedzie pusty?*/
        {
            int liczbaPrzedmiotow = 0;
            int nasiono = 1;
            List<Przedmiot> listaPrzedmiotow = new List<Przedmiot>();

            Problem problem = new Problem(liczbaPrzedmiotow, nasiono, listaPrzedmiotow);
            problem.Sortowanie();
            int pojemnosc = 24;
            Wynik result = problem.Rozwiazanie(pojemnosc);

            Assert.AreEqual(0,result.plecak.Count);

        }
        [TestMethod]
        public void TestMethod7() /*czy jesli stosunki wag do wartosci beda takie same
                                   * to czy cokowiek znajdzie sie w plecaku*/
        {
            int liczbaPrzedmiotow = 4;
            int nasiono = 1;
            List<Przedmiot> listaPrzedmiotow = new List<Przedmiot>
            {
                new Przedmiot(4, 4, 1),
                new Przedmiot(4, 4, 2),
                new Przedmiot(4, 4, 3),
                new Przedmiot(4, 4, 4),
            };

            Problem problem = new Problem(liczbaPrzedmiotow, nasiono, listaPrzedmiotow);
            problem.Sortowanie();
            int pojemnosc = 4;
            Wynik result = problem.Rozwiazanie(pojemnosc);

            Assert.IsTrue(result.plecak.Count >0);

        }
        [TestMethod]
        public void TestMethod8() /*co jak waga bedzie zerowa*/
        {
            int liczbaPrzedmiotow = 4;
            int nasiono = 1;
            List<Przedmiot> listaPrzedmiotow = new List<Przedmiot>
            {
                new Przedmiot(0, 4, 1),
                new Przedmiot(4, 6, 2),
                new Przedmiot(10, 4, 3),
                new Przedmiot(4, 3, 4),
            };

            Problem problem = new Problem(liczbaPrzedmiotow, nasiono, listaPrzedmiotow);
            problem.Sortowanie();
            int pojemnosc = 4;
            Wynik result = problem.Rozwiazanie(pojemnosc);

            Assert.IsTrue(result.plecak.Count > 1);

        }
    }
}
