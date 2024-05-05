using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// program class ini diberikan nama AljabarLibrary2
namespace AljabarLibrary2
{
    // deklarasi class AkarPersaKuadrt
    public class AkarPersaKuadrt
    {
        // deklarasi method SolveQuadraticEquation untuk perhitungan akar persamaan kuadrat
        public void SolveQuadraticEquation(double a, double b, double c)
        {
            // deklarasi variabel discriminant untuk menampung perhitungan didalam akarnya
            double discriminant = b * b - 4 * a * c;

            // Jika hasil discriminant lebih dari 0 maka kondisi dibawah berjalan
            if (discriminant > 0)
            {
                // Akar real dan berbeda
                double root1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
                double root2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
                Console.WriteLine("Output : {" + root1 + ", " + root2 + "}");
            }
            // Jika hasil discriminant lebih dari 0 maka kondisi dibawah berjalan
            else if (discriminant == 0)
            {
                // Akar real dan sama
                double root = -b / (2 * a);
                Console.WriteLine("x1 = x2 = " + root);
            }
            // Jika hasil discriminant lebih dari 0 maka kondisi dibawah berjalan
            else
            {
                // Akar imajiner
                double realPart = -b / (2 * a);
                double imaginaryPart = Math.Sqrt(-discriminant) / (2 * a);
                Console.WriteLine("Output : {" + realPart + ", " + imaginaryPart + "}");
            }

        }
    }
}
