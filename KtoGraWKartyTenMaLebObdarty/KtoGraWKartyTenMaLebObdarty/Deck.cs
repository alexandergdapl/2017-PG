using System;
using System.Collections.Generic;

namespace KtoGraWKartyTenMaLebObdarty
{
    class Deck
    {
        /*
        CallingCards xyz = new CallingCards();
        
            Chciałbym dobrać się do metody z klasy CallingCards aby zmienić cyfry
            11-15 na nazwy kart.
            Instancja tej klasy i metoda "NameOfBigCards"?

        */


        public List<Cards> FinishDeck = new List<Cards>();

        public string[] Colors = {"Karo", "Trefl", "Pik", "Serce"};
        
        public void CreateDeck()
        {
            for (int i = 0; i < Colors.Length; i++)
            {
                for (int j = 2; j < 15; j++)
                {
                    FinishDeck.Add(new Cards(Colors[i], j));    
                }
            }
        }

        public void ShowDeck()
        {
            foreach (var card in FinishDeck)
            {
                Console.WriteLine("{0,2}, {1,2}", card.ColorOfCard, card.ValueOfCard);
            }
        }



    }
}
