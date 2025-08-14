namespace TextBackwardsSpeller;

public class ReverseText : IReverseText
{
    public string ValueFor(string input)
    {
        ArgumentNullException.ThrowIfNull(input);

        var charArray = input.ToCharArray();
        Array.Reverse(charArray);

        return new(charArray);
    }
}