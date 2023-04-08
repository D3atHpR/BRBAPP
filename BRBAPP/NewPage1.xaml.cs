namespace BRBapp;

public partial class NewPage1 : ContentPage
{
	public NewPage1()
	{
		InitializeComponent();
	}

    private async void Chamada(object sender, EventArgs e)
    {
		await DisplayAlert("Venha conhecer o Open Finance","Migre suas informações e aproveite os benefícios dos cartões do BRB","OK");
    }
}