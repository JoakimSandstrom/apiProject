global using RestSharp;
global using System.Text.Json;
global using System.Net;

RestClient pokeClient = new("https://pokeapi.co/api/v2/");
RestRequest request = new("pokemon/eebee");
RestResponse response = pokeClient.GetAsync(request).Result;

if (response.StatusCode == HttpStatusCode.OK)
{
    Starwars p = JsonSerializer.Deserialize<Starwars>(response.Content);
    Console.WriteLine(p.Name);
    Console.WriteLine(p.Weight);
}
else Console.WriteLine("you dum. it wrong.");


//Console.WriteLine(response.Content);

Console.ReadLine();