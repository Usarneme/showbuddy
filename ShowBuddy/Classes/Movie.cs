using System.Collections.ObjectModel;

namespace ShowBuddy;

public class Movie {
  public string? Title { get; set; }
  public int Year { get; set; }
  public string? Rated { get; set; }
  public int Released { get; set; }
  public string? Runtime { get; set; }
  public string? Genre { get; set; }
  public string? Director { get; set; }
  public string? Writer { get; set; }
  public string[]? Actors { get; set; }
  public string? Plot { get; set; }
  public string? Language { get; set; }
  public string? Country { get; set; }
  public string[]? Awards { get; set; }
  public string? Poster { get; set; }
  public Rating[]? Ratings { get; set; }
  public string? Metascore { get; set; }
  public string? imdbRating { get; set; }
  public string? imdbVotes { get; set; }
  public string? imdbID { get; set; }
  public string? Type { get; set; }
  public string? DVD { get; set; }
  public string? BoxOffice { get; set; }
  public string? Production { get; set; }
  public string? Website { get; set; }
  public string? Response { get; set; }

  public static implicit operator ObservableCollection<object>(Movie? v)
  {
    throw new NotImplementedException();
  }
}

public class Rating {
  private string? Source { get; set; }
  private string? Value { get; set; }
}
