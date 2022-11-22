namespace XKCD.Net.Test;

using Models;
using Newtonsoft.Json;

[TestFixture]
public class XkcdGetLatestComicTest
{
    
    private Comic _comic = new Comic(0);
    private readonly HttpClient _client = new HttpClient();
    private readonly string _url = "https://xkcd.com/info.0.json";
    [SetUp]
    public void SetUp()
    {
        _comic = new Comic(0);
    }

    private ComicModel GetResponse()
    {
        ComicModel? result = new ComicModel();
        HttpResponseMessage response = _client.GetAsync(_url).Result;
        if (response.IsSuccessStatusCode)
        {
            result = JsonConvert.DeserializeObject<ComicModel>(response.Content.ReadAsStringAsync().Result);
        }

        if (result is null)
        {
            return new ComicModel();
        }
        return result;
    }

    [Test]
    public void XKCD_GetLatest_ReturnMonth()
    {
        Assert.That(GetResponse().Month, Is.EqualTo(_comic.Month()));
    }
    
    [Test]
    public void XKCD_GetLatest_ReturnNum()
    {
        Assert.That(GetResponse().Num, Is.EqualTo(_comic.Num()));
    }
}