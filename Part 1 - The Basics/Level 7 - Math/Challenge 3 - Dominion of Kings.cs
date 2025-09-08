using C__Players_Guide.Utils;

class Part1Level7Challenge3DominionOfKings : IExercise
{
    private const int PointsPerProvince = 6;
    private const int PointsPerDuchies = 3;
    private const int PointsPerEstate = 1;

    public void Run()
    {
        int provincesAmount = Read.Int("How many provinces do you have: ");
        int duchiesAmount = Read.Int("How many duchies do you have: ");
        int estatesAmount = Read.Int("How many estates do you have: ");

        int score = (provincesAmount * PointsPerProvince) + (duchiesAmount * PointsPerDuchies) +
                    (estatesAmount * PointsPerEstate);

        Console.WriteLine($"Your total score is: {score} points.");
    }
}