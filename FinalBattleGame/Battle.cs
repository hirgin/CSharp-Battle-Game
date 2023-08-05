// See https://aka.ms/new-console-template for more information

class Battle
{
    CharacterParty _enemyParty;
    CharacterParty _playerParty;

    Battle(ref CharacterParty enemyParty, ref CharacterParty playerParty)
    {
        _enemyParty = enemyParty;
        _playerParty = playerParty;
    }
}