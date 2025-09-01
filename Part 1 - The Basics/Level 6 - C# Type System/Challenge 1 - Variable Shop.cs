using C__Players_Guide.Utils;

class Part1Level6Challenge1VariableShop : IExercise
{
    public void Run()
    {
        // Integers
        int aNumber = -32;
        short aShortNumber = -32767;
        long averageDebts = -1_234_567;
        byte aByte = 255;
        sbyte negativeByte = -4;
        uint theMoneyIWant = 4_200_120_120;
        ushort notSoNegativeShort = 65535;
        ulong amountOfPeopleInTheWorld = 8_202_862_251;

        // Texts
        char aSingleLetter = '/';
        string anUrl = "https://youtu.be/dQw4w9WgXcQ";

        // Floating Point
        float todaysWeather = 63.6F;
        double orNothing = 3.1415;
        decimal anAccountantsBestVariable = 121.122541211212M;

        // Booleans
        bool isIt = true;
        bool itIsnt = false;

        Console.WriteLine("\nIntegers:");
        Console.WriteLine(aNumber);
        Console.WriteLine(aShortNumber);
        Console.WriteLine(averageDebts);
        Console.WriteLine(aByte);
        Console.WriteLine(negativeByte);
        Console.WriteLine(theMoneyIWant);
        Console.WriteLine(notSoNegativeShort);
        Console.WriteLine(amountOfPeopleInTheWorld);

        Console.WriteLine("\nTexts");
        Console.WriteLine(aSingleLetter);
        Console.WriteLine(anUrl);

        Console.WriteLine("\nFloating Point");
        Console.WriteLine(todaysWeather);
        Console.WriteLine(orNothing);
        Console.WriteLine(anAccountantsBestVariable);

        Console.WriteLine("\nBooleans");
        Console.WriteLine(isIt);
        Console.WriteLine(itIsnt);
    }
}