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

    public void displayParty()
    {
        foreach (Character character in _party)
        {
            Console.WriteLine($"{character._name} ");
        }
    }
}
