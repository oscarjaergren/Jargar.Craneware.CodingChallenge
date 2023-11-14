using System.Collections.Generic;
using CodingChallenge.CardGame.Card;

namespace CodingChallenge.CardGame;

public interface IPackOfCards : IReadOnlyCollection<ICard>
{
    void Shuffle();

    ICard TakeCardFromTopOfPack();
}
