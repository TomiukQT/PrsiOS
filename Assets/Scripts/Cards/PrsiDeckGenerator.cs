using System;
using System.Collections.Generic;
using PrsiOS.Cards.Enums;

namespace PrsiOS.Cards
{
	public class PrsiDeckGenerator : IDeckGenerator
	{
		public List<Card> GenerateDeck()
		{
			List<Card> deck = new List<Card>();

			foreach (CardSuit suit in Enum.GetValues(typeof(CardSuit)))
				foreach (CardValue value in Enum.GetValues(typeof(CardValue)))
					deck.Add(new Card(suit,value));
			
			return deck;
		}
	}
}
