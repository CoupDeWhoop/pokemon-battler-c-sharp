namespace PokemonBattler;

public class Fire : Pokemon
{
    public override string Type { get; } = "fire";

    public Fire(string name, int hitPoints, int attackDamage, string move = "tackle")
        : base(name, hitPoints, attackDamage, move) { }

    public override bool IsEffectiveAgainst(Pokemon pokemon)
    {
        return pokemon.Type == "grass";
    }

    public override bool IsWeakTo(Pokemon pokemon)
    {
        return pokemon.Type == "water";
    }
}
