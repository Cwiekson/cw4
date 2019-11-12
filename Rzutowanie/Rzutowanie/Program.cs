using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rzutowanie
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseClass myObj = new BaseClass();
            DerrivedClass derObj = (DerrivedClass)myObj;
            NextDerrivedClass NxtObj1 = (NextDerrivedClass)myObj;

        }
    }
}
