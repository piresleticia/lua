namespace lua;

public partial class MainPage : ContentPage
{


	public MainPage()
	{
		InitializeComponent();		
	}

	void Parajogar(object sender, EventArgs args) 
	{
	  Application.Current.MainPage = new JogarPage();
	  
	}

	void Parasobre(object sender, EventArgs args) 
	{
		
	}
}

