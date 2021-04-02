using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Assessment_2
{
    class Hand
    {
        private List<Card> hand;
        public Hand()
        {
            hand = new List<Card>();
        }

        public void Add(Card new_card)
        {
            hand.Add(new_card);
        }

        public void Fold()
        {
            hand = new List<Card>();
        }

        public void Check()
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
