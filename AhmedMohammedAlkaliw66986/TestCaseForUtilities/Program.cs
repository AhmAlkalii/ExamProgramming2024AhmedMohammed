using Utilities;

class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine($"{StringUtilities.LongWordsCount("Marcin Jageila")}");
        Console.WriteLine($"{StringUtilities.LongWordsCount("The lord of the rings")}");

        Console.WriteLine();

        Console.WriteLine($"{StringUtilities.ToSpinalCase("Marcin Jagiela")}");
        Console.WriteLine($"{StringUtilities.ToSpinalCase("the LorD OF thE Rings")}");

        Console.WriteLine();

        Console.WriteLine($"{StringUtilities.ToPascalCase("Marcin Jagiela")}");
        Console.WriteLine($"{StringUtilities.ToPascalCase("the LorD OF thE Rings")}");
    }
}