using System;
using System.Collections.Generic;

namespace Blackjack
{
    public class Deck
    {
        private List<Card> cards;

        public Deck()
        {
            cards = new List<Card>();
            for (int i = 1; i <= 10; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    cards.Add(new Card(i));
                }
            }
            Shuffle();
        }

        public void Shuffle()
        {
            Random random = new Random();
            for (int i = 0; i < cards.Count; i++)
            {
                int randomIndex = random.Next(i, cards.Count);
                Card temp = cards[i];
                cards[i] = cards[randomIndex];
                cards[randomIndex] = temp;
            }
        }

        public Card Deal()
        {
            Card card = cards[0];
            cards.RemoveAt(0);
            return card;
        }

        internal int DrawCard()
        {
            return Deal().GetValue();
        }
    }
}