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

    [Test]
    public void TakeDamage_reducesHitPointsCorrectly()
    {
        var pokemon = new Pokemon("Pikachu", 80, 20, "Thunderbolt");

        pokemon.TakeDamage(10);

        Assert.That(pokemon.HitPoints, Is.EqualTo(70));
    }

    [Test]
    public void UseMove_returnsAttackDamage()
    {
        var pokemon = new Pokemon("Pikachu", 80, 20, "Thunderbolt");

        var damage = pokemon.UseMove();

        Assert.That(damage, Is.EqualTo(20));
    }

    [Test]
    public void HasFainted_returnsFalse_IfHitpointsAboveZero()
    {
        var pokemon = new Pokemon("Pikachu", 80, 20, "Thunderbolt");

        var hasFainted = pokemon.HasFainted();

        Assert.That(hasFainted, Is.EqualTo(false));
    }    

    [Test]
    public void HasFainted_returnsTrue_IfHitpointsZero()
    {
        var pokemon = new Pokemon("Pikachu", 80, 20, "Thunderbolt");

        pokemon.TakeDamage(80);
        var hasFainted = pokemon.HasFainted();

        Assert.That(hasFainted, Is.EqualTo(true));
    }       
}