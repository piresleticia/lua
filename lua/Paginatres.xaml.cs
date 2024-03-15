namespace lua;

public partial class PaginatresPage : ContentPage
{


	public PaginatresPage()
	{
		InitializeComponent();
    }

 
private void ParaGameover(object sender, EventArgs args) 
	{
	  Application.Current.MainPage = new GameoverPage();
	  
	}

private void Parafinal(object sender, EventArgs args) 
	{
	  Application.Current.MainPage = new PaginafinalPage();
	  
	}
}
