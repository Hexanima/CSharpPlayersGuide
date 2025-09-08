using C__Players_Guide.Utils;

class Part1Level7Challenge2FourSistersAndDuckbear : IExercise
{
    public void Run()
    {
        int gatheredEggs = Read.Int("Amount of eggs gathered today: ");

        int eggForEachSister = gatheredEggs / 4;
        int remainderForDuckbear = gatheredEggs % 4;
        
        Console.WriteLine("Each Sister gets " + eggForEachSister + " eggs.");
        Console.WriteLine("Duckbear gets " + remainderForDuckbear + " eggs.");
    }
}