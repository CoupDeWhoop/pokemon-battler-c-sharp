namespace PokemonBattler;

public class Pokemon
{
    public string Name;
    public int HitPoints;
    public int AttackDamage;
    public string Move;

    public Pokemon(string name, int hitPoints, int attackDamage, string move = "tackle")
    {
        Name = name;
        HitPoints = hitPoints;
        AttackDamage = attackDamage;
        Move = move;
    }
}
