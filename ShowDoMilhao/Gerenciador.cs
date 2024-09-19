using Showdomilhao;
using ShowDoMilhao;

namespace ShowDoMilhao
{
    public class Gerenciador
    {
        List<Questao> listaQuestoes = new List<Questao>();
        List<int> listaQuestoesRespondidas = new List<int>();
        Questao questaoCorrente;
        public Gerenciador(Label labelpergunta, Button button1, Button button2, Button button3, Button button4, Button button5)
        {
            CriarQuestoes (labelpergunta, button1, button2, button3, button4, button5);
        }
        void  CriarQuestoes (Label labelpergunta, Button button1, Button button2, Button button3, Button button4, Button button5)
        {
            var Q1 = new Questao();
            Q1.Pergunta= "Quem é o vilão da rapunzel";
            Q1.Resposta1= "Malévola";
            Q1.Resposta2= "Úrsula";
            Q1.Resposta3= "Gothel";
            Q1.Resposta4= "Cruella";
            Q1.Resposta5= "Rainha Má";
            Q1.Respostacorreta= 5;
            Q1.ConfiguraEstruturaDesenho(labelpergunta, button1, button2, button3, button4, button5 );
            listaQuestoes.Add(Q1);

        }
        public void ProximaQuestao()
        {
            var numRandomico = Random.Shared.Next (0,listaQuestoes.Count);
            while (listaQuestoesRespondidas.Contains (numRandomico) )
            numRandomico = Random.Shared.Next (0,listaQuestoes.Count -1);

            listaQuestoesRespondidas.Add (numRandomico);
            questaoCorrente = listaQuestoes[numRandomico];
            questaoCorrente.Desenhar();
        }
        public async void VerfiicaCorreto (int RespostaSelecionada)
        {
            if (questaoCorrente.VerificaResposta(RespostaSelecionada))
            {
                await Task.Delay (1000);
                ProximaQuestao();
            }
        }
    }
}