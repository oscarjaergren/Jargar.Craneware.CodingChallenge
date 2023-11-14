using CodingChallenge.CardGame.CardDeckCreator;
using CodingChallenge.CardGame.Cards;
using NUnit.Framework;
using System;
using System.Linq;

namespace CodingChallenge.CardGame.Tests.PackOfCards;

internal sealed class TakeCardFromTopOfPackTests
{
    // Test 3: Test that a card is removed from the deck
    [Test]
    public void Take_Card_From_Top_Of_Pack_Removes_Card()
    {
        IPackOfCardsCreator packCreator = new PackOfCardCreator();
        var cardPack = packCreator.Create();
        int initialCount = cardPack.Count;

        ICard firstCard = cardPack.ElementAt(0);
        ICard takenCard = cardPack.TakeCardFromTopOfPack();

        Assert.IsFalse(cardPack.Contains(takenCard), "The taken card should be removed from the pack.");
        Assert.AreEqual(initialCount - 1, cardPack.Count, "The pack count should decrease by 1 after taking a card.");
        Assert.AreEqual(firstCard, takenCard, "The taken card should be the first card in the original order.");
    }
}
