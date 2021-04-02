using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Assessment_2
{
    class Hand
    {
        private List<Card> hand;        //players hand which is a list of cards

        public Hand()       //getter and setter
        {
            hand = new List<Card>();
        }

        public void Add(Card new_card)      //adds a new card to the players hand
        {
            hand.Add(new_card);
        }

        public void Fold()      //removes all cards in the players hand
        {
            hand = new List<Card>();
        }

        public void Check()     //displays all cards the player is currently holding.
        {
            if (hand.Count == 0)
            {
                Console.WriteLine("\nyour hand is empty\n");
            }
            else
            {
                Console.WriteLine("");
                foreach (Card card in hand)
                {
                    card.Details();
                }
                Console.WriteLine("");
            }
        }

    }
}
