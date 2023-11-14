using System;

namespace CodingChallenge.CardGame.Cards;

public interface ICard : IEquatable<ICard>
{
    Suit Suit { get; }

    Value Value { get; }
}
