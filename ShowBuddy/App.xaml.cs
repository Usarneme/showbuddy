namespace ShowBuddy;

public partial class App : Application
{
  public static UserRepository userRepository { get; set; }
	public App(UserRepository repo)
	{
		InitializeComponent();

		MainPage = new AppShell();

    userRepository = repo;
	}
}
