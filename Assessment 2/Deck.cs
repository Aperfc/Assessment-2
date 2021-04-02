using System;
using System.Collections.Generic;
using System.Text;

namespace Assessment_2
{
    class Deck
    {
        private List<Card> Deck_Of_Cards;

        public List<Card> _Deck_Of_Cards
        {
            get { return Deck_Of_Cards; }
            set { Deck_Of_Cards = value; }
        }

        public Deck()
        {
            _Deck_Of_Cards = new List<Card>();
        }

        public Deck(List<Card> New_Deck): this()
        {
            _Deck_Of_Cards = New_Deck;
        }

        public void Add(Card new_card)
        {
            Deck_Of_Cards.Add(new_card);
        }

        public bool isEmpty()
        {
            return Deck_Of_Cards.Count == 0;
        }

        public void Shuffle()
        {
            var rand = new Random();
            int length = Deck_Of_Cards.Count;
            List<Card> temp_list = new List<Card>();
            for (int i = 0; i < length; i++)
            {
                int random_number = rand.Next(Deck_Of_Cards.Count);
                temp_list.Add(Deck_Of_Cards[random_number]);
                Deck_Of_Cards.RemoveAt(random_number);
            }
            Deck_Of_Cards = temp_list;
        }

        public Card Deal()
        {
            Card returning_card = Deck_Of_Cards[Deck_Of_Cards.Count - 1];
            Deck_Of_Cards.RemoveAt(Deck_Of_Cards.Count - 1);
            return returning_card;
        }

    }
}
