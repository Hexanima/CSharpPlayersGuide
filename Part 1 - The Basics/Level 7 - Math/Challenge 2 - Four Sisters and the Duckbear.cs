using C__Players_Guide.Utils;

class Part1Level7Challenge2FourSistersAndDuckbear : IExercise
{
    public void Run()
    {
        int gatheredEggs = ReadInt("Amount of eggs gathered today: ");

        int eggForEachSister = gatheredEggs / 4;
        int remainderForDuckbear = gatheredEggs % 4;
        
        Console.WriteLine("Each Sister gets " + eggForEachSister + " eggs.");
        Console.WriteLine("Duckbear gets " + remainderForDuckbear + " eggs.");
    }

    private string ReadString(string text)
    {
        string result = "";
        Console.Write(text);
        result = Console.ReadLine()!;
        return result;
    }

    private float ReadFloat(string text)
    {
        float result = 0;
        result = float.Parse(ReadString(text));
        return result;
    }
    
    private int ReadInt(string text)
    {
        int result = 0;
        result = int.Parse(ReadString(text));
        return result;
    }
}