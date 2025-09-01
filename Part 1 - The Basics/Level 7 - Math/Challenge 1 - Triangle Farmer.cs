using C__Players_Guide.Utils;

class Part1Level7Challenge1TriangleFarmer : IExercise
{
    public void Run()
    {
        float width = ReadFloat("Enter the base of the triangle: ");
        float height = ReadFloat("Enter the height of the triangle: ");

        float triangleArea = width * height / 2;
        
        Console.WriteLine("The triangle's area is " + triangleArea);
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
}