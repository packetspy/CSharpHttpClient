// See https://aka.ms/new-console-template for more information

using System;

public class Program
{
    private static HttpClient client = new HttpClient();
    public static async Task Main(string[] args)
    {
        var url = "https://www.google.com";
        int nloop = 10;

        Console.WriteLine($"Starting connections with {url}");

        for (int i = 0; i < nloop; i++)
        {
            var result = await client.GetAsync(url);
            Console.WriteLine($"{url} -> {result.StatusCode}");
        }

        Console.WriteLine("End connections");
    }
}