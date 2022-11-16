using System.Text.Json.Serialization;
public class Starwars
{
    [JsonPropertyName("name")]
    public string Name { get; set; }
    [JsonPropertyName("height")]
    public string Height { get; set; }
    [JsonPropertyName("mass")]
    public string Mass { get; set; }
    [JsonPropertyName("gender")]
    public string Gender { get; set; }
}
