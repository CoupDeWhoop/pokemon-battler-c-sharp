namespace PokemonBattler;

public class Water : Pokemon
{
    public override string Type { get; } = "water";

    public Water(string name, int hitPoints, int attackDamage, string move = "tackle")
        : base(name, hitPoints, attackDamage, move) { }

    public override bool IsEffectiveAgainst(Pokemon pokemon)
    {
        return pokemon.Type == "fire";
    }

    public override bool IsWeakTo(Pokemon pokemon)
    {
        return pokemon.Type == "grass";
    }
}
