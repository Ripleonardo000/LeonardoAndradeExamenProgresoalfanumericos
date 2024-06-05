namespace LeonardoAndradeExamenProgresoalfanumericos.Views;

public partial class AboutPagge : ContentPage
{
	public AboutPagge()
	{
		InitializeComponent();
	}

	private async void Leer_Clicked(object sender, EventArgs e)
	{
		if(BindingContext is Models.LAAbout about)
		{
			await Launcher .Default.OpenAsync(about.MoreInfoUrl);
		}
	}
}