// See https://aka.ms/new-console-template for more information
using System.Runtime.InteropServices;

class Character
{
    public string _name { get; private set; }
    public int _health { get; private set; }
    public Mobs _type;

    public Character(string name, int health, Mobs type)
    {
        _name = name;
        _health = health;
        _type = type;

    }
    public void takeDamage(int damage) // deals damage to current character based off parameter
    { 
        _health -= damage;
        deathCheck();
    }

    public void displayHP() { Console.WriteLine($"{_name} is at {_health}HP"); }


    public bool deathCheck()// checks if character health is below 0 and if they die 
    {
        if (_health <= 0) // if they have died, output it
        {
            Console.WriteLine($"{_name} has been defeated!");
            
            return true;
        }
        return false;

    }
       

    public void setName (string name) { _name = name; }
}
