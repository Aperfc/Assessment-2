using System;
using System.Collections.Generic;
using System.Text;

namespace Assessment_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //adds the cards to the deck then shuffles the cards with a method
            Hand hand = new Hand();
            List<int> values = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13 };
            List<string> suits = new List<string> { "spades", "Hearts", "Clubs", "Diamonds" };
            Deck card_deck = new Deck();
            foreach(string suit in suits)
            {
                foreach(int val in values)
                {
                    Card temp_card = new Card(suit, val);
                    card_deck.Add(temp_card);
                }
            }
            card_deck.Shuffle();

            //used to capture the users response and act accordinglly. will keep running on a loop until there are no more cards to pull from .
            while(card_deck.isEmpty() == false)
            {
                Console.Write("Would you like to:\n1. Be dealt a card\n2. Check your hand\n3. Throw your hand\n4. Quit\n>>>");
                string choice = Console.ReadLine();
                if (choice == "1")      //deal a card
                {
                    Card dealt_card = card_deck.Deal();
                    hand.Add(dealt_card);
                    Console.WriteLine("\nYou have been dealt the...");
                    dealt_card.Details();
                    Console.WriteLine("");
                }
                else if (choice == "2")     //checks which cards the user has pulled
                {
                    hand.Check();
                }
                else if (choice == "3")     //emptys the users hand, removing all cards the user has been dealt
                {
                    hand.Fold();
                    Console.WriteLine("you have folded your hand and how your hand is empty");
                }
                else if (choice == "4")     //quits the program by breaking the loop
                {
                    break;
                }
                else
                {
                    Console.WriteLine("you did not enter a valaid response, try again");
                }
            }
            if (card_deck.isEmpty() == true)        //prints the message that the deck is empty, wont print if the user quits the program by choice.
                Console.WriteLine("\nthe deck is now empty\n");
        }
    }
}
