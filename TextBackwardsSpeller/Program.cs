using System;

namespace TextBackwardsSpeller;

// ReSharper disable once ClassNeverInstantiated.Global
public class Program
{
    public static void Main(string[] args)
    {
        IReverseText reverseText = new ReverseText();
        foreach (var origin in args)
        {
            Console.Write($"{reverseText.ValueFor(origin)} ");
        }
    }
}