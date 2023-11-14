using CodingChallenge.CardGame.Cards;
using System;
using System.Collections;
using System.Collections.Generic;

namespace CodingChallenge.CardGame;

public class PackOfCards : IPackOfCards
{
    private readonly List<ICard> cards;

    public PackOfCards(List<ICard> cards)
    {
        this.cards = cards;
    }

    public int Count => cards.Count;

    public void Shuffle()
    {
        throw new NotImplementedException();
    }

    public ICard TakeCardFromTopOfPack()
    {
        if (cards.Count == 0)
        {
            return null;
        }

        ICard topCard = cards[0];
        cards.RemoveAt(0);

        return topCard;
    }

    public IEnumerator<ICard> GetEnumerator()
    {
        return cards.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}