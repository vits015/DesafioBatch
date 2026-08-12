using System.Text.Json.Serialization;

namespace DesafioBatch.Models;

public class Player
{
    [JsonPropertyName("player_id")]
    public string? PlayerId { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("age")]
    public int? Age { get; set; }

    [JsonPropertyName("goals")]
    public int? Goals { get; set; }

    [JsonPropertyName("debut_date")]
    public string? DebutDate { get; set; }

    [JsonPropertyName("position")]
    public string? Position { get; set; }

    [JsonPropertyName("shirt_number")]
    public int? ShirtNumber { get; set; }
}