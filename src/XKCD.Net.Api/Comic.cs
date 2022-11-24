using XKCD.Net.Models;
using XKCD.Net.Services;

namespace XKCD.Net;

public class Comic
{
    private readonly ComicService _comicService = new();
    private readonly int _index;

    public Comic(int index)
    {
        _index = index;
    }

    private ComicModel MyComic => _comicService.GetComic(_index).Result;

    public string Month => MyComic.Month;
    public int Num => MyComic.Num;
    public string Link => MyComic.Link;
    public string Year => MyComic.Year;
    public string News => MyComic.News;
    public string SafeTitle => MyComic.SafeTitle;
    public string Transcript => MyComic.Transcript;
    public string Alt => MyComic.Alt;
    public Uri Img => MyComic.Img;
    public string Title => MyComic.Title;
    public string Day => MyComic.Day;
}