namespace PokemonBattler;

public class Pokemon
{
    public string Name;
    public int HitPoints;
    public int AttackDamage;
    public string Move;
    public virtual string Type { get; } = "normal";


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
    
    public virtual bool IsEffectiveAgainst(Pokemon pokemon)
    {
        return false;
    }

    public virtual bool IsWeakTo(Pokemon pokemon)
    {
        return false;
    }
}

public class Fire : Pokemon
{
    public override string Type { get;} = "fire";

    public Fire(string name, int hitPoints, int attackDamage, string move = "tackle") 
        : base(name, hitPoints, attackDamage, move){ }

    public override bool IsEffectiveAgainst(Pokemon pokemon)
    {
        return pokemon.Type == "grass";
    }

    public override bool IsWeakTo(Pokemon pokemon)
    {
        return pokemon.Type == "water";
    }
}

public class Grass : Pokemon
{
    public override string Type { get;} = "grass";

    public Grass(string name, int hitPoints, int attackDamage, string move = "tackle") 
        : base(name, hitPoints, attackDamage, move){ }

    public override bool IsEffectiveAgainst(Pokemon pokemon)
    {
        return pokemon.Type == "water";
    }

    public override bool IsWeakTo(Pokemon pokemon)
    {
        return pokemon.Type == "fire";
    }
}

public class Water : Pokemon
{
    public override string Type { get;} = "water";

    public Water(string name, int hitPoints, int attackDamage, string move = "tackle") 
        : base(name, hitPoints, attackDamage, move){ }

    public override bool IsEffectiveAgainst(Pokemon pokemon)
    {
        return pokemon.Type == "fire";
    }

    public override bool IsWeakTo(Pokemon pokemon)
    {
        return pokemon.Type == "grass";
    }
}

public class Normal : Pokemon
{
    public override string Type { get;} = "normal";

    public Normal(string name, int hitPoints, int attackDamage, string move = "tackle") 
        : base(name, hitPoints, attackDamage, move){ }

}
