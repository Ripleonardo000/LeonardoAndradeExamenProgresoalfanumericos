namespace LeonardoAndradeExamenProgresoalfanumericos.Views;

public partial class LAAllnotesPage : ContentPage
{
	public LAAllnotesPage()
	{
		InitializeComponent();
		BindingContext = new Models.LAAllNotes();

	}

	protected override void OnAppearing()
	{
		base.OnAppearing();
	}

	private async void Agregar_Clicked(object sender, EventArgs e)
	{
		await Shell.Current.GoToAsync(nameof(LAAllnotesPage));
	}

	private async void notesCollection_SelectionChanged(object Sender, SelectionChangedEventArgs e)
	{
		if (e.CurrentSelection.Count !=0)
		{
			var note = (Models.LAAllNotes)e.CurrentSelection[0];
			await Shell.Current.GoToAsync($"{nameof(NotePagge)}?{nameof(NotePagge.ItemId)}={note.Filename}

			notesCollection.SelectItem = null;
		}
	}
}