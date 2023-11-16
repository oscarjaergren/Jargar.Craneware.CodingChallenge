namespace CodingChallenge.CardGame.Cards;

public class Card(Suit suit, Value value) : ICard
{
    public Suit Suit { get; } = suit;

    public Value Value { get; } = value;

    public bool Equals(ICard other)
    {
        if (other == null)
            return false;

        return Suit == other.Suit && Value == other.Value;
    }

    public override int GetHashCode()
    {
        return Suit.GetHashCode() ^ Value.GetHashCode();
    }
}