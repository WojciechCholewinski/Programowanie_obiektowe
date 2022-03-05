using System;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
    public class Ulamek
    {
        private int licznik, mianownik;

        public Ulamek()
        {
           
        }
        public Ulamek(int Licznik, int Mianownik)
        {
            licznik = Licznik;
            mianownik = Mianownik;
        }

        // Copy constructor
        public Ulamek(Ulamek previousUlamek)
        {
            licznik = previousUlamek.licznik;
            mianownik = previousUlamek.mianownik;
        }

        public void ToString()
        {

        }



    }


}
