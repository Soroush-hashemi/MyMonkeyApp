using System;
using MyMonkeyApp.Model;

namespace MyMonkeyApp.Data;

/// <summary>
/// Provides methods to retrieve monkey data.
/// </summary>
public static class MonkeyHelper
{
    private static readonly List<Monkey> Monkeys = new()
    {
        new Monkey { Name = "Capuchin", Location = "South America", Population = 50000 },
        new Monkey { Name = "Howler", Location = "Amazon Rainforest", Population = 10000 },
        new Monkey { Name = "Spider Monkey", Location = "Central America", Population = 25000 },
        new Monkey { Name = "Squirrel Monkey", Location = "South America", Population = 80000 },
        new Monkey { Name = "Orangutan", Location = "Borneo and Sumatra", Population = 120000 },
        new Monkey { Name = "Gorilla", Location = "Central Africa", Population = 100000 },
        new Monkey { Name = "Chimpanzee", Location = "West and Central Africa", Population = 300000 },
    };

    /// <summary>
    /// Gets all available monkeys.
    /// </summary>
    public static List<Monkey> GetMonkeys() => Monkeys;

    /// <summary>
    /// Gets a monkey by name (case-insensitive).
    /// </summary>
    public static Monkey? GetMonkeyByName(string name)
    {
        if (string.IsNullOrWhiteSpace(name))
            throw new ArgumentNullException(nameof(name));

        return Monkeys.FirstOrDefault(m =>
            m.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
    }

    /// <summary>
    /// Returns a random monkey from the list.
    /// </summary>
    public static Monkey GetRandomMonkey()
    {
        var random = new Random();
        return Monkeys[random.Next(Monkeys.Count)];
    }

    /// <summary>
    /// Gets the ASCII art representation for a specific monkey.
    /// </summary>
    /// <param name="name">The name of the monkey</param>
    /// <returns>Formatted ASCII art string</returns>
    public static string GetMonkeyAscii(string name)
    {
        return name.ToLower() switch
        {
            "capuchin" => @"
   /~\
  C oo
  _( ^)
 /   ~\",
            "howler" => @"
  .-""""-.
 /       \
|  HOWL  |
 \       /
  '-...-'",
            "spider monkey" => @"
   /\
  /  \
 /____\
  (oo)
  /\_/\
 ~~~~~~~",
            "squirrel monkey" => @"
   O
  /|\
  / \
  /\_/\
 (quick)",
            "orangutan" => @"
  .-""""""-.
 /  wise  \
(   ape    )
 \       /
  '-...-'",
            "gorilla" => @"
  .---.
 / KING \
|  OF    |
 \ JUNGLE/
  `---'",
            "chimpanzee" => @"
   O
  /|\
  / \
  ~~~
 (smart)",
            _ => @"
  .-.
 (o o)
  \_/
  /\_/\
"
        };
    }
}