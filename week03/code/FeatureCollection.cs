  using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text.Json.Serialization.Metadata;

public class FeatureCollection
{
    // TODO Problem 5 - ADD YOUR CODE HERE
    // Create additional classes as necessary
 


    static async Task Main(string[] args)
    {
        string[] summaries = await EarthquakeDailySummary();
        foreach (var summary in summaries)
        {
            Console.WriteLine(summary);
        }
    }

    public static async Task<string[]> EarthquakeDailySummary()
    {
        string url = "https://earthquake.usgs.gov/earthquakes/feed/v1.0/summary/all_day.geojson";
        HttpClient client = new HttpClient();

        // Download JSON data
        var response = await client.GetStringAsync(url);

        // Deserialize JSON to FeatureCollection object
        var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
        FeatureCollection data = JsonSerializer.Deserialize<FeatureCollection>(response, options);

        List<string> result = new List<string>();

        // Extract place and magnitude
        foreach (var feature in data.Features)
        {
            string place = feature.Properties.Place;
            double? magnitude = feature.Properties.Mag;
            result.Add($"{place} - Mag {magnitude}");
        }

        return result.ToArray();
    }

    // Classes to match the JSON structure
    public class FeatureCollection
    {
        [JsonPropertyName("features")]
        public List<Feature> Features { get; set; }
    }

    public class Feature
    {
        [JsonPropertyName("properties")]
        public Properties Properties { get; set; }
    }

    public class Properties
    {
        [JsonPropertyName("mag")]
        public double? Mag { get; set; }

        [JsonPropertyName("place")]
        public string Place { get; set; }
    }





}