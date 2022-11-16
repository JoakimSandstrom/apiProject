using System.Text.Json.Serialization;
public class Starwars
{
    [JsonPropertyName("name")]
    public string Name { get; set; }
    [JsonPropertyName("weight")]
    public int Weight { get; set; }
    [JsonPropertyName("is_defualt")]
    public bool IsDefualt { get; set; }
}
