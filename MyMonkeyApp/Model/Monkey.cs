using System;

namespace MyMonkeyApp.Model;

/// <summary>
/// Represents a monkey species with name, location, and population data.
/// </summary>
public class Monkey
{
    public string Name { get; set; } = string.Empty;
    public string Location { get; set; } = string.Empty;
    public int Population { get; set; }
}