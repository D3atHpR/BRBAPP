namespace BRBapp;

public partial class NewPage1 : ContentPage
{
	public NewPage1()
	{
		InitializeComponent();
	}

    private async void Chamada(object sender, EventArgs e)
    {
		await DisplayAlert("Venha conhecer o Open Finance","Migre suas informa��es e aproveite os benef�cios dos cart�es do BRB","OK");
    }
}