namespace PokemonBattler;

public class Water : Pokemon
{
    public Water(string name, int hitPoints, int attackDamage, string move = "tackle")
        : base(name, hitPoints, attackDamage, move) { }

    public override bool IsEffectiveAgainst(Pokemon opponent)
    {
        return opponent is Fire;
    }

    public override bool IsWeakTo(Pokemon opponent)
    {
        return opponent is Grass;
    }
}
