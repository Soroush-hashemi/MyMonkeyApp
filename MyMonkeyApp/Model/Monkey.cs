using System;

namespace MyMonkeyApp.Model;

public class Monkey
{
    public Monkey(string name, string location, int population)
    {
        Name = name;
        Location = location;
        Population = population;
    }

    public string Name { get; set; } = null!;
    public string Location { get; set; } = null!;
    public int Population { get; set; }
}
