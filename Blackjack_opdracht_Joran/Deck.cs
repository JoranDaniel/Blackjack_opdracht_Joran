using System;
using System.Collections.Generic;
using System.Net.Mime;

namespace Blackjack
{
    public class Deck // in deze class wordt een deck gemaakt met 52 kaarten
    {
        private List<Card> cards; // dit is een private List genaamd cards

        public Deck() // dit is de constructor van de class Deck, deze zorgt ervoor dat er een deck wordt gemaakt met 52 kaarten
        {
            cards = new List<Card>(); // deze maakt een nieuwe List aan genaamd cards
            for (int i = 1; i <= 10; i++) // dit is een for loop die ervoor zorgt dat er 10 kaarten worden toegevoegd aan het deck
            {
                for (int j = 0; j < 4; j++) // dit is een for loop die ervoor zorgt dat er 4 kaarten van elke soort worden toegevoegd aan het deck
                {
                    cards.Add(new Card(i)); // dit voegt de kaarten toe aan het deck
                }
            }
            Shuffle(); // dit zorgt ervoor dat de kaarten worden geschud, deze word aangeroepen in de constructor zodat de kaarten worden geschud als het deck wordt gemaakt
        }

        public void Shuffle() // deze methode zorgt ervoor dat de kaarten worden geschud doormiddel van een randomizer
        {
            Random random = new Random();  // deze maakt een nieuwe randomizer aan, en deze wordt gebruikt om de kaarten te schudden
            for (int i = 0; i < cards.Count; i++) // ook hier wordt een for loop gebruikt om de kaarten te schudden, en deze wordt gebruikt om de kaarten te schudden
            {
                int randomIndex = random.Next(i, cards.Count); // dit heb je nodig om de kaarten te schudden, en dit zorgt ervoor dat de kaarten worden geschud
                Card temp = cards[i]; // dit zorgt ervoor dat de kaarten worden geschud
                cards[i] = cards[randomIndex]; // dit heb je nodig om de kaarten te schudden, en dit zorgt ervoor dat de kaarten worden geschud
                cards[randomIndex] = temp; // cards[randomIndex] = temp zorgt voor de shuffle
            }
        }

        public Card Deal() // deze class is voor het delen van de kaarten, dit zorgt ervoor dat de kaarten worden gedeeld
        {
            Card card = cards[0]; // dit zorgt ervoor dat de kaarten worden gedeeld
            cards.RemoveAt(0);
            return card; // deze return zorgt ervoor dat de kaarten worden gedeeld
        }

        internal int DrawCard() // dit is een internal int genaamd DrawCard, een internal int is een int die alleen in de class Deck gebruikt kan worden
        {
            return Deal().GetValue(); // dit zorgt ervoor dat de kaarten worden gedeeld
        }
    }
}
