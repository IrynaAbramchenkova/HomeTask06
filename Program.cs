using System;

public class AreYouPlayingBanjo
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Are you playing banjo? (Enter your name): ");
        string name = Console.ReadLine();

        if (name.ToLower().StartsWith("r"))
        {
            Console.WriteLine(name + " plays banjo");
        }
        else
        {
            Console.WriteLine(name + " does not play banjo");
        }

        Console.ReadKey();
    }
}