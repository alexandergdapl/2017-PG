using System;
using System.Collections.Generic;
using System.Threading;

namespace Osoba
{
    
    class Program
    {
        static void Main(string[] args)
        {
            // list of person + sort

            PersonContainer abc = new PersonContainer();
            Console.WriteLine();

            abc.WriteAllPersons();

            //Sortowanie posortuj = new Sortowanie();
            //posortuj.Sort();
            abc.Sortowanie();
            abc.WriteAllPersons();

            Console.WriteLine("\nAby wyłączyć program wciśnij dowolny klawisz.");
            Console.ReadKey();
        }
    }
}
