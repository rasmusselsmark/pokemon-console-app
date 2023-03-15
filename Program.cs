Console.WriteLine("Velkommen til 'Fang en Pokémon!'");

// vores styrke (skal være højere end Pokemon man vil fange)
var playerStrength = 15;

// liste med Pokemons vi kan fange
var pokemons = new List<Pokemon>()
{
    new Pokemon("Pikachu", 10),
    new Pokemon("Jigglypuff", 30),
    new Pokemon("Magikarp", 15),
    new Pokemon("Wobbuffet", 50),
};

// fortsæt spillet så længe der er Pokemons
while (pokemons.Count > 0)
{
    ListPokemons(pokemons);

    Console.WriteLine();
    Console.WriteLine($"Din styrke: {playerStrength}");

    var catchPokemonIndex = ReadNumber(0, pokemons.Count - 1);
    var selectedPokemon = pokemons[catchPokemonIndex];

    Console.WriteLine();
    if (selectedPokemon.Catch(playerStrength))
    {
        Console.WriteLine($"🙂 Tillykke, du fangede {selectedPokemon.Name}! 🙂");
        playerStrength = playerStrength + selectedPokemon.CombatPower;
        pokemons.RemoveAt(catchPokemonIndex);
    }
    else
    {
        Console.WriteLine($"🙁 Desværre, {selectedPokemon.Name} var for stærk, så den slap væk! 🙁");
    }
}

Console.WriteLine();
Console.WriteLine("🎉🎉🎉 Spillet er slut, du har fanget alle Pokemons! 🎉🎉🎉");

void ListPokemons(List<Pokemon> list)
{
    Console.WriteLine();
    Console.WriteLine("Du kan se følgende Pokemons:");
    for (int i = 0; i < list.Count; i++)
    {
        var pokemon = list[i];
        Console.WriteLine($"#{i}: {pokemon.Name} ({pokemon.CombatPower})");
    }
}

int ReadNumber(int min, int max)
{
    while (true)
    {
        Console.Write("Hvilken Pokemon vil du fange? ");
        var input = Console.ReadLine();

        // check at vi indtastede integer / heltal
        if (int.TryParse(input, out int guess))
        {
            if (min <= guess && guess <= max)
            {
                return guess;
            }
        }

        Console.WriteLine($"Du skal indtaste et heltal mellem {min} og {max}.");
        Console.WriteLine();
    }
}

public class Pokemon
{
    public string Name { get; }
    public int CombatPower { get; }

    public Pokemon(string name, int combatPower)
    {
        Name = name;
        CombatPower = combatPower;
    }

    public bool Catch(int ballPower)
    {
        // vi fanger denne Pokemon, hvis vores nuværende styrke er højere end Pokemon
        if (ballPower > this.CombatPower)
        {
            return true;
        }

        return false;
    }
}
