using System.Collections.Generic;
using CodingChallenge.CardGame.Cards;

namespace CodingChallenge.CardGame;

public interface IPackOfCards : IReadOnlyCollection<ICard>
{
    void Shuffle();

    ICard TakeCardFromTopOfPack();
}
