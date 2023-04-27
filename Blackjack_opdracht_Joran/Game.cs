using System;
using System.Numerics;


public class Game
{
    private Dealer dealer;
    private Player player;
    private Blackjack.Deck deck;

    public Game()
    {
        dealer = new Dealer();
        player = new Player();
        deck = new Blackjack.Deck();
        deck.Shuffle();
    }

    public void Start() // Start() is called from Program.cs
    {
        Console.WriteLine("Welkom bij Blackjack Erik!");

        // Eerste kaarten
        player.ReceiveCard(deck.DrawCard());
        player.ReceiveCard(deck.DrawCard());
        dealer.Score += deck.DrawCard();
        dealer.Score += deck.DrawCard();

        Console.WriteLine("Jouw score is " + player.Score);
        Console.WriteLine("De dealer heeft een " + dealer.Score);

        // Beurt van de speler
        while (true)
        {
            Console.WriteLine("Wat wil je doen? (hit/stand)");
            string keuze = Console.ReadLine().ToLower();
            if (keuze == "hit")
            {
                player.ReceiveCard(deck.DrawCard());
                Console.WriteLine("Jouw score is " + player.Score);
                if (player.Score > 21)
                {
                    Console.WriteLine("Je bent busted!");
                    Console.WriteLine("De dealer heeft gewonnen!");
                    return;
                }
            }
            else if (keuze == "stand")
            {
                break;
            }
            else
            {
                Console.WriteLine("Ongeldige keuze. Probeer opnieuw.");
            }
        }

        // Beurt van de dealer
        dealer.PlayTurn(deck);

        // Resultaten tonen
        Console.WriteLine("Jouw score is " + player.Score);
        Console.WriteLine("De dealer heeft een score van " + dealer.Score);

        if (player.Score > dealer.Score)
        {
            Console.WriteLine("Gefeliciteerd, je hebt gewonnen!");
        }
        else if (dealer.Score > player.Score)
        {
            Console.WriteLine("Helaas, de dealer heeft gewonnen.");
        }
        else
        {
            Console.WriteLine("Het is een gelijkspel.");
        }

        Console.WriteLine("Bedankt voor het spelen!");
    }
}