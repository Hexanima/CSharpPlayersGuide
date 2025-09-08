using C__Players_Guide.Utils;

class Part1Level7Challenge1TriangleFarmer : IExercise
{
    public void Run()
    {
        float width = Read.Float("Enter the base of the triangle: ");
        float height = Read.Float("Enter the height of the triangle: ");

        float triangleArea = width * height / 2;

        Console.WriteLine("The triangle's area is " + triangleArea);
    }
}