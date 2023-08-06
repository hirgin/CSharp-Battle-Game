// See https://aka.ms/new-console-template for more information

class GameMoves
{
    public static void doNothing(Character character) { MoveMessages.doNothing(character); }

    public static void attackMove(Character attacker, Character defender)
    {
        Random random = new Random();
        int dmg;
        switch (attacker._type) 
        {

            case Mobs.SKELETON:
                dmg = random.Next(2);
                Console.WriteLine($"{attacker._name} used BONE CRUNCH on {defender._name}");
                Console.WriteLine($"BONE CRUNCH dealt {dmg} to {defender._name}");
                defender.takeDamage(dmg);
                defender.displayHP();
                break;
            case Mobs.PLAYER:
                dmg = 1;
                Console.WriteLine($"{attacker._name} used PUNCH on {defender._name}");
                Console.WriteLine($"PUNCH dealt {dmg} to {defender._name}");
                defender.takeDamage(dmg);
                defender.displayHP();
                break;
        
        }
    }



}