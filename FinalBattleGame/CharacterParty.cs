// See https://aka.ms/new-console-template for more information
class CharacterParty
{
    public List<Character> _party { get; private set; } = new List<Character>();
   
    public void addToParty(Character character)
    {
        _party.Add(character);
    }

    public Character getFirstInParty()
    {
        return _party[0];
    }

    public void checkStatus() // function that checks if members of the party have died or if the entire party has died
    {
        for(int i = 0; i < _party.Count; i++) 
        {
            if (_party[i] != null  && _party[i].deathCheck())
            {
                _party.RemoveAt(i);
                Console.WriteLine("REMOVED");
                i--;
                
            }
        }
        if ( _party.Count <= 0 ) { Console.WriteLine($"{_party} has won!"); Environment.Exit(1); }
    }

    public void removeFromParty(Character character) { _party.Remove(character); }

    public void displayParty()
    {
        foreach (Character character in _party)
        {
            Console.WriteLine($"{character._name} ");
        }
    }
}
