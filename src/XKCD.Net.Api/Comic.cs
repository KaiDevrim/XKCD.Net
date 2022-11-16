namespace XKCD.Net;

using Models;
using Newtonsoft.Json;
using Services;

public class Comic
{
    private int _index;
    private GetComic comicService = new GetComic();
    public Comic(int Index)
    {
        _index = Index;
    }

    public string Month()
    {
        return comicService.GetComicObject(_index).Month;
    }
    
    public int Num()
    {
        return comicService.GetComicObject(_index).Num;
    }
    
    public string Link()
    {
        return comicService.GetComicObject(_index).Link;
    }
    
    public string Year()
    {
        return comicService.GetComicObject(_index).Year;
    }
    
    public string News()
    {
        return comicService.GetComicObject(_index).News;
    }
    
    public string Safe_Title()
    {
        return comicService.GetComicObject(_index).SafeTitle;
    }
    
    public string Transcript()
    {
        return comicService.GetComicObject(_index).Transcript;
    }
    
    public string Alt()
    {
        return comicService.GetComicObject(_index).Alt;
    }
    
    public string Img()
    {
        return comicService.GetComicObject(_index).Img;
    }
    
    public string Title()
    {
        return comicService.GetComicObject(_index).Title;
    }
    
    public string Day()
    {
        return comicService.GetComicObject(_index).Day;
    }
}