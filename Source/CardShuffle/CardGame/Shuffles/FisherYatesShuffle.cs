using CodingChallenge.CardGame.Cards;
using System;
using System.Collections.Generic;

namespace CodingChallenge.CardGame.Shuffles;

internal sealed class FisherYatesShuffle : IShuffle
{
    //  http://en.wikipedia.org/wiki/Fisher-Yates_shuffle
    //  O(N) Time complexity
    public void Shuffle(ref List<ICard> cards)
    {
        Random random = new();
        int n = cards.Count;
        while (n > 1)
        {
            n--;
            int k = random.Next(n + 1);
            (cards[n], cards[k]) = (cards[k], cards[n]);
        }
    }
}
