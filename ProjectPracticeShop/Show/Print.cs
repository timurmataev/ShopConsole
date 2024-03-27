namespace ProjectPracticeShop.Show;

public class Print
{
    public static void ColorRed(string message)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(message);
        Console.ResetColor();
    }
}
