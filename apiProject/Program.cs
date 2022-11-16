global using RestSharp;
global using System.Text.Json;
global using System.Net;

RestClient starClient = new("https://swapi.py4e.com/api/");
RestRequest request = new("people/1/");
RestResponse response = starClient.GetAsync(request).Result;

if (response.StatusCode == HttpStatusCode.OK)
{
    Starwars s = JsonSerializer.Deserialize<Starwars>(response.Content);
    Console.WriteLine(s.Name);
    Console.WriteLine(s.Height);
    Console.WriteLine(s.Mass);
    Console.WriteLine(s.Gender);
}
else Console.WriteLine("you dum. it wrong.");


//Console.WriteLine(response.Content);

Console.ReadLine();