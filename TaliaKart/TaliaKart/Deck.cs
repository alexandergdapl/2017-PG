using System;
using System.Collections.Generic;

namespace TaliaKart
{
    class Deck
    {
        public List<Card> Cards;
        public Deck()
        {
            Cards = new List<Card>();

            for (int currentColor = 0; currentColor < 4; currentColor++)
            {
                for (int currentValue = 9; currentValue < 15; currentValue++)
                {
                    Card newCard;
                    if (currentColor == 0)//Karo
                    {
                        newCard = new Card(currentValue, "Karo");
                        Cards.Add(newCard);
                    }
                    if(currentColor ==1 )//Kier
                    {
                        newCard = new Card(currentValue, "Kier");
                        Cards.Add(newCard);
                    }
                    if(currentColor == 2)//Trefl
                    {
                        newCard = new Card(currentValue, "Trefl");
                        Cards.Add(newCard);
                    }
                    if(currentColor == 3)//Pik
                    {
                        newCard = new Card(currentValue, "Pik");
                        Cards.Add(newCard);
                    }
                }                
            }
        }

        public void WriteAllCards()
        {
            foreach (Card card in Cards)
            {
                Console.WriteLine(card.Description());
            }
        }


        public void AddNewCard()
        {
            Console.Clear();
            Console.WriteLine("wpisz wartosc karty ");
            int value = int.Parse(Console.ReadLine());
            string color = Console.ReadLine();
            Card newcard = new Card(value, color);
            if(!(IsCardInList(newcard)))
            Cards.Add(newcard);
        }


        public bool IsCardInList(Card newCard)
        {
            for (int currentCardIndex = 0; currentCardIndex < Cards.Count; currentCardIndex++)
            {
                if (newCard.Color == Cards[currentCardIndex].Color &&
                    newCard.Value == Cards[currentCardIndex].Value) return true;
            }
            return false;
        }



    }


        



    }

