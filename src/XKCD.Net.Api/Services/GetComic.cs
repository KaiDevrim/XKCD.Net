namespace XKCD.Net.Services;

using Models;
using Newtonsoft.Json;

public class GetComic
{
    public ComicModel GetComicObject(int? day)
    {
        using var client = new HttpClient();
        string url = String.Empty;
        if (day == 0)
        {
            url = "https://xkcd.com/info.0.json";
        }
        
        else if (day == -1)
        {
             Random r = new Random();
             int max = JsonConvert.DeserializeObject<ComicModel>(client.GetAsync("https://xkcd.com/info.0.json").Result.Content.ReadAsStringAsync().Result).Num;
             int randomDay = r.Next(0, max);
             url = $"https://xkcd.com/{randomDay}/info.0.json";
        }
        
        else if (day >= 1)
        {
            url = $"https://xkcd.com/{day}/info.0.json";
        }

        else
        {
            throw new FileNotFoundException();
        }

        HttpResponseMessage response = client.GetAsync(url).Result;
        if (response.IsSuccessStatusCode)
        {
            try
            {
                JsonConvert.DeserializeObject<ComicModel>(response.Content.ReadAsStringAsync().Result);
            }
            catch (Exception e)
            {
                throw new JsonSerializationException(e.ToString());
            }
        }
        else
        {
            throw new HttpRequestException();
        }
        return JsonConvert.DeserializeObject<ComicModel>(response.Content.ReadAsStringAsync().Result) ?? new ComicModel();
    }
}