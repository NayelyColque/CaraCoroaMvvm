namespace CoinFlipMvvm
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void PlayCoinButton_Clicked(object sender, EventArgs e)
        {
            string? LadoMoeda = CoinSidesPicker.SelectedItem as string;
            int LadoSorteado = new Random().Next(2);

            //Trocar a imagem pelo resultado dado pelo usuario

            if (LadoSorteado == 0)
            {
                CoinResultImage.Source = "cara.jpg";
            }

            else if (LadoSorteado == 1)
            {
                CoinResultImage.Source = "coroa.jpg";
            }

            //Comparar com o que o usuario selecionou 0

            if (LadoSorteado == 0 && LadoMoeda == "Cara")
            {
                Resultlabel.Text = "Parabens, deu cara!";
            }

            else if (LadoSorteado == 0 && LadoMoeda == "Coroa")
            {
                Resultlabel.Text = "Que pena, vc selecionou coroa e deu cara!";
            }

            //Comparar com o que o usuario selecionou 1
            else if (LadoSorteado == 1 && LadoMoeda == "Coroa")
            {
                Resultlabel.Text = "Parabens, deu coroa!";
            }

            else if (LadoSorteado == 1 && LadoMoeda == "Cara")
            {
                Resultlabel.Text = "Que pena, vc selecionou cara e deu coroa!";
            }

        }
    }


}
