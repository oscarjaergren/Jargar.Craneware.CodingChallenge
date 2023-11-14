using CodingChallenge.CardGame.CardDeckCreator;
using NUnit.Framework;
using System.Linq;

namespace CodingChallenge.CardGame.Tests.PackOfCards;
internal class ShuffleTests
{
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
