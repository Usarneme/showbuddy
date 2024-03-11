using System.Text.Json;
using System.Collections.ObjectModel;

namespace ShowBuddy;

public partial class Search : ContentPage
{
  static readonly string key = "apiKey=" + Environment.GetEnvironmentVariable("OMDB_API_KEY");
  static readonly string hardcodedrequest = "&t=rick";
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
    URLLabel.Text = "Fetching via GET: " + url;
    try
    {
      var json = await _httpClient.GetStringAsync(url);
      var moviesList = JsonSerializer.Deserialize<List<Movie>>(json) ?? [];

      foreach (var movie in moviesList)
      {
        Movies.Add(movie);
      }
    }
    catch (Exception e)
    {
      SearchErrorLabel.Text = e.Message;
    }
  }


}
