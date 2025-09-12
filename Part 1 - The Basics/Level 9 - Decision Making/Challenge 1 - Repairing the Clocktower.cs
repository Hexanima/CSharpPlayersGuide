using C__Players_Guide.Utils;

class Part1Level9Challenge1RepairingTheClocktower : IExercise
{
    public void Run()
    {
        int tickTock = Read.Int("Enter a number: ");

        Console.WriteLine(tickTock % 2 == 0 ? "Tick" : "Tock");
    }
}