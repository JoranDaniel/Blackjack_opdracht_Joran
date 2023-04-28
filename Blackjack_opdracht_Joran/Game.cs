using System;
using System.Numerics;


public class Game // we maken een class aan genaamd Game, deze class zorgt ervoor dat het spel wordt gespeeld
{
    private Dealer dealer; //dit is een private Dealer genaamd dealer
    private Player player; // dit is een private Player genaamd player
    private Blackjack.Deck deck;// dit is een private Deck genaamd deck

    public Game() // dit is de constructor van de class Game, deze constructor zorgt ervoor dat de dealer, player en deck worden aangemaakt
    {
        dealer = new Dealer();// hiermee wordt de dealer aangemaakt
        player = new Player();// hiermee wordt de player aangemaakt
        deck = new Blackjack.Deck(); // hiermee wordt het deck aangemaakt
        deck.Shuffle(); // deze methode zorgt ervoor dat de kaarten worden geschud
    }

    public void Start() // dit is de methode Start van de class Game, deze methode zorgt ervoor dat het spel wordt gestart
    {
        Console.WriteLine("Welkom bij Blackjack Erik!");

        // Eerste kaarten
        player.ReceiveCard(deck.DrawCard()); // hiermee wordt de methode ReceiveCard aangeroepen en wordt er een kaart gepakt
        player.ReceiveCard(deck.DrawCard()); // hiermee wordt de methode ReceiveCard aangeroepen en wordt er een kaart gepakt
        dealer.Score += deck.DrawCard(); // hiermee wordt de score van de dealer opgehaald en wordt er een kaart gepakt
        dealer.Score += deck.DrawCard(); // hiermee wordt de score van de dealer opgehaald en wordt er een kaart gepakt

        Console.WriteLine("Jouw score is " + player.Score); // hiermee wordt de score van de speler opgehaald
        Console.WriteLine("De dealer heeft een " + dealer.Score); // dit zorgt ervoor dat de score van de dealer wordt opgehaald

        // Beurt van de speler
        while (true) // dit is een while loop, deze loop zorgt ervoor dat de speler een keuze kan maken
        {
            Console.WriteLine("Wat wil je doen? (hit/stand)");
            string keuze = Console.ReadLine().ToLower(); // dit zorgt ervoor dat de speler een keuze kan maken
            if (keuze == "hit") // dit if statement zorgt ervoor dat als de speler voor hit kiest dat hij dan een kaart pakt
            {
                player.ReceiveCard(deck.DrawCard()); // hiermee wordt de methode ReceiveCard aangeroepen en wordt er een kaart gepakt
                Console.WriteLine("Jouw score is " + player.Score); // hiermee wordt de score van de speler opgehaald
                if (player.Score > 21) // dit if statement zorgt ervoor dat als de speler boven de 21 komt dat hij dan busted is
                {
                    Console.WriteLine("Je bent busted!");
                    Console.WriteLine("De dealer heeft gewonnen!");
                    return; // dit zorgt ervoor dat de methode wordt afgesloten
                }
            }
            else if (keuze == "stand") // dit if statement zorgt ervoor dat als de speler voor stand kiest dat hij dan geen kaart pakt
            {
                break;// dit zorgt ervoor dat de while loop stopt
            }
            else // dit else statement zorgt ervoor dat als de speler een ongeldige keuze maakt dat hij dan een foutmelding krijgt
            {
                Console.WriteLine("Ongeldige keuze. Probeer opnieuw."); // dit zorgt ervoor dat de speler een foutmelding krijgt
            }
        }

        // Beurt van de dealer
        dealer.PlayTurn(deck); // hiermee wordt de methode PlayTurn aangeroepen

        // Resultaten tonen
        Console.WriteLine("Jouw score is " + player.Score);
        Console.WriteLine("De dealer heeft een score van " + dealer.Score);

        if (player.Score > dealer.Score) // dit if statement zorgt ervoor dat als de speler een hogere score heeft dan de dealer dat hij dan wint
        {
            Console.WriteLine("Gefeliciteerd, je hebt gewonnen!"); // dit zorgt ervoor dat de speler een melding krijgt dat hij heeft gewonnen
        }
        else if (dealer.Score > player.Score) // dit if statement zorgt ervoor dat als de dealer een hogere score heeft dan de speler dat hij dan wint
        {
            Console.WriteLine("Helaas, de dealer heeft gewonnen.");
        }
        else // dit else statement zorgt ervoor dat als de speler en de dealer dezelfde score hebben dat het een gelijkspel is
        {
            Console.WriteLine("Het is een gelijkspel.");
        }

        Console.WriteLine("Bedankt voor het spelen!");
    }
}
