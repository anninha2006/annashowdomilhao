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
		void OnButtonResposta01Clicked(object sender, EventArgs args)
		{
			gerenciador.VerfiicaCorreto(1);
		}
		void OnButtonResposta02Clicked(object sender, EventArgs args)
		{
			gerenciador.VerfiicaCorreto(2);
		}void OnButtonResposta03Clicked(object sender, EventArgs args)
		{
			gerenciador.VerfiicaCorreto(3);
		}void OnButtonResposta04Clicked(object sender, EventArgs args)
		{
			gerenciador.VerfiicaCorreto(4);
		}void OnButtonResposta05Clicked(object sender, EventArgs args)
		{
			gerenciador.VerfiicaCorreto(5);
		}
	}
