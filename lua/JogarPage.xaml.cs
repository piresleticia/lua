namespace lua;

public partial class JogarPage : ContentPage
{


	public JogarPage()
	{
		InitializeComponent();
    }

 private void ParaContinuar(object sender, EventArgs args) 
	{
	  Application.Current.MainPage = new PaginadoisPage();
	  
	}



}
