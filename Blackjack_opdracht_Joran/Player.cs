using System;

public class Player
{
    public int Score { get; set; }

    public void ReceiveCard(int value)
    {
        Score += value;
    }
}
