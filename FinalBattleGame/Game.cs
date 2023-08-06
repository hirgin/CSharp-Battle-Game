// See https://aka.ms/new-console-template for more information

class Game
{
    private CharacterParty villainParty = new CharacterParty();
    private CharacterParty playerParty = new CharacterParty();
    private Character player = new Character("User",25, Mobs.PLAYER);
    public void startGame()
    {
        setPlayerName();
        Skeleton sam = new Skeleton("Skelly", 5, Mobs.SKELETON);
        villainParty.addToParty(sam);
       
        playerParty.addToParty(player);
    
        runGame();
    }

    public void runGame()
    {
        while (true)
        {
            Thread.Sleep(2500);
            partyMoves(villainParty);
            Console.WriteLine();
            partyMoves(playerParty);
            Console.WriteLine();
            playerParty.checkStatus();
            villainParty.checkStatus();
            villainParty.displayParty();
        }
    }

    public void partyMoves(CharacterParty party)
    {
        CharacterParty enemy = party == villainParty ? playerParty : villainParty;
        foreach (Character character in party._party) 
        {
            chooseMove(character,enemy);
        }
    }



    public void chooseMove(Character character, CharacterParty enemy)
    {
        Console.WriteLine($"It is {character._name}'s turn...");
        GameMoves.attackMove(character, enemy.getFirstInParty());
    }

    private void setPlayerName()
    {
        Console.WriteLine("What is your name player?");

        player.setName(Console.ReadLine());
    }

}