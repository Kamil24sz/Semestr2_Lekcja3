using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dziedziczenie.obiekty
{
    public class Autobus : Pojazdy
    {

        public int liczbaMiejsc;

        public Autobus(int moc, string kolor, string marka, int liczbaMiejsc) : base(moc, kolor, marka)
        {
            this.liczbaMiejsc = liczbaMiejsc;
        }
        public void UruchomSilnik()
        {
            Console.WriteLine("Silnik autobusu został uruchomiony...");
        }
    }
}
