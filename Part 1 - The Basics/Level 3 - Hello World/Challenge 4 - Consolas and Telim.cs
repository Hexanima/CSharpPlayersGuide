using C__Players_Guide.Utils;

namespace C__Players_Guide.Part_1___The_Basics.Level_3___Hello_World;

class Part1Level3Challenge4ConsolasAndTelim : IExercise
{
    public void Run()
    {
        Console.WriteLine("The bread is ready!");
        Console.WriteLine("For whom is it for?");
        string name = Console.ReadLine()!;
        Console.WriteLine($"{name} now has bread fresh out of the oven. Tasty!");
    }
}