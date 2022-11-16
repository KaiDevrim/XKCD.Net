namespace Examples;

using XKCD.Net;
public class Program
{
    public static void Main(string[] args)
    {
        Comic comic = new Comic(-1);
        Console.WriteLine(comic.Num());
    }
}