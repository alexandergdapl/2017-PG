using System;

namespace marzec_szesc
{
    class Program
    {
        static void Main(string[] args)
        {

            Service xyz = new Service();

            xyz.Reverse("Olek");

            xyz.IsPalindrom("rotator");
            xyz.IsPalindrom("Olek");

            xyz.EveryTwo("123456789");

            Console.WriteLine();

            Liczby k = new Liczby();
            k.LiczKwadratyLiczb();


            Console.ReadKey(); 
        }
    }
}
