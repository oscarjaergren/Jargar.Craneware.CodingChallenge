using System.Collections.Generic;
using System;
using CodingChallenge.CardGame.Cards;

namespace CodingChallenge.CardGame.CardDeckCreator;

public class PackOfCardCreator : IPackOfCardsCreator
{
    public IPackOfCards Create()
    {
        List<ICard> cards = new();

        foreach (Suit suit in Enum.GetValues(typeof(Suit)))
        {
            foreach (Value value in Enum.GetValues(typeof(Value)))
            {
                cards.Add(new Card(suit, value));
            }
        }

        return new PackOfCards(cards);
    }
}
