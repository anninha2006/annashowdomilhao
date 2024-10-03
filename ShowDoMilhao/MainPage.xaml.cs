namespace ShowDoMilhao;
public partial class MainPage : ContentPage
	{
		Gerenciador gerenciador;
		public MainPage()
		{
			InitializeComponent();
			gerenciador = new Gerenciador(labelpergunta, ButtonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
			gerenciador.ProximaQuestao();
		}
		void ButtonResposta1Clicked(object sender, EventArgs args)
		{
			gerenciador.VerfiicaCorreto(1);
		}
		void ButtonResposta2Clicked(object sender, EventArgs args)
		{
			gerenciador.VerfiicaCorreto(2);
		}void ButtonResposta3Clicked(object sender, EventArgs args)
		{
			gerenciador.VerfiicaCorreto(3);
		}void ButtonResposta4Clicked(object sender, EventArgs args)
		{
			gerenciador.VerfiicaCorreto(4);
		}void ButtonResposta5Clicked(object sender, EventArgs args)
		{
			gerenciador.VerfiicaCorreto(5);
		}
		void OnAjudaRetirarClicked(object s, EventArgs e)
		{ 
			var ajuda = new RetiraErradas();
			ajuda.ConfiguraDesenho(ButtonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
			ajuda.RealizarAjuda(gerenciador.GetQuestaoCorrente());
			(s as Button).IsVisible= false;
		}
		void OnAjudaPulaClicked(object s, EventArgs e)
		{
			gerenciador.ProximaQuestao();
			(s as Button).IsVisible= false;
		}
	}
