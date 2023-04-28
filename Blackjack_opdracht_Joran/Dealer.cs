using System;

public class Dealer // we maken een class aan genaamd Dealer
{
    public int Score { get; set; } // dit is een public int genaamd Score

    public void PlayTurn(Deck deck) // dit is een public void genaamd PlayTurn
    {
        while (Score < 17) //zolang de score van de dealer kleiner is dan 17 dan gaat de dealer een kaart pakken
        {
            Console.WriteLine("De dealer kiest voor hit");
            Score += deck.DrawCard(); // de dealer pakt een kaart
            Console.WriteLine("De dealer heeft nu een score van " + Score); // de dealer laat zijn score zien
            if (Score > 21) // dit if statement zorgt ervoor dat als de dealer boven de 21 komt dat hij dan busted is
            {
                Console.WriteLine("De dealer is busted!");
                break; // dit zorgt ervoor dat de while loop stopt
            }
        }
    }

    internal void PlayTurn(Blackjack.Deck deck) // hier wordt de methode PlayTurn aangeroepen
    {
        return;  // en hier wordt de methode PlayTurn aangeroepen en wordt er een kaart gepakt
    }
}

public class Deck  // Dit is een class genaamd Deck
{
    internal int DrawCard() // dit is een internal int genaamd DrawCard, een internal int is een int die alleen in de class Deck gebruikt kan worden
    {
        throw new NotImplementedException(); // hier wordt een exception gegooid, dit is een foutmelding voor de compiler die aangeeft dat de methode nog niet is geïmplementeerd.
    }
} // deze class zorgt ervoor dat er een deck wordt gemaakt met 52 kaarten.


