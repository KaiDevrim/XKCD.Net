namespace XKCD.Net;

using Services;

public class Comic
{
    private readonly int _index;
    private readonly GetComic _comicService = new();
    public Comic(int index)
    {
        _index = index;
    }

    public string Month()
    {
        return _comicService.GetComicObject(_index).Month;
    }
    
    public int Num()
    {
        return _comicService.GetComicObject(_index).Num;
    }
    
    public string Link()
    {
        return _comicService.GetComicObject(_index).Link;
    }
    
    public string Year()
    {
        return _comicService.GetComicObject(_index).Year;
    }
    
    public string News()
    {
        return _comicService.GetComicObject(_index).News;
    }
    
    public string Safe_Title()
    {
        return _comicService.GetComicObject(_index).SafeTitle;
    }
    
    public string Transcript()
    {
        return _comicService.GetComicObject(_index).Transcript;
    }
    
    public string Alt()
    {
        return _comicService.GetComicObject(_index).Alt;
    }
    
    public string Img()
    {
        return _comicService.GetComicObject(_index).Img;
    }
    
    public string Title()
    {
        return _comicService.GetComicObject(_index).Title;
    }
    
    public string Day()
    {
        return _comicService.GetComicObject(_index).Day;
    }
}