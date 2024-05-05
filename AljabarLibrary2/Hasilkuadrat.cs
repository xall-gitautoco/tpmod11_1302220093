using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// program class ini diberikan nama AljabarLibrary2
namespace AljabarLibrary2
{
    // deklarasi class Hasilkuadrat
    public class Hasilkuadrat
    {
        // deklarasi method olahHasilKuadrat untuk perhitungan kuadratik
        public void olahHasilKuadrat(double a, double b)
        {
            // algoritma untuk perhitungan hasil kuadrat
            Console.WriteLine("Output : {" + Math.Pow(a, 2) + ", " + 2 * (a * b) + ", " + Math.Pow(b, 2) + "}");
        }
    }
}
