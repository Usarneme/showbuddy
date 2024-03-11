namespace ShowBuddy;

public partial class Home : ContentPage
{
	public Home()
	{
		InitializeComponent();
	}

  private void OnTapped(object sender, EventArgs e)
  {
    DisplayAlert("Tapped", "Button was tapped", "Okely Dokely");
  }

}
