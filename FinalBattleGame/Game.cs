// See https://aka.ms/new-console-template for more information

class Game
{
    private CharacterParty enemyParty = new CharacterParty();
    private CharacterParty playerParty = new CharacterParty();
    private Character player = new Character("User",100);
    public void startGame()
    {
        setPlayerName();
        Skeleton sam = new Skeleton("Skelly", 50);
        enemyParty.addToParty(sam);
        enemyParty.displayParty();
        playerParty.addToParty(player);
        playerParty.displayParty();
        runGame();
    }

    public void runGame()
    {
        while (true)
        {
            Thread.Sleep(1000);
            partyMoves(enemyParty);
            Console.WriteLine();
            partyMoves(playerParty);
            Console.WriteLine();
        }
    }

    public void partyMoves(CharacterParty party)
    {
        foreach (Character character in party._party) 
        {
            chooseMove(character);
        }
    }



    public void chooseMove(Character character)
    {
        Console.WriteLine($"It is {character._name}'s turn...");
        GameMoves.doNothing(character);
    }

    private void setPlayerName()
    {
        Console.WriteLine("What is your name player?");

        player.setName(Console.ReadLine());
    }

}