using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cw4
{
    class Program
    {
        static void Main(string[] args)
        {
            Osoba osoba1 = new Osoba("Kamil","Długołęcki",1998);
            osoba1.WypiszInfo();
            Student student1 = new Student("Kamil", "Długołęcki", 1998, 2, 1, 121314,"Batagowo");
            student1.WypiszInfo1();
            Osoba osoba2 = new Osoba("Michał", "Nowak", 1997);
            Student student2 = new Student("Adam", "Krawczyk", 2000, 1, 2,52442, "Olsztyn");
            //student2 = osoba2;
            osoba1 = student1;
            Console.WriteLine(student1.ObliczWiek());
            osoba1.WypiszInfo();

            Console.ReadKey();
            

        }
    }
}
