using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Net.Http.Json;

namespace ShowBuddy;

public partial class Home : ContentPage
{
	public Home()
	{
		InitializeComponent();
	}

  static readonly string key = Environment.GetEnvironmentVariable("OMDB_API_KEY") ?? "";
  static readonly string hardcodedrequest = "&t=rick";
  static readonly string url = $"http://www.omdbapi.com/?" + key + hardcodedrequest;


  async private void OnTapped(object sender, EventArgs e)
  {
    await GetMovies();
  }

  async public HttpResponseMessage GetMovies()
  {

    HttpClient client = new HttpClient();
    string result = await client.GetStringAsync(url);
    return JsonSerializer.Deserialize<List<Movie>>(result);
    // HttpRequestMessage message = new HttpRequestMessage(HttpMethod.Get, url);
    // message.Content = JsonContent.Create<IEnumerable>(part);
    // HttpResponseMessage response = await client.SendAsync(message);

    // return response;
  }
}
