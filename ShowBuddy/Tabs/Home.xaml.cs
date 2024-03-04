namespace ShowBuddy;

public partial class Home : ContentPage
{
	int count = 0;

	public Home()
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

