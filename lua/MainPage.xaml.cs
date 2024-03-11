namespace lua;

public partial class MainPage : ContentPage
{


	public MainPage()
	{
		InitializeComponent();		
	}
 
  private void Parajogar(object sender, EventArgs args) 
	{
	  Application.Current.MainPage = new JogarPage();
	  
	}

	 private void Parasobre(object sender, EventArgs args) 
	{
		frameSobre.IsVisible = true;
	}

	 private void Voltarsobre(object sender, EventArgs args) 
	{
		frameSobre.IsVisible = false;
	}
}

