using CodingChallenge.CardGame.Card;
using CodingChallenge.CardGame.CardDeckCreator;
using NUnit.Framework;
using NUnit.Framework.Internal;
using System.Linq;

namespace CodingChallenge.CardGame.Tests;

[TestFixture]
public class CardGameTests
{
    //ToDo: Refactor tests to be better split up into sub tests (at least some of them) 

    //Test 1, test there are 52 card
    //Test 2, test there are only unique entries
    [Test]
    public void PackOfCards_Creation_Ensures_Correct_Number_And_Uniqueness()
    {
        IPackOfCardsCreator packCreator = new PackOfCardCreator();
        var cardPack = packCreator.Create();

        Assert.AreEqual(52, cardPack.Count, "The pack should contain 52 cards.");

        var distinctCards = cardPack.Distinct().ToList();
        Assert.AreEqual(cardPack.Count, distinctCards.Count, "All cards in the pack should be unique.");
    }

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

    // We could create further tests on this to actually check how the shuffle was done,
    // but then we would need to put a seed into our shuffle and that would affect the potential implementation of it.
    [Test]
    public void Test_Shuffle_Method_Shuffles_Cards()
    {
        IPackOfCardsCreator packCreator = new PackOfCardCreator();
        var cardPack = packCreator.Create();
        var originalOrder = cardPack.ToList();

        cardPack.Shuffle();
        var shuffledOrder = cardPack.ToList();

        Assert.AreNotEqual(originalOrder, shuffledOrder, "The shuffled order should be different from the original order.");
    }
}
