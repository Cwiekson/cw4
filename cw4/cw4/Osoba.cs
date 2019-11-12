using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cw4
{
    class Osoba
    {
        protected string imie;
        protected string nazwisko;
        protected int rokUrodzenia;
        protected string miejsceZamieszkania;
        public Osoba(string imie,string nazwisko,int rokUrodzenia)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.rokUrodzenia = rokUrodzenia;
            
            
        }
        public void  WypiszInfo()
        {
            Console.WriteLine($"{this.imie} {this.nazwisko} {this.rokUrodzenia}");
        }
        public int ObliczWiek()
        {
            return DateTime.Now.Year - rokUrodzenia;
        }
    }
}
