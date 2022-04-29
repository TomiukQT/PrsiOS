using System.Collections.Generic;

namespace PrsiOS.Cards
{
	public interface IDeckGenerator
	{
		List<Card> GenerateDeck();
	}
}
