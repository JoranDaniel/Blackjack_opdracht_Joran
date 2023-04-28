using System;

class Program // dit is de class Program
{
    static void Main(string[] args) // dit is de methode Main, deze methode wordt als eerste uitgevoerd
    {
        Game game = new Game(); // hiermee wordt de class Game aangeroepen
        game.Start(); // hiermee wordt de methode Start aangeroepen
        Console.WriteLine("Bedankt voor het spelen!");
    }
}
