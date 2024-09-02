namespace PokemonBattler.Tests;

public class PokemonTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void pokemon_properties_create_correctly()
    {
        string expectedName = "Pikachu";
        int expectedHitPoints = 100;
        int expectedAttackDamage = 50;
        string expectedMove = "Thunderbolt";

        var pokemon = new Pokemon(expectedName, expectedHitPoints, expectedAttackDamage, expectedMove);

        Assert.That(pokemon.Name, Is.EqualTo(expectedName));
        Assert.That(pokemon.HitPoints, Is.EqualTo(expectedHitPoints));
        Assert.That(pokemon.AttackDamage, Is.EqualTo(expectedAttackDamage));
        Assert.That(pokemon.Move, Is.EqualTo(expectedMove));
    }

    [Test]
    public void pokemon_move_defaults_correctly()
    {
        string expectedName = "Pikachu";
        int expectedHitPoints = 100;
        int expectedAttackDamage = 50;

        var pokemon = new Pokemon(expectedName, expectedHitPoints, expectedAttackDamage);

        Assert.That(pokemon.Name, Is.EqualTo(expectedName));
        Assert.That(pokemon.HitPoints, Is.EqualTo(expectedHitPoints));
        Assert.That(pokemon.AttackDamage, Is.EqualTo(expectedAttackDamage));
        Assert.That(pokemon.Move, Is.EqualTo("tackle"));
    }
}