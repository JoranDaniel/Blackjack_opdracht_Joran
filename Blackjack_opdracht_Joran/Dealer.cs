using System;

public class Dealer
{
    public int Score { get; set; }

    public void PlayTurn(Deck deck)
    {
        while (Score < 17)
        {
            Console.WriteLine("De dealer kiest voor hit");
            Score += deck.DrawCard();
            Console.WriteLine("De dealer heeft nu een score van " + Score);
            if (Score > 21)
            {
                Console.WriteLine("De dealer is busted!");
                break;
            }
        }
    }

    internal void PlayTurn(Blackjack.Deck deck)
    {
        return;
    }
}

public class Deck
{
    internal int DrawCard()
    {
        throw new NotImplementedException();
    }
}