using System.Text.Json.Serialization;

namespace XKCD.Net.Models;

public class ComicModel
{
    [JsonPropertyName("month")]
    public string Month { get; set; }
    [JsonPropertyName("num")]
    public int Num { get; set; }
    [JsonPropertyName("link")]
    public string Link { get; set; }
    [JsonPropertyName("year")]
    public string Year { get; set; }
    [JsonPropertyName("news")]
    public string News { get; set; }
    [JsonPropertyName("safe_title")]
    public string SafeTitle { get; set; }
    [JsonPropertyName("transcript")]
    public string Transcript { get; set; }
    [JsonPropertyName("alt")]
    public string Alt { get; set; }
    [JsonPropertyName("img")]
    public Uri Img { get; set; }
    [JsonPropertyName("title")]
    public string Title { get; set; }
    [JsonPropertyName("day")]
    public string Day { get; set; }
}