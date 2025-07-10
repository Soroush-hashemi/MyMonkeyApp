using MyMonkeyApp.Data;
using MyMonkeyApp.Model;

Console.WriteLine("🐵 Monkey Explorer 🐒");
Console.WriteLine("===================");

while (true)
{
    Console.WriteLine("\n1. List all monkeys");
    Console.WriteLine("2. Search monkey by name");
    Console.WriteLine("3. Get random monkey");
    Console.WriteLine("4. Exit");
    
    var choice = Console.ReadLine();
    
    switch (choice)
    {
        case "1":
            ListAllMonkeys();
            break;
        case "2":
            SearchMonkey();
            break;
        case "3":
            ShowRandomMonkey();
            break;
        case "4":
            return;
        default:
            Console.WriteLine("Invalid choice!");
            break;
    }
}

void ListAllMonkeys()
{
    var monkeys = MonkeyHelper.GetMonkeys();
    foreach (var monkey in monkeys)
    {
        Console.WriteLine($"\n{monkey.Name}");
        Console.WriteLine(MonkeyHelper.GetMonkeyAscii(monkey.Name));
    }
}

void SearchMonkey()
{
    Console.Write("Enter monkey name: ");
    var name = Console.ReadLine();
    var monkey = MonkeyHelper.GetMonkeyByName(name);
    
    if (monkey is null)
    {
        Console.WriteLine("Monkey not found!");
        return;
    }
    
    Console.WriteLine($"\n{monkey.Name} - {monkey.Location}");
    Console.WriteLine(MonkeyHelper.GetMonkeyAscii(monkey.Name));
}

void ShowRandomMonkey()
{
    var monkey = MonkeyHelper.GetRandomMonkey();
    Console.WriteLine($"\nRandom Monkey: {monkey.Name}");
    Console.WriteLine(MonkeyHelper.GetMonkeyAscii(monkey.Name));
}