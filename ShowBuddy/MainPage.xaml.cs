namespace ShowBuddy;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{
		count++;

    CounterBtn.Text = $"Clicked {count} time";

		SemanticScreenReader.Announce(CounterBtn.Text);
	}
}

