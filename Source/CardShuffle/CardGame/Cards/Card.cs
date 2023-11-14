namespace CodingChallenge.CardGame.Cards;

public class Card : ICard
{
    public Suit Suit { get; }
    public Value Value { get; }

    public Card(Suit suit, Value value)
    {
        Suit = suit;
        Value = value;
    }

    public bool Equals(ICard other)
    {
        if (other == null)
            return false;

        return Suit == other.Suit && Value == other.Value;
    }

    //ToDo: Consider this as potential implementations of Equals instead

    //public override bool Equals(object obj)
    //{
    //    if (obj is ICard otherCard)
    //    {
    //        return Equals(otherCard);
    //    }

    //    return false;
    //}

    //public override int GetHashCode()
    //{
    //    // Simple hash code combining the hash codes of Suit and Value
    //    return Suit.GetHashCode() ^ Value.GetHashCode();
    //}
}