namespace ShowDoMilhao;
public partial class MainPage : ContentPage
{
	Gerenciador gerenciador;
	public MainPage()
	{
		InitializeComponent();
		gerenciador = new Gerenciador(labelpergunta, ButtonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5, labelNivel, labelPontuacao);
		gerenciador.ProximaQuestao();
	}
	void ButtonResposta1Clicked(object sender, EventArgs args)
	{
		gerenciador.VerfiicaCorreto(1);
	}
	void ButtonResposta2Clicked(object sender, EventArgs args)
	{
		gerenciador.VerfiicaCorreto(2);
	}
	void ButtonResposta3Clicked(object sender, EventArgs args)
	{
		gerenciador.VerfiicaCorreto(3);
	}
	void ButtonResposta4Clicked(object sender, EventArgs args)
	{
		gerenciador.VerfiicaCorreto(4);
	}
	void ButtonResposta5Clicked(object sender, EventArgs args)
	{
		gerenciador.VerfiicaCorreto(5);
	}
	void OnAjudaRetirarClicked(object s, EventArgs e)
	{
		var ajuda = new RetiraErradas();
		ajuda.ConfiguraDesenho(ButtonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
		ajuda.RealizarAjuda(gerenciador.GetQuestaoCorrente());
		(s as Button).IsVisible = false;
	}
	int i = 3;
	void OnAjudaPulaClicked(object s, EventArgs e)
	{
		gerenciador.ProximaQuestao();
		i--;
		BotaoPular.Text= "Pular " + i + "x";
		if (i == 0)
		{
			(s as Button).IsVisible = false;
		}
		
	}
	void OnAjudaUniversitariosClicked(object s, EventArgs e)
	{
		var ajuda = new Universitarios();
		ajuda.ConfiguraDesenho(ButtonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
		ajuda.RealizarAjuda(gerenciador.GetQuestaoCorrente());
		(s as Button).IsVisible = false;
	}
}
