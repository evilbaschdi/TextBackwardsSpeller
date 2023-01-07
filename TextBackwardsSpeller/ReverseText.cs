namespace TextBackwardsSpeller;

public class ReverseText : IReverseText
{
    public string ValueFor(string input)
    {
        if (input == null)
        {
            throw new ArgumentNullException(nameof(input));
        }

        var charArray = input.ToCharArray();
        Array.Reverse(charArray);

        return new(charArray);
    }
}