namespace Blackjack 
{
    public class Card // we maken een class aan genaamd Card
    {
        private int value; // we maken een private int aan genaamd value

        public Card(int value) // deze int value is de waarde van de kaart
        {
            this.value = value; // dit zorgt ervoor dat de waarde van de kaart wordt opgeslagen
        } // dit is de constructor van de class Card

        public int GetValue() // we maken een public int aan genaamd GetValue
        {
            return value; // dit zorgt ervoor dat de waarde van de kaart wordt teruggegeven
        } // dit is de methode GetValue van de class Card
    }
}
