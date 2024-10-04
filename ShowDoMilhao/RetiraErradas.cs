using Showdomilhao;

namespace ShowDoMilhao;

public partial class RetiraErradas : IAjuda
{
    public override void RealizarAjuda(Questao questao)
    {
        switch (questao.Respostacorreta)
        {
            case 1:
                ButtonResposta2.IsVisible = false;
                ButtonResposta3.IsVisible = false;
                ButtonResposta5.IsVisible = false;
                break;

            case 2:
                ButtonResposta1.IsVisible = false;
                ButtonResposta4.IsVisible = false;
                ButtonResposta5.IsVisible = false;
                break;

            case 3:
                ButtonResposta1.IsVisible = false;
                ButtonResposta4.IsVisible = false;
                ButtonResposta5.IsVisible = false;
                break;

            case 4:
                ButtonResposta2.IsVisible = false;
                ButtonResposta3.IsVisible = false;
                ButtonResposta5.IsVisible = false;
                break;

            case 5:
                ButtonResposta1.IsVisible = false;
                ButtonResposta2.IsVisible = false;
                ButtonResposta4.IsVisible = false;
                break;
        }
    }
}