using System.Text.Json;

using XKCD.Net.Models;

namespace XKCD.Net.Services;

public class GetComic
{
    public async Task<ComicModel> GetComicObject(int day)
    {
        using HttpClient client = new();

        HttpResponseMessage response = await client.GetAsync(GetUri(day));

        try
        {
            response.EnsureSuccessStatusCode();
        }
        catch
        {
            throw new HttpRequestException();
        }

        var options = new JsonSerializerOptions
        {
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase
        };
        
        Stream stream = await response.Content.ReadAsStreamAsync();
        ComicModel comic = await JsonSerializer.DeserializeAsync<ComicModel>(stream, options);

        return comic;
    }

    private Uri GetUri(int day)
    {
        return day switch
        {
            0 => new Uri("https://xkcd.com/info.0.json"),
            -1 => new Uri($"https://xkcd.com/{GetRandom()}/info.0.json"),
            >= 1 => new Uri($"https://xkcd.com/{day}/info.0.json"),
            < 0 => throw new FileNotFoundException(),
        };
    }

    private int GetRandom()
    {
        int latest = GetComicObject(0).Result.Num;
        Random random = new();
        return random.Next(0, latest);
    }
}