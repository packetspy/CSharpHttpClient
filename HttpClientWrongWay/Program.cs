// See https://aka.ms/new-console-template for more information

var url = "https://www.google.com";
int nloop = 10;

Console.WriteLine($"Starting connections with {url}");

for (int i = 0; i<nloop; i++)
{
	using (var client = new HttpClient())
	{
		var result = await client.GetAsync(url);
		Console.WriteLine($"{url} -> {result.StatusCode}");
	}
}

Console.WriteLine("End connections");
