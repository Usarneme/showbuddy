namespace ShowBuddy;

public class EnvironmentalVariable
{
  public EnvironmentalVariable()
  {
  }

  public async static void ReadEnvFile()
  {
    using var stream = await FileSystem.OpenAppPackageFileAsync(".env");
		using var reader = new StreamReader(stream);

    string line;
    while ((line = reader.ReadLine()) != null)
    {
      LoadEnvironmentVariables(line);
    }
  }

  public static void LoadEnvironmentVariables(string line)
  {
    var parts = line.Split('=');
    if (parts.Length == 2)
    {
      var key = parts[0].Trim();
      var value = parts[1].Trim();
      Environment.SetEnvironmentVariable(key, value);
    }
  }
}
