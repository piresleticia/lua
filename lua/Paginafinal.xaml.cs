namespace lua;

public partial class PaginafinalPage : ContentPage
{


	public PaginafinalPage()
	{
		InitializeComponent();

    }



private void ParaComeco(object sender, EventArgs args) 
	{
	  Application.Current.MainPage = new MainPage();
	  
	}



}
