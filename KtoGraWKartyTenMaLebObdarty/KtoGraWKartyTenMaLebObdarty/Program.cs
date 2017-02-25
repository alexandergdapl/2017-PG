using System;

namespace KtoGraWKartyTenMaLebObdarty
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Deck decks = new Deck();
            decks.CreateDeck();
            decks.ShowDeck();


            Console.ReadKey();
        }
    }
}
