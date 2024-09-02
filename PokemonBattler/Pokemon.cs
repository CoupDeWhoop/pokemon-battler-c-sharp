namespace PokemonBattler;

public class Pokemon
{
    public string Name;
    public int HitPoints;
    public int AttackDamage;
    public string Move;

    public Pokemon(string name, int hitPoints, int attackDamage, string move = "tackle")
    {
        Name = name;
        HitPoints = hitPoints;
        AttackDamage = attackDamage;
        Move = move;
    }

    public void TakeDamage(int damage)
    {
        HitPoints -= damage;
    }

    public int UseMove()
    {
        Console.WriteLine($"{Name} used {Move}");
        return AttackDamage;
    }

    public bool HasFainted() => HitPoints <= 0;
    
}
