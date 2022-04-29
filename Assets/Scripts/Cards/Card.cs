using PrsiOS.Cards.Enums;
using UnityEngine;

namespace PrsiOS.Cards
{
    public class Card
    {
        private CardSuit _suit;
        private CardValue _value;

        public Card(CardSuit suit, CardValue value)
        {
            _suit = suit;
            _value = value;
        }
    }
}