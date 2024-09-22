namespace PokemonBattler;

public class Grass : Pokemon
{
    public override string Type { get; } = "grass";

    public Grass(string name, int hitPoints, int attackDamage, string move = "tackle")
        : base(name, hitPoints, attackDamage, move) { }

    public override bool IsEffectiveAgainst(Pokemon pokemon)
    {
        return pokemon.Type == "water";
    }

    public override bool IsWeakTo(Pokemon pokemon)
    {
        return pokemon.Type == "fire";
    }
}
