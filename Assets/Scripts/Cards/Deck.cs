using System.Collections.Generic;
using UnityEngine;

namespace PrsiOS.Cards
{
	public class Deck
	{
		private List<Card> _cards;

		private IDeckGenerator _deckGenerator;

		public Deck(IDeckGenerator deckGenerator)
		{
			_deckGenerator = deckGenerator;
		}
		
		/// <summary>
		/// Generation of new deck based on DeckGenerator
		/// </summary>
		public void Initialize()
		{
			_cards = _deckGenerator.GenerateDeck();
		}
		
		/// <summary>
		/// Shuffle the remaining cards in deck
		/// </summary>
		public void Shuffle()
		{
			for (int i = 0; i < _cards.Count; i++)
			{
				Card tmp = _cards[i];
				int randomIndex = Random.Range(0, _cards.Count);
				_cards[i] = _cards[randomIndex];
				_cards[randomIndex] = tmp;
			}
		}

		/// <summary>
		/// Draw a card from deck
		/// </summary>
		/// <returns> Drawed card or null if deck is empty</returns>
		public Card DrawCard()
		{
			if (this.Size <= 0)
				return null;
			Card card = _cards[0];
			_cards.RemoveAt(0);
			return card;
		}
		
		public void AddCard(Card card, int position = 0)
		

		public int Size => _cards.Count;

	}
}
