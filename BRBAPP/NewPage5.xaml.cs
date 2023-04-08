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

        double gastos = 2000.00; // Valor dos gastos
        double disponivel = 5000.00; // Valor disponível
        double maximo = gastos + disponivel; // Valor máximo do slider

        double novoValor = e.NewValue; // Novo valor do slider
        double valorFatura = maximo * novoValor / 7000.00; // Valor da fatura proporcional ao slider

        LabelValor.Text = $"R${valorFatura:F2}"; // Atualiza o texto do LabelValor com o valor da fatura

    }

    private void SliderValue(object sender, ValueChangedEventArgs e)
    {
        double gastos = 2000.00; // Valor dos gastos
        double disponivel = 8000.00; // Valor disponível
        double maximo = gastos + disponivel; // Valor máximo do slider

        double novoValor = e.NewValue; // Novo valor do slider
        double valorFatura = maximo * novoValor / 7000.00; // Valor da fatura proporcional ao slider

        LabelValorA.Text = $"R${valorFatura:F2}"; // Atualiza o texto do LabelValor com o valor da fatura


    }



}