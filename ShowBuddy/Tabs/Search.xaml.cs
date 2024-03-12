using System.Collections.ObjectModel;
using System.Text.Json;

namespace ShowBuddy;

public partial class Search : ContentPage
{
  static readonly string key = "apiKey=" + Environment.GetEnvironmentVariable("OMDB_API_KEY");
  static readonly string hardcodedrequest = "&s=rick";
  static readonly string url = "https://www.omdbapi.com/?" + key + hardcodedrequest;
  private readonly HttpClient _httpClient = new HttpClient();

  private ObservableCollection<Movie> movies = new ObservableCollection<Movie>();

	public Search()
	{
		InitializeComponent();
    LoadMovies();
	}

  private ObservableCollection<Movie> Movies
  {
    get { return movies; }
    set { movies = value; }
  }

  private async void LoadMovies()
  {
    // KeyValuePair<string, string[]> jsonShape = new KeyValuePair<string, string[]>("Search", []);

    URLLabel.Text = "Fetching via GET: " + url;
    try
    {
      // var raw = JsonConvert.DeserializeObject<jsonShape>(json);
      // const List<Movie> moviesList = raw.Search;
      // JsonSerializer.Deserialize<List<Movie>>(json) ?? [];
      // const string[] moviesList = raw.Search;

      var response = await _httpClient.GetStringAsync(url);
      var json = JsonDocument.Parse(response);
      var root = json.RootElement;
      foreach (var property in root.EnumerateObject())
      {
        Console.WriteLine($"{property.Name}: {property.Value}");
      }
      var searchArray = root.GetProperty("Search").EnumerateArray();
      string totalResponse = root.GetProperty("totalResults").GetString();
      List<Movie> moviesList = [];

      foreach (var movieElement in searchArray)
      {
        Movie m = new Movie
        {
          imdbID = movieElement.GetProperty("imdbID").GetString(),
          Poster = movieElement.GetProperty("Poster").GetString(),
          Title = movieElement.GetProperty("Title").GetString(),
          Type = movieElement.GetProperty("Type").GetString(),
          Year = movieElement.GetProperty("Year").GetString()
        };

        moviesList.Add(m);
      }

      Console.WriteLine("Successfully got movies: ");
            foreach (Movie m in moviesList)
      {
        Console.WriteLine($"{m.Title} {m.Year}");
      }

    }
    catch (Exception e)
    {
      SearchErrorLabel.Text = e.Message;
    }
  }


}
