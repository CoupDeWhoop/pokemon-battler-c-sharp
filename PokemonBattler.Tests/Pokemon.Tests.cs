namespace PokemonBattler.Tests;

public class PokemonTests
{

    [Test]
    public void pokemon_properties_create_correctly()
    {
        string expectedName = "Pikachu";
        int expectedHitPoints = 100;
        int expectedAttackDamage = 50;
        string expectedMove = "Thunderbolt";

        var pokemon = new Normal(expectedName, expectedHitPoints, expectedAttackDamage, expectedMove);

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

        var pokemon = new Normal(expectedName, expectedHitPoints, expectedAttackDamage);

        Assert.That(pokemon.Name, Is.EqualTo(expectedName));
        Assert.That(pokemon.HitPoints, Is.EqualTo(expectedHitPoints));
        Assert.That(pokemon.AttackDamage, Is.EqualTo(expectedAttackDamage));
        Assert.That(pokemon.Move, Is.EqualTo("tackle"));
    }

    [Test]
    public void TakeDamage_reducesHitPointsCorrectly()
    {
        var pokemon = new Fire("Pikachu", 80, 20, "Thunderbolt");

        pokemon.TakeDamage(10);

        Assert.That(pokemon.HitPoints, Is.EqualTo(70));
    }

    [Test]
    public void UseMove_returnsAttackDamage()
    {
        var pokemon = new Grass("Pikachu", 80, 20, "Thunderbolt");

        var damage = pokemon.UseMove();

        Assert.That(damage, Is.EqualTo(20));
    }

    [Test]
    public void HasFainted_returnsFalse_IfHitpointsAboveZero()
    {
        var pokemon = new Water("Pikachu", 80, 20, "Thunderbolt");

        var hasFainted = pokemon.HasFainted();

        Assert.That(hasFainted, Is.EqualTo(false));
    }

    [TestCase(80)]
    [TestCase(100)]
    public void HasFainted_returnsTrue_IfHitpointsZero(int damage)
    {
        var pokemon = new Normal("Pikachu", 80, 20, "Thunderbolt");

        pokemon.TakeDamage(damage);
        var hasFainted = pokemon.HasFainted();

        Assert.That(hasFainted, Is.EqualTo(true));
    }
}

public class FireTests
{

    private Fire _fire;

    [SetUp]
    public void Setup()
    {
        _fire = new Fire("Firemon", 80, 20);
    }

    [Test]
    public void IsEffectiveAgainst_returnsCorrectly_whenStrongToOpponent()
    {
        var grassmon = new Grass("Grassmon", 80, 20);

        var effective = _fire.IsEffectiveAgainst(grassmon);

        Assert.That(effective, Is.EqualTo(true));
    }

    [Test]
    public void IsEffectiveAgainst_returnsCorrectly_whenNotStrongToOpponent()
    {
        var normon = new Normal("Normon", 80, 20);

        var effective = _fire.IsEffectiveAgainst(normon);

        Assert.That(effective, Is.EqualTo(false));
    }

    [Test]
    public void IsWeakTo_returnsCorrectly_whenWeakToOpponent()
    {
        var water = new Water("Watermon", 80, 20);

        var weakTo = _fire.IsWeakTo(water);

        Assert.That(weakTo, Is.EqualTo(true));
    }

    [Test]
    public void IsWeakTo_returnsCorrectly_whenNotWeakToOpponent()
    {
        var normal = new Normal("Normon", 80, 20);

        var weakTo = _fire.IsWeakTo(normal);

        Assert.That(weakTo, Is.EqualTo(false));
    }
}

public class GrassTests
{

    private Grass _grass;

    [SetUp]
    public void Setup()
    {
        _grass = new Grass("Grassmon", 80, 20);
    }

    [Test]
    public void IsEffectiveAgainst_returnsCorrectly_whenStrongToOpponent()
    {
        var water = new Water("Grassmon", 80, 20);

        var effective = _grass.IsEffectiveAgainst(water);

        Assert.That(effective, Is.EqualTo(true));
    }

    [Test]
    public void IsEffectiveAgainst_returnsCorrectly_whenNotStrongToOpponent()
    {
        var normal = new Normal("Normon", 80, 20);

        var effective = _grass.IsEffectiveAgainst(normal);

        Assert.That(effective, Is.EqualTo(false));
    }

    [Test]
    public void IsWeakTo_returnsCorrectly_whenWeakToOpponent()
    {
        var fire = new Fire("Firemon", 80, 20);

        var weakTo = _grass.IsWeakTo(fire);

        Assert.That(weakTo, Is.EqualTo(true));
    }

    [Test]
    public void IsWeakTo_returnsCorrectly_whenNotWeakToOpponent()
    {
        var normal = new Normal("Normon", 80, 20);

        var weakTo = _grass.IsWeakTo(normal);

        Assert.That(weakTo, Is.EqualTo(false));
    }
}

public class WaterTests
{

    private Water _water;

    [SetUp]
    public void Setup()
    {
        _water = new Water("Watermon", 80, 20);
    }

    [Test]
    public void IsEffectiveAgainst_returnsCorrectly_whenStrongToOpponent()
    {
        var fire = new Fire("Firemon", 80, 20);

        var effective = _water.IsEffectiveAgainst(fire);

        Assert.That(effective, Is.EqualTo(true));
    }

    [Test]
    public void IsEffectiveAgainst_returnsCorrectly_whenNotStrongToOpponent()
    {
        var grass = new Grass("Grassmon", 80, 20);

        var effective = _water.IsEffectiveAgainst(grass);

        Assert.That(effective, Is.EqualTo(false));
    }

    [Test]
    public void IsWeakTo_returnsCorrectly_whenWeakToOpponent()
    {
        var grass = new Grass("Grassmon", 80, 20);

        var weakTo = _water.IsWeakTo(grass);

        Assert.That(weakTo, Is.EqualTo(true));
    }

    [TestCase()]
    public void IsWeakTo_returnsCorrectly_whenNotWeakToOpponent()
    {
        var fire = new Fire("Firemon", 80, 20);
        var normal = new Normal("Normon", 80, 20);

        var weakToFire = _water.IsWeakTo(fire);
        var weakToNormal = _water.IsWeakTo(normal);

        Assert.That(weakToFire, Is.EqualTo(false));
        Assert.That(weakToNormal, Is.EqualTo(false));
    }
}

public class NormalTests
{

    private Normal _normal;

    [SetUp]
    public void Setup()
    {
        _normal = new Normal("Normon", 80, 20);
    }

    [Test]
    public void IsEffectiveAgainst_returnsCorrectly_whenNotStrongToOpponent()
    {
        var grass = new Grass("Grassmon", 80, 20);

        var effective = _normal.IsEffectiveAgainst(grass);

        Assert.That(effective, Is.EqualTo(false));
    }

    [TestCase()]
    public void IsWeakTo_returnsCorrectly_whenNotWeakToOpponent()
    {
        var fire = new Fire("Firemon", 80, 20);
        var normal = new Normal("Normon", 80, 20);

        var weakToFire = _normal.IsWeakTo(fire);
        var weakToNormal = _normal.IsWeakTo(normal);

        Assert.That(weakToFire, Is.EqualTo(false));
        Assert.That(weakToNormal, Is.EqualTo(false));
    }
}