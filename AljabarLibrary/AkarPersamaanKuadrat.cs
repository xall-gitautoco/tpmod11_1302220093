using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.ApplicationModel.Contacts;

namespace AljabarLibrary
{
    public class AkarPersamaanKuadrat
    {
        public void SolveQuadraticEquation(double a, double b, double c)
        {
            Console.WriteLine("Test");

            double discriminant = b * b - 4 * a * c;

            if (discriminant > 0)
            {
                // Akar real dan berbeda
                double root1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
                double root2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
                Console.WriteLine("Akar persamaan kuadrat adalah:");
                Console.WriteLine("x1 = " + root1);
                Console.WriteLine("x2 = " + root2);
            }
            else if (discriminant == 0)
            {
                // Akar real dan sama
                double root = -b / (2 * a);
                Console.WriteLine("Akar persamaan kuadrat adalah:");
                Console.WriteLine("x1 = x2 = " + root);
            }
            else
            {
                // Akar imajiner
                double realPart = -b / (2 * a);
                double imaginaryPart = Math.Sqrt(-discriminant) / (2 * a);
                Console.WriteLine("Akar persamaan kuadrat adalah:");
                Console.WriteLine("x1 = " + realPart + " + " + imaginaryPart + "i");
                Console.WriteLine("x2 = " + realPart + " - " + imaginaryPart + "i");
            }
        }
    }
}
