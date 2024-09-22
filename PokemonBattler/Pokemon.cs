namespace PokemonBattler;

public abstract class Pokemon
{
    public string Name { get; set; }
    public int HitPoints { get; set; }
    public int AttackDamage { get; set; }
    public string Move { get; set; }
    public virtual string Type { get; } = "normal";


    public Pokemon(string name, int hitPoints, int attackDamage, string move)
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

    public abstract bool IsEffectiveAgainst(Pokemon pokemon);

    public abstract bool IsWeakTo(Pokemon pokemon);

}
