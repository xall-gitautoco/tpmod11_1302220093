// memanggil library AljabarLibrary2
using AljabarLibrary2;

// deklarasi class Program
class Program
{
    // deklarasi bagian utama untuk menjalankan program
    public static void Main(string[] args)
    {
        // memanggil class AkarPersaKuadrat dan membungkusnya pada variabel akarPersamaanKuadrat
        AkarPersaKuadrt akarPersamaanKuadrat = new AkarPersaKuadrt();

        // menampilkan inputan yang diberikan kepada class dan method-nya
        Console.WriteLine("Input  : {1, -3, -10}");

        // menampilkan hasil dari inputan yang diberikan diatas
        akarPersamaanKuadrat.SolveQuadraticEquation(1, -3, -10);
        Console.WriteLine("");

        // menampilkan inputan yang diberikan kepada class dan method-nya
        Console.WriteLine("Input  : {2, -3}");

        // memanggil class Hasilkuadrat dan membungkusnya pada variabel hasilkuadrat
        Hasilkuadrat hasilkuadrat = new Hasilkuadrat();

        // menampilkan hasil dari inputan yang diberikan diatas
        hasilkuadrat.olahHasilKuadrat(2, -3);
    }
}