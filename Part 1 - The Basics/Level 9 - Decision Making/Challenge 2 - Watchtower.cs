using C__Players_Guide.Utils;

class Part1Level9Challenge2Watchtower : IExercise
{
    public void Run()
    {
        int x = Read.Int("Enter X: ");
        int y = Read.Int("Enter Y: ");

        if (x > 0)
        {
            if (y > 0) Console.WriteLine("The enemy is to the northeast!");
            else if (y < 0) Console.WriteLine("The enemy is to the southeast!");
            else Console.WriteLine("The enemy is to the east!");
        }
        else if (x < 0)
        {
            if (y > 0) Console.WriteLine("The enemy is to the northwest!");
            else if (y < 0) Console.WriteLine("The enemy is to the southwest!");
            else Console.WriteLine("The enemy is to the west!");
        }
        else
        {
            if (y > 0) Console.WriteLine("The enemy is to the north!");
            else if (y < 0) Console.WriteLine("The enemy is to the south!");
            else Console.WriteLine("The enemy is here!");
        }
    }
}