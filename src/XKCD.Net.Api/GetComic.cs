namespace XKCD.Net;

using Models;
using Newtonsoft.Json;

public class GetXkcdComic
{
    public Comic GetComic(int? day)
    {
        using var client = new HttpClient();
        string url = String.Empty;
        if (day == 0)
        {
            url = "https://xkcd.com/info.0.json";
        }
        
        else if (day >= 1)
        {
            url = $"https://xkcd.com/{day}/info.0.json";
        }

        HttpResponseMessage response = client.GetAsync(url).Result;
        if (response.IsSuccessStatusCode)
        {
            try
            {
                JsonConvert.DeserializeObject<Comic>(response.Content.ReadAsStringAsync().Result);
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

        return JsonConvert.DeserializeObject<Comic>(response.Content.ReadAsStringAsync().Result) ?? new Comic();
    }
}