namespace PokemonBattler;

public class Grass : Pokemon
{
    public Grass(string name, int hitPoints, int attackDamage, string move = "tackle")
        : base(name, hitPoints, attackDamage, move) { }

    public override bool IsEffectiveAgainst(Pokemon opponent)
    {
        return opponent is Water;
    }

    public override bool IsWeakTo(Pokemon opponent)
    {
        return opponent is Fire;
    }
}
