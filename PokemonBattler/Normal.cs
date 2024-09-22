namespace PokemonBattler;

public class Normal : Pokemon
{
    public override string Type { get; } = "normal";

    public Normal(string name, int hitPoints, int attackDamage, string move = "tackle")
        : base(name, hitPoints, attackDamage, move) { }

    public override bool IsEffectiveAgainst(Pokemon pokemon) => false;

    public override bool IsWeakTo(Pokemon pokemon) => false;
}
