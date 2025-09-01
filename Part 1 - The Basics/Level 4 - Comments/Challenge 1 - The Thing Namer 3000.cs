using C__Players_Guide.Utils;

class Part1Level4Challenge1TheThingNamer : IExercise
{
    public void Run()
    {
        Console.WriteLine("What kind of thing are we talking about?");
        string describedItem = Console.ReadLine(); // Thing that's talked about
        Console.WriteLine("How would you describe it? Big? Azure? Tattered?");
        string adjective = Console.ReadLine(); // Adjective
        const string ofDoom = "Doom"; // Of DOOM
        const string itemVersion = "3000"; // 3k
        Console.WriteLine("The " + adjective + " " + describedItem + " of " + ofDoom + " " + itemVersion + "!");
    }
}