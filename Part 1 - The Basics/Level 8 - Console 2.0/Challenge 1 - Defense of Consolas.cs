using C__Players_Guide.Utils;

class Part1Level8Challenge1DefenseOfConsolas : IExercise
{
    public void Run()
    {
        Console.Title = "Defense of Consolas";
        int targetRow = Read.Int("Target Row: ");
        int targetColumn = Read.Int("Target Column: ");

        Console.WriteLine("Deploy to:");
        Console.WriteLine($"({targetRow}, {targetColumn - 1})");
        Console.WriteLine($"({targetRow - 1}, {targetColumn})");
        Console.WriteLine($"({targetRow}, {targetColumn + 1})");
        Console.WriteLine($"({targetRow + 1}, {targetColumn})");
        Console.Beep();
    }
}