using System.Globalization;

namespace BRBapp;

public partial class NewPage5 : ContentPage
{
	public NewPage5()
	{
		InitializeComponent();
	}

    private void SliderValueChanged(object sender, ValueChangedEventArgs e)
    {
        
        double value = e.NewValue;
        string formattedValue = string.Format("R$ {0:N2}", value);
        LabelValor.Text = formattedValue;

    }

    private void SliderValue(object sender, ValueChangedEventArgs e)
    {

        double value = e.NewValue;
        string formattedValue = string.Format("R$ {0:N2}", value);
        LabelValorA.Text = formattedValue;
    }


    
}