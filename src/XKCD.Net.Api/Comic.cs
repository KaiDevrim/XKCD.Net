using XKCD.Net.Models;
using XKCD.Net.Services;

namespace XKCD.Net;

/// <summary>

/// Use this to create a comic object to get comics from.
/// 
/// Use Comic(-1) for random
/// 
/// Use Comic(0) for the latest comic
/// 
/// Use Comic(int x) for a specific comic

/// </summary>
public class Comic
{
    private readonly ComicService _comicService = new();
    private readonly int _index;

    public Comic(int index)
    {
        _index = index;
    }

    private ComicModel MyComic => _comicService.GetComic(_index).Result;

    /// <summary>
    /// Get the Month that the Comic was published
    /// </summary>
    public string Month => MyComic.Month;
    /// <summary>
    /// Get the specific number of the Comic
    /// </summary>
    public int Num => MyComic.Num;
    /// <summary>
    /// Get any related links containing more information about the Comic
    /// </summary>
    public string Link => MyComic.Link;
    /// <summary>
    /// Get the Year that the Comic was published
    /// </summary>
    public string Year => MyComic.Year;
    /// <summary>
    /// Get announcements about XKCD or the Comic itself
    /// </summary>
    public string News => MyComic.News;
    /// <summary>
    /// Get a title that is safe to use if the actual title has some code or errors in it
    /// </summary>
    public string SafeTitle => MyComic.SafeTitle;
    /// <summary>
    /// A written summary of what the Comic is about
    /// </summary>
    public string Transcript => MyComic.Transcript;
    /// <summary>
    /// Get the alt text for the image in the Comic, useful for screen readers
    /// </summary>
    public string Alt => MyComic.Alt;
    /// <summary>
    /// Get a URI containing a direct link to the image of the Comic
    /// </summary>
    public Uri Img => MyComic.Img;
    /// <summary>
    /// Get the Comic's title
    /// </summary>
    public string Title => MyComic.Title;
    /// <summary>
    /// Get the day the Comic was published on
    /// </summary>
    public string Day => MyComic.Day;
}