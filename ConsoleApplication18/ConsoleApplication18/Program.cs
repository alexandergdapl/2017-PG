using System;

namespace ConsoleApplication18
{
    class Program
    {        
        static void Main(string[] args)
        {
            Service jeden = new Service();
            jeden.GenerateListOfPerson();
            jeden.DrukujListe();

            Console.WriteLine("\nSortowanie wg Name");
            
            jeden.SortName();
            jeden.DrukujListe();

            Console.WriteLine("\nSortowanie wg Age");

            jeden.SortAge();
            jeden.DrukujListe();

            Console.WriteLine("\nSortowanie wg Id");

            jeden.SortId();
            jeden.DrukujListe();



            Console.ReadKey();
        }       
    }
}
