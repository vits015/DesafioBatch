using System.Text.Json.Serialization;

namespace DesafioBatch.Models;

public class Club
{
    [JsonPropertyName("club_id")]
    public string? ClubId { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("championship")]
    public string? Championship { get; set; }

    [JsonPropertyName("founding_date")]
    public string? FoundingDate { get; set; }

    [JsonPropertyName("city")]
    public string? City { get; set; }

    [JsonPropertyName("state")]
    public string? State { get; set; }

    [JsonPropertyName("country")]
    public string? Country { get; set; }

    [JsonPropertyName("stadium")]
    public string? Stadium { get; set; }

    [JsonPropertyName("president")]
    public string? President { get; set; }

    [JsonPropertyName("nickname")]
    public string? Nickname { get; set; }

    [JsonPropertyName("colors")]
    public List<string>? Colors { get; set; }

    [JsonPropertyName("players")]
    public List<Player>? Players { get; set; }
}