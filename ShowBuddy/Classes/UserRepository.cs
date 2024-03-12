using Newtonsoft.Json;

namespace ShowBuddy;

public class UserRepository
{
  string _dbPath;

  public string StatusMessage { get; set; }

  private void Init()
  {

  }

  public UserRepository(string dbPath)
  {
    if (string.IsNullOrEmpty(dbPath))
    {
      throw new ArgumentNullException("dbPath");
    }

    _dbPath = dbPath;
  }

  public void AddNewUser(string username)
  {
    int result = 0;
    try
    {
      // Init() ?
      if (string.IsNullOrEmpty(username))
      {
        throw new Exception("A username is required. Max length 250 characters please!");
      }

      // use db connection to add a new user, using the c# User class methods + LINQ
      // _dbPath
      result = 1;

      StatusMessage = string.Format("{0} records added (Name: {1})", result, username);
    }
    catch (Exception e)
    {
      StatusMessage = string.Format("Failed to add {0} records. Error: {1}", username, e.Message);
    }
  }

}