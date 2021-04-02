using System;
using System.Collections.Generic;
using System.Text;

namespace Assessment_2
{
    class Program
    {
        static void Main(string[] args)
        {
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

            while(card_deck.isEmpty() == false)
            {
                Console.Write("Would you like to:\n1. Be dealt a card\n2. Check your hand\n3. Throw your hand\n4. Quit\n>>>");
                string choice = Console.ReadLine();
                if (choice == "1")
                {
                    Card dealt_card = card_deck.Deal();
                    hand.Add(dealt_card);
                    Console.WriteLine("\nYou have been dealt the...");
                    dealt_card.Details();
                    Console.WriteLine("");
                }
                else if (choice == "2")
                {
                    hand.Check();
                }
                else if (choice == "3")
                {
                    hand.Fold();
                    Console.WriteLine("you have folded your hand and how your hand is empty");
                }
                else if (choice == "4")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("you did not enter a valaid response, try again");
                }
            }

        }
    }
}
