namespace Examples;

using XKCD.Net;
using XKCD.Net.Models;
public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine(new GetXkcdComic().GetComic(0));
    }
}