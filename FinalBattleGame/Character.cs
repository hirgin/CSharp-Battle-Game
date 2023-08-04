// See https://aka.ms/new-console-template for more information
class Character
{
    public string _name { get; private set; }
    public int _health { get; private set; }


    public Character(string name, int health)
    {
        _name = name;
        _health = health;
    }

    public void setName (string name) { _name = name; }
}
