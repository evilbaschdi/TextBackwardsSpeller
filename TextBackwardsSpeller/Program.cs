namespace TextBackwardsSpeller;

// ReSharper disable once ClassNeverInstantiated.Global
public class Program
{
    public static void Main(string[] args)
    {
        var input = Console.ReadLine();
        IReverseText reverseText = new ReverseText();

        Console.Write($"{reverseText.ValueFor(input)} ");
    }
}