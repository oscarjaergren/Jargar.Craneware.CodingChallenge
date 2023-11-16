using CodingChallenge.CardGame.Cards;
using CodingChallenge.CardGame.Shuffles;
using System.Collections;
using System.Collections.Generic;

namespace CodingChallenge.CardGame;

public class PackOfCards(List<ICard> cards, IShuffle shuffle) : IPackOfCards
{
    private List<ICard> _cards = cards;
    private readonly IShuffle _shuffle = shuffle;

    public int Count => _cards.Count;

    public ICard TakeCardFromTopOfPack()
    {
        if (_cards.Count == 0)
        {
            return null;
        }

        ICard topCard = _cards[0];
        _cards.RemoveAt(0);

        return topCard;
    }

    public IEnumerator<ICard> GetEnumerator()
    {
        return _cards.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Shuffle()
    {
        _shuffle.Shuffle(ref _cards);
    }
}