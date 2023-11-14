using CodingChallenge.CardGame.Cards;
using System.Collections.Generic;

namespace CodingChallenge.CardGame.Shuffles;

public interface IShuffle
{
    void Shuffle(ref List<ICard> cards);
}
