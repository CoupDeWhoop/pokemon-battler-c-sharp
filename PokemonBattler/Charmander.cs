namespace PokemonBattler;

public class Charmander: Fire
{
    public Charmander(string name, int hitPoints, int attackDamage)
    : base(name, hitPoints, attackDamage)
    {
        Move = "ember";
    }
}
