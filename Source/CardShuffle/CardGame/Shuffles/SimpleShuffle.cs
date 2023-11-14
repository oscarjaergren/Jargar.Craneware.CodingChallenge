using CodingChallenge.CardGame.Cards;
using System.Collections.Generic;

namespace CodingChallenge.CardGame.Shuffles;

internal class SimpleShuffle : IShuffle
{
    //Only available in .net 8, which might be available by the time I submit this code
    public void Shuffle(ref List<ICard> cards)
    {
        //  Random random = new();
        //  random.Shuffle(cards);
    }
}
