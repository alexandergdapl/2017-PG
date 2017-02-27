using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaliaKart
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck deck = new Deck();
          
            string input;
            while (true)
            {
                deck.WriteAllCards();
                Console.WriteLine("1. Dodajnową kartę");
                Console.WriteLine("2. Wyjdź");
                input = Console.ReadLine();
                if (input == "1") deck.AddNewCard();
                if (input == "2") break;
                Console.Clear();
            }












            Console.ReadKey();  
        }
    }
}
