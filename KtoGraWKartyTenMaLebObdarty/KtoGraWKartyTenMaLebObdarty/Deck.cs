using System;
using System.Collections.Generic;
using KtoGraWKartyTenMaLebObdarty.Interfaces;

namespace KtoGraWKartyTenMaLebObdarty
{
    class Deck : IDeck
    {
        //CallingCards C = new CallingCards();




        /*
            Chciałbym dobrać się do metody z klasy CallingCards aby zmienić cyfry
            11-15 na nazwy kart.
            Instancja tej klasy i metoda "NameOfBigCards"?

        */


        public List<Cards> FinishDeck = new List<Cards>();

        public string[] Colors = {"Karo", "Trefl", "Pik", "Serce"};
        public string[] NameOfCard = {"Walet", "Dama", "Król", "As"};



        

        public void CreateDeck()
        {
            for (int i = 0; i < Colors.Length; i++)
            {
                for (int j = 2; j < 15; j++)
                {
                    if (j<11)
                    {
                        FinishDeck.Add(new Cards(Colors[i], j, j.ToString()));
                    }
                    
                    if (j>10)
                    {
                        FinishDeck.Add(new Cards(Colors[i], j, NameOfCard[j - 11]));
                    }
                }
            }
        }

        
        public void ShowDeck()
        {
            foreach (var card in FinishDeck)
            {
                Console.WriteLine("Kolor: {0,2}, Wartość: {1,2}, Nazwa: {2}", card.ColorOfCard, card.ValueOfCard, card.NameOfCard);
            }
        }
    }
}
