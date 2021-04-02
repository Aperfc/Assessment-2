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
        public int _Value 
        {
            get { return Value; }
            set { Value = value; }
        }
        public string _Suit
        {
            get { return Suit; }
            set { Suit = value; }
        }

        public Card(string suit, int val)
        {
            _Value = val;
            _Suit = suit;
        }

        //prints out the details of the cards by making use of excepotion handling to allow named cards eg indtead of 1 its ace.
        public void Details()
        {
            try
            {
                Console.WriteLine($"{Value_To_Name[Value]} of {Suit}");
            }
            catch (Exception)
            {
                Console.WriteLine($"{Value} of {Suit}");
            }
        }

    }
}
