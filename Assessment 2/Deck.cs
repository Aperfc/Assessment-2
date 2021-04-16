using System;
using System.Collections.Generic;
using System.Text;

namespace Assessment_2
{
    class Deck
    {
        private List<Card> Deck_Of_Cards;       //only attribute which holdes a list of cards, the deck

        public Deck()       //default constructor
        {
            List<string> suits = new List<string> { "spades", "Hearts", "Clubs", "Diamonds" };
            Deck_Of_Cards = new List<Card>();
            foreach(string item in suits)       //generates a deck of cards bby iterating over the suits
            {
                for (int i = 1; i <= 13; i++)       //iterating over the numbers
                {
                    Card new_card = new Card(item, i);
                    Deck_Of_Cards.Add(new_card);
                }
            }
            Shuffle();      //shuffles the cards
        }

        public Deck(List<Card> New_Deck): this()       //consructor when a arguement is given
        {
            Deck_Of_Cards = New_Deck;
        }

        public void Add(Card new_card)      //adds a new card to the deck
        {
            Deck_Of_Cards.Add(new_card);
        }

        public bool isEmpty()       //checks if the deck is empty by checking its length
        {
            return Deck_Of_Cards.Count == 0;
        }

        public void Shuffle()       //shuffles the cards by using a random number generator
        {
            var rand = new Random();
            int length = Deck_Of_Cards.Count;
            List<Card> temp_list = new List<Card>();        //creates a new list
            for (int i = 0; i < length; i++)        //iterates over the list of cards
            {
                int random_number = rand.Next(Deck_Of_Cards.Count);     //selects a random card from the deck, the count is always changing
                temp_list.Add(Deck_Of_Cards[random_number]);        //addds thwe card to the new list
                Deck_Of_Cards.RemoveAt(random_number);      //removes card from old list
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
