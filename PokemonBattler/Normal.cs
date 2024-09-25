namespace PokemonBattler;

public class Normal : Pokemon
{
    public Normal(string name, int hitPoints, int attackDamage, string move = "tackle")
        : base(name, hitPoints, attackDamage, move) { }

    public override bool IsEffectiveAgainst(Pokemon opponent) => false;

    public override bool IsWeakTo(Pokemon opponent) => false;
}
