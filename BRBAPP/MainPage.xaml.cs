namespace BRBapp;

public partial class MainPage : ContentPage
{
	

	public MainPage()
	{
		 InitializeComponent();
		 carouselView.ItemsSource = new List<string>
        {
			
			"Image/img8.png",
            "Images/img7.png",
            "Image/img9.png",
            "Image/img10.png",
            "Image/vipbrbe.jpg"
     
        };
        var myDataList = new List<MyData>
            {
               
                new MyData { ImageSource = "Images/img8.png", ImageText = "Vaga Exlusiva No Aeroporto de Brasília" },
                new MyData { ImageSource = "Images/img7.png", ImageText = "Saboreie os Melhores vinhos com Cartão Adega" },
                new MyData { ImageSource = "Images/img9.png", ImageText = "Eleito Melhor Cartão BRB DUX" },
                new MyData { ImageSource = "Image/img10.png", ImageText = "Seja Premium Entre Uma Viagem e Outra"},
                new MyData { ImageSource = "Image/vipbrbe.jpg", ImageText = "Brb conta com sua Àrea VIP no Aereporto de Brasília"}
            };
        carouselView.ItemsSource = myDataList;
    }
    



			

    public class MyData
    {
        public string ImageSource { get; set; }
        public string ImageText { get; set; }
    }

    

    
}

