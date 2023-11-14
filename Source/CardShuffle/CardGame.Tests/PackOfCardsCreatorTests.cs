using CodingChallenge.CardGame.CardDeckCreator;
using NUnit.Framework;
using System.Linq;

namespace CodingChallenge.CardGame.Tests;

internal class PackOfCardsCreatorTests
{
    [Test]
    public void PackOfCards_Creation_Ensures_Correct_Number()
    {
        IPackOfCardsCreator packCreator = new PackOfCardCreator();
        var cardPack = packCreator.Create();

        Assert.AreEqual(52, cardPack.Count, "The pack should contain 52 cards.");
    }

    [Test]
    public void PackOfCards_Creation_Ensures_Uniqueness()
    {
        IPackOfCardsCreator packCreator = new PackOfCardCreator();
        var cardPack = packCreator.Create();

        var distinctCards = cardPack.Distinct().ToList();

        Assert.AreEqual(cardPack.Count, distinctCards.Count, "All cards in the pack should be unique.");
    }
}
