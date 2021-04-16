using System;
using System.Collections.Generic;
using System.Text;
//using System.Linq;

namespace Assessment_2
{
    class Card
    {
        //attributes for the value of the card and suit. also has a dictionary for naming purposes which does not change
        private int Value;
        private string Suit;
        private Dictionary<int, string> Value_To_Name = new Dictionary<int, string> { { 1, "Ace" }, { 11, "Jack" }, { 12, "Queen" }, { 13, "King" } };

        //getters and setters
        //removed getters and setters

        public Card(string suit, int val)
        {
            Value = val;
            Suit = suit;
        }

        //prints out the details of the cards by making use of excepotion handling to allow named cards eg indtead of 1 its ace.
        public void Details()
        {

            if (Value_To_Name.ContainsKey(Value))       //checks if the dictionary contains the key whic is one of the values.
                Console.WriteLine($"{Value_To_Name[Value]} of {Suit}");
            else
                Console.WriteLine($"{Value} of {Suit}");
        }

    }
}
