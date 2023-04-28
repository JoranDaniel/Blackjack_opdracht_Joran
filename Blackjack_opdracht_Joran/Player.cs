using System;

public class Player // we maken een class aan genaamd Player, deze class is voor de speler
{
    public int Score { get; set; } // dit is een public int genaamd Score, deze int is voor de score van de speler

    public void ReceiveCard(int value) // dit is een public void genaamd ReceiveCard, deze void zorgt ervoor dat de speler een kaart krijgt
    {
        Score += value; // dit zorgt ervoor dat de waarde van de kaart wordt opgeteld bij de score van de speler
    }
}
