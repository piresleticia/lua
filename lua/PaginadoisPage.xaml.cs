namespace lua;

public partial class PaginadoisPage : ContentPage
{


	public PaginadoisPage()
	{
		InitializeComponent();
    }

  private void ParaproximaFase(object sender, EventArgs args) 
	{
	  Application.Current.MainPage = new PaginatresPage();
	  
	}
private void ParaGameover(object sender, EventArgs args) 
	{
	  Application.Current.MainPage = new GameoverPage();
	  
	}



}
