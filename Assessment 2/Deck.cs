using System;
using System.Collections.Generic;
using System.Text;

namespace Assessment_2
{
    class Deck
    {
        private List<Card> Deck_Of_Cards;       //only attribute which holdes a list of cards, the deck

        public List<Card> _Deck_Of_Cards        //getter and setter
        {
            get { return Deck_Of_Cards; }
            set { Deck_Of_Cards = value; }
        }

        public Deck()       //default constructor
        {
            _Deck_Of_Cards = new List<Card>();
        }

        public Deck(List<Card> New_Deck): this()       //consructor when a arguement is given
        {
            _Deck_Of_Cards = New_Deck;
        }

        public void Add(Card new_card)      //adds a new card to the deck
        {
            Deck_Of_Cards.Add(new_card);
        }

        public bool isEmpty()       //checks if the deck is empty by checking its length
        {
            return Deck_Of_Cards.Count == 0;
        }

        public void Shuffle()       //shuffles th cards by using a random number generator to put cards into a new list while reducing the original list 
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

        public Card Deal()      //deals a card by returing the card and removing it from the deck. removes the last card in the deck (face down)
        {
            Card returning_card = Deck_Of_Cards[Deck_Of_Cards.Count - 1];
            Deck_Of_Cards.RemoveAt(Deck_Of_Cards.Count - 1);
            return returning_card;
        }

    }
}
