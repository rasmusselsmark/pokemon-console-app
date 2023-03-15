# Fang en Pokémon

(Example project in Danish for teaching C# fundamentals, used as part of Danish non-profit organization [Coding Pirates](https://codingpirates.dk/in-english))

Simpelt eksempel spil for introduktion til C#

## Påkrævede værktøjer

Enten

* Visual Studio Community: https://visualstudio.microsoft.com/vs/community

eller

* .NET SDK: https://dotnet.microsoft.com/en-us/download/dotnet/7.0
* F.eks. Visual Studio Code: https://code.visualstudio.com/download

## Kom i gang

Visual Studio Community:

 * Opret et nyt C# projekt

Visual Studio Code:

* Kør følgende fra kommandolinje:
  ```
  mkdir PokemonFanger
  cd PokemonFanger
  dotnet new console
  ```

Du kan nu åbne `Program.cs` filen i Visual Studio Code

## Kør spillet

Visual Studio Community:

* Tryk F5 eller afspil knappen

Visual Studio Code:

* Kør følgende fra kommandolinje
  ```
  dotnet run
  ```

## Fremgangsmåde

1. Opret projektet og kør. Skulle gerne skrive "Hello, World!"
1. Ret teksten til `Velkommen til 'Fang en Pokémon!'`
1. Implementer `Pokemon` klasse med constructor og fields
   1. (Vent med `Catch()` metoden til senere)
   1. Tal om scope
1. Opret liste med pokemons og `ListPokemons()` til at skrive listen
1. Opret `playerStrength` variabel
1. `ReadNumber()` osv
1. Resten af programmet, med `while` løkke indtil man har fanget alle pokemons
