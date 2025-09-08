namespace C__Players_Guide.Utils;

public static class Read
{
    public static string String(string text)
    {
        string result = "";
        Console.Write(text);
        result = Console.ReadLine()!;
        return result;
    }

    public static float Float(string text)
    {
        float result = 0;
        result = float.Parse(Read.String(text));
        return result;
    }

    public static int Int(string text)
    {
        int result = 0;
        result = int.Parse(Read.String(text));
        return result;
    }
}