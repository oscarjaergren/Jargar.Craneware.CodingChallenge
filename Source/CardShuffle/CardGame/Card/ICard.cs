using System;

namespace CodingChallenge.CardGame.Card;

public interface ICard : IEquatable<ICard>
{
    Suit Suit { get; }

    Value Value { get; }
}
