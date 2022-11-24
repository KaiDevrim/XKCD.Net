using XKCD.Net;

namespace Examples;

public class Program
{
    public static void Main(string[] args)
    {
        Comic comic = new(-4554);
        Console.WriteLine(comic.Year);
    }
}