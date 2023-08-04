// See https://aka.ms/new-console-template for more information

class Game
{
    private CharacterParty eParty = new CharacterParty();
    private CharacterParty fParty = new CharacterParty();
    private Character player = new Character("User",100);
    public void startGame()
    {
        setPlayerName();
        Skeleton sam = new Skeleton("Skelly", 50);
        eParty.addToParty(sam);
        eParty.displayParty();
        fParty.addToParty(player);
        fParty.displayParty();
        runGame();
    }

    public void runGame()
    {
        partyMoves(eParty);
        partyMoves(fParty);
    }
    public void gameLoop()
    {

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
        Skeleton.doNothing(character);
    }

    private void setPlayerName()
    {
        Console.WriteLine("What is your name player?");

        player.setName(Console.ReadLine());
    }

}