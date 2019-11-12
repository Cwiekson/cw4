using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cw4
{
    class Student:Osoba
    {
        public int rok;
        public int numerGrupy;
        public int numerAlbumu;
        public Student(string imie,string nazwisko,int rokUrodzenia,int rok,int numerGrupy,int numerAlbumu,string miejscezamieszkania) : base ( imie, nazwisko,rokUrodzenia)   
        {
            
            this.rok = rok;
            this.numerGrupy = numerGrupy;
            this.numerAlbumu = numerAlbumu;
            this.miejsceZamieszkania = miejscezamieszkania;
        }
        public void WypiszInfo1()
        {
            Console.WriteLine($"{this.imie} {this.nazwisko} {this.rokUrodzenia} {this.rok} {this.numerGrupy} {this.numerAlbumu} {this.miejsceZamieszkania}");
        }
    }
}
