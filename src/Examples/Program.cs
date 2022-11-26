using XKCD.Net;

namespace Examples;

public class Program
{
    public static void Main(string[] args)
    {
        Comic latest = new(0);
        for (int j = 0; j < latest.Num; j++)
        {
            Comic comic = new Comic(j);
            Console.WriteLine(comic.Link + "\n" + comic.Title);
        }
    }
}