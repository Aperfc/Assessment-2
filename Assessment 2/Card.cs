using System;
using System.Collections.Generic;
using System.Text;
//using System.Linq;

namespace Assessment_2
{
    class Card
    {
        private int Value;
        private string Suit;
        private Dictionary<int, string> Value_To_Name = new Dictionary<int, string> { { 1, "Ace" }, { 11, "Jack" }, { 12, "Queen" }, { 13, "King" } };
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
