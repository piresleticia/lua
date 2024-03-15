namespace lua;

public partial class GameoverPage : ContentPage
{


	public GameoverPage()
	{
		InitializeComponent();
    }


private void Voltarinicio (object sender, EventArgs args) 
	{
	  Application.Current.MainPage = new MainPage();
	  
	}









}
