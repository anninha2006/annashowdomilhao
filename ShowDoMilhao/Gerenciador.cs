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
       
        var Q2 = new Questao();
Q2.Pergunta = "Qual o planeta mais próximo do sol?";
Q2.Resposta1 = "Terra";
Q2.Resposta2 = "Marte";
Q2.Resposta3 = "Mercúrio";
Q2.Resposta4 = "Vênus";
Q2.Resposta5 = "Júpiter";
Q2.Respostacorreta = 3;
Q2.ConfiguraEstruturaDesenho(labelpergunta, button1, button2, button3, button4, button5);
listaQuestoes.Add(Q2);

var Q3 = new Questao();
Q3.Pergunta = "Qual é a capital da França?";
Q3.Resposta1 = "Londres";
Q3.Resposta2 = "Berlim";
Q3.Resposta3 = "Paris";
Q3.Resposta4 = "Madri";
Q3.Resposta5 = "Roma";
Q3.Respostacorreta = 3;
Q3.ConfiguraEstruturaDesenho(labelpergunta, button1, button2, button3, button4, button5);
listaQuestoes.Add(Q3);

var Q4 = new Questao();
Q4.Pergunta = "Qual é o maior animal terrestre?";
Q4.Resposta1 = "Elefante";
Q4.Resposta2 = "Girafa";
Q4.Resposta3 = "Rinoceronte";
Q4.Resposta4 = "Urso";
Q4.Resposta5 = "Baleia";
Q4.Respostacorreta = 1;
Q4.ConfiguraEstruturaDesenho(labelpergunta, button1, button2, button3, button4, button5);
listaQuestoes.Add(Q4);

var Q5 = new Questao();
Q5.Pergunta = "Quem pintou a Mona Lisa?";
Q5.Resposta1 = "Van Gogh";
Q5.Resposta2 = "Picasso";
Q5.Resposta3 = "Da Vinci";
Q5.Resposta4 = "Michelangelo";
Q5.Resposta5 = "Rembrandt";
Q5.Respostacorreta = 3;
Q5.ConfiguraEstruturaDesenho(labelpergunta, button1, button2, button3, button4, button5);
listaQuestoes.Add(Q5);

var Q6 = new Questao();
Q6.Pergunta = "Qual é o maior oceano do mundo?";
Q6.Resposta1 = "Atlântico";
Q6.Resposta2 = "Índico";
Q6.Resposta3 = "Pacífico";
Q6.Resposta4 = "Ártico";
Q6.Resposta5 = "Antártico";
Q6.Respostacorreta = 3;
Q6.ConfiguraEstruturaDesenho(labelpergunta, button1, button2, button3, button4, button5);
listaQuestoes.Add(Q6);

var Q7 = new Questao();
Q7.Pergunta = "Quem escreveu 'Dom Casmurro'?";
Q7.Resposta1 = "Machado de Assis";
Q7.Resposta2 = "Joaquim Manuel de Macedo";
Q7.Resposta3 = "José de Alencar";
Q7.Resposta4 = "Clarice Lispector";
Q7.Resposta5 = "Graciliano Ramos";
Q7.Respostacorreta = 1;
Q7.ConfiguraEstruturaDesenho(labelpergunta, button1, button2, button3, button4, button5);
listaQuestoes.Add(Q7);

var Q8 = new Questao();
Q8.Pergunta = "Qual o símbolo químico do ouro?";
Q8.Resposta1 = "Au";
Q8.Resposta2 = "Ag";
Q8.Resposta3 = "Pb";
Q8.Resposta4 = "Fe";
Q8.Resposta5 = "Hg";
Q8.Respostacorreta = 1;
Q8.ConfiguraEstruturaDesenho(labelpergunta, button1, button2, button3, button4, button5);
listaQuestoes.Add(Q8);

var Q9 = new Questao();
Q9.Pergunta = "Qual é a fórmula da água?";
Q9.Resposta1 = "CO2";
Q9.Resposta2 = "H2O";
Q9.Resposta3 = "O2";
Q9.Resposta4 = "H2O2";
Q9.Resposta5 = "NH3";
Q9.Respostacorreta = 2;
Q9.ConfiguraEstruturaDesenho(labelpergunta, button1, button2, button3, button4, button5);
listaQuestoes.Add(Q9);

var Q10 = new Questao();
Q10.Pergunta = "Qual é a moeda do Japão?";
Q10.Resposta1 = "Yuan";
Q10.Resposta2 = "Won";
Q10.Resposta3 = "Yen";
Q10.Resposta4 = "Dólar";
Q10.Resposta5 = "Euro";
Q10.Respostacorreta = 3;
Q10.ConfiguraEstruturaDesenho(labelpergunta, button1, button2, button3, button4, button5);
listaQuestoes.Add(Q10);

var Q11 = new Questao();
Q11.Pergunta = "Qual é o continente mais populoso?";
Q11.Resposta1 = "África";
Q11.Resposta2 = "América";
Q11.Resposta3 = "Ásia";
Q11.Resposta4 = "Europa";
Q11.Resposta5 = "Oceania";
Q11.Respostacorreta = 3;
Q11.ConfiguraEstruturaDesenho(labelpergunta, button1, button2, button3, button4, button5);
listaQuestoes.Add(Q11);

var Q12 = new Questao();
Q12.Pergunta = "Quem é o autor de 'O Pequeno Príncipe'?";
Q12.Resposta1 = "Antoine de Saint-Exupéry";
Q12.Resposta2 = "Jules Verne";
Q12.Resposta3 = "Victor Hugo";
Q12.Resposta4 = "Albert Camus";
Q12.Resposta5 = "Flaubert";
Q12.Respostacorreta = 1;
Q12.ConfiguraEstruturaDesenho(labelpergunta, button1, button2, button3, button4, button5);
listaQuestoes.Add(Q12);

var Q13 = new Questao();
Q13.Pergunta = "Qual é a capital da Austrália?";
Q13.Resposta1 = "Sydney";
Q13.Resposta2 = "Melbourne";
Q13.Resposta3 = "Canberra";
Q13.Resposta4 = "Brisbane";
Q13.Resposta5 = "Perth";
Q13.Respostacorreta = 3;
Q13.ConfiguraEstruturaDesenho(labelpergunta, button1, button2, button3, button4, button5);
listaQuestoes.Add(Q13);

var Q14 = new Questao();
Q14.Pergunta = "Qual é o esporte mais popular do mundo?";
Q14.Resposta1 = "Basquete";
Q14.Resposta2 = "Futebol";
Q14.Resposta3 = "Críquete";
Q14.Resposta4 = "Tênis";
Q14.Resposta5 = "Rugby";
Q14.Respostacorreta = 2;
Q14.ConfiguraEstruturaDesenho(labelpergunta, button1, button2, button3, button4, button5);
listaQuestoes.Add(Q14);

var Q15 = new Questao();
Q15.Pergunta = "Qual é o maior planeta do sistema solar?";
Q15.Resposta1 = "Terra";
Q15.Resposta2 = "Marte";
Q15.Resposta3 = "Júpiter";
Q15.Resposta4 = "Saturno";
Q15.Resposta5 = "Urano";
Q15.Respostacorreta = 3;
Q15.ConfiguraEstruturaDesenho(labelpergunta, button1, button2, button3, button4, button5);
listaQuestoes.Add(Q15);

// Continue assim até Q99...

var Q16 = new Questao();
Q16.Pergunta = "Quem foi o primeiro homem a pisar na Lua?";
Q16.Resposta1 = "Buzz Aldrin";
Q16.Resposta2 = "Yuri Gagarin";
Q16.Resposta3 = "Neil Armstrong";
Q16.Resposta4 = "John Glenn";
Q16.Resposta5 = "Michael Collins";
Q16.Respostacorreta = 3;
Q16.ConfiguraEstruturaDesenho(labelpergunta, button1, button2, button3, button4, button5);
listaQuestoes.Add(Q16);

var Q17 = new Questao();
Q17.Pergunta = "Qual é o maior deserto do mundo?";
Q17.Resposta1 = "Sahara";
Q17.Resposta2 = "Gobi";
Q17.Resposta3 = "Antártica";
Q17.Resposta4 = "Kalahari";
Q17.Resposta5 = "Atacama";
Q17.Respostacorreta = 3;
Q17.ConfiguraEstruturaDesenho(labelpergunta, button1, button2, button3, button4, button5);
listaQuestoes.Add(Q17);

var Q18 = new Questao();
Q18.Pergunta = "Qual é o metal líquido à temperatura ambiente?";
Q18.Resposta1 = "Mercúrio";
Q18.Resposta2 = "Gálio";
Q18.Resposta3 = "Chumbo";
Q18.Resposta4 = "Prata";
Q18.Resposta5 = "Ouro";
Q18.Respostacorreta = 1;
Q18.ConfiguraEstruturaDesenho(labelpergunta, button1, button2, button3, button4, button5);
listaQuestoes.Add(Q18);

var Q19 = new Questao();
Q19.Pergunta = "Qual é a língua mais falada do mundo?";
Q19.Resposta1 = "Inglês";
Q19.Resposta2 = "Mandarim";
Q19.Resposta3 = "Espanhol";
Q19.Resposta4 = "Hindi";
Q19.Resposta5 = "Árabe";
Q19.Respostacorreta = 2;
Q19.ConfiguraEstruturaDesenho(labelpergunta, button1, button2, button3, button4, button5);
listaQuestoes.Add(Q19);

var Q20 = new Questao();
Q20.Pergunta = "Quem é o deus grego do trovão?";
Q20.Resposta1 = "Hades";
Q20.Resposta2 = "Zeus";
Q20.Resposta3 = "Poseidon";
Q20.Resposta4 = "Apolo";
Q20.Resposta5 = "Ares";
Q20.Respostacorreta = 2;
Q20.ConfiguraEstruturaDesenho(labelpergunta, button1, button2, button3, button4, button5);
listaQuestoes.Add(Q20);

var Q21 = new Questao();
Q21.Pergunta = "Qual é a maior montanha do mundo?";
Q21.Resposta1 = "K2";
Q21.Resposta2 = "Everest";
Q21.Resposta3 = "Kilimanjaro";
Q21.Resposta4 = "Aconcágua";
Q21.Resposta5 = "Makalu";
Q21.Respostacorreta = 2;
Q21.ConfiguraEstruturaDesenho(labelpergunta, button1, button2, button3, button4, button5);
listaQuestoes.Add(Q21);

var Q22 = new Questao();
Q22.Pergunta = "Qual é o maior país do mundo?";
Q22.Resposta1 = "China";
Q22.Resposta2 = "Canadá";
Q22.Resposta3 = "Rússia";
Q22.Resposta4 = "Estados Unidos";
Q22.Resposta5 = "Brasil";
Q22.Respostacorreta = 3;
Q22.ConfiguraEstruturaDesenho(labelpergunta, button1, button2, button3, button4, button5);
listaQuestoes.Add(Q22);

var Q23 = new Questao();
Q23.Pergunta = "Qual é a principal religião da Índia?";
Q23.Resposta1 = "Cristianismo";
Q23.Resposta2 = "Hinduísmo";
Q23.Resposta3 = "Islamismo";
Q23.Resposta4 = "Budismo";
Q23.Resposta5 = "Jainismo";
Q23.Respostacorreta = 2;
Q23.ConfiguraEstruturaDesenho(labelpergunta, button1, button2, button3, button4, button5);
listaQuestoes.Add(Q23);

var Q24 = new Questao();
Q24.Pergunta = "Qual é o maior continente?";
Q24.Resposta1 = "África";
Q24.Resposta2 = "América do Sul";
Q24.Resposta3 = "Ásia";
Q24.Resposta4 = "Europa";
Q24.Resposta5 = "Oceania";
Q24.Respostacorreta = 3;
Q24.ConfiguraEstruturaDesenho(labelpergunta, button1, button2, button3, button4, button5);
listaQuestoes.Add(Q24);

var Q25 = new Questao();
Q25.Pergunta = "Quem descobriu a América?";
Q25.Resposta1 = "Vasco da Gama";
Q25.Resposta2 = "Cristóvão Colombo";
Q25.Resposta3 = "Pedro Álvares Cabral";
Q25.Resposta4 = "Ferdinand Magellan";
Q25.Resposta5 = "Hernán Cortés";
Q25.Respostacorreta = 2;
Q25.ConfiguraEstruturaDesenho(labelpergunta, button1, button2, button3, button4, button5);
listaQuestoes.Add(Q25);

var Q26 = new Questao();
Q26.Pergunta = "Qual é o nome do maior vulcão ativo?";
Q26.Resposta1 = "Kilauea";
Q26.Resposta2 = "Etna";
Q26.Resposta3 = "Mauna Loa";
Q26.Resposta4 = "Fuji";
Q26.Resposta5 = "Kilimanjaro";
Q26.Respostacorreta = 3;
Q26.ConfiguraEstruturaDesenho(labelpergunta, button1, button2, button3, button4, button5);
listaQuestoes.Add(Q26);

var Q27 = new Questao();
Q27.Pergunta = "Quem foi o primeiro presidente dos EUA?";
Q27.Resposta1 = "George Washington";
Q27.Resposta2 = "Thomas Jefferson";
Q27.Resposta3 = "Abraham Lincoln";
Q27.Resposta4 = "Franklin D. Roosevelt";
Q27.Resposta5 = "John Adams";
Q27.Respostacorreta = 1;
Q27.ConfiguraEstruturaDesenho(labelpergunta, button1, button2, button3, button4, button5);
listaQuestoes.Add(Q27);

var Q28 = new Questao();
Q28.Pergunta = "Qual é a principal fonte de energia da Terra?";
Q28.Resposta1 = "Água";
Q28.Resposta2 = "Carvão";
Q28.Resposta3 = "Solar";
Q28.Resposta4 = "Nuclear";
Q28.Resposta5 = "Petróleo";
Q28.Respostacorreta = 3;
Q28.ConfiguraEstruturaDesenho(labelpergunta, button1, button2, button3, button4, button5);
listaQuestoes.Add(Q28);

var Q29 = new Questao();
Q29.Pergunta = "Qual é o maior animal do mundo?";
Q29.Resposta1 = "Elefante";
Q29.Resposta2 = "Baleia Azul";
Q29.Resposta3 = "Tubarão";
Q29.Resposta4 = "Girafa";
Q29.Resposta5 = "Rinoceronte";
Q29.Respostacorreta = 2;
Q29.ConfiguraEstruturaDesenho(labelpergunta, button1, button2, button3, button4, button5);
listaQuestoes.Add(Q29);

var Q30 = new Questao();
Q30.Pergunta = "Qual é o rio mais longo do mundo?";
Q30.Resposta1 = "Amazonas";
Q30.Resposta2 = "Nilo";
Q30.Resposta3 = "Yangtze";
Q30.Resposta4 = "Mississippi";
Q30.Resposta5 = "Ganges";
Q30.Respostacorreta = 2;
Q30.ConfiguraEstruturaDesenho(labelpergunta, button1, button2, button3, button4, button5);
listaQuestoes.Add(Q30);

// Continue até Q99...

var Q31 = new Questao();
Q31.Pergunta = "Qual é o elemento químico com o símbolo 'Na'?";
Q31.Resposta1 = "Sódio";
Q31.Resposta2 = "Nitrogênio";
Q31.Resposta3 = "Nápio";
Q31.Resposta4 = "Neônio";
Q31.Resposta5 = "Nióbio";
Q31.Respostacorreta = 1;
Q31.ConfiguraEstruturaDesenho(labelpergunta, button1, button2, button3, button4, button5);
listaQuestoes.Add(Q31);

var Q32 = new Questao();
Q32.Pergunta = "Qual é o nome do primeiro satélite da Terra?";
Q32.Resposta1 = "Apollo";
Q32.Resposta2 = "Vostok";
Q32.Resposta3 = "Sputnik";
Q32.Resposta4 = "Hubble";
Q32.Resposta5 = "Voyager";
Q32.Respostacorreta = 3;
Q32.ConfiguraEstruturaDesenho(labelpergunta, button1, button2, button3, button4, button5);
listaQuestoes.Add(Q32);

var Q33 = new Questao();
Q33.Pergunta = "Qual país é conhecido como a Terra dos Sorrisos?";
Q33.Resposta1 = "Tailândia";
Q33.Resposta2 = "Japão";
Q33.Resposta3 = "Brasil";
Q33.Resposta4 = "França";
Q33.Resposta5 = "Itália";
Q33.Respostacorreta = 1;
Q33.ConfiguraEstruturaDesenho(labelpergunta, button1, button2, button3, button4, button5);
listaQuestoes.Add(Q33);

var Q34 = new Questao();
Q34.Pergunta = "Quem foi o autor da teoria da relatividade?";
Q34.Resposta1 = "Isaac Newton";
Q34.Resposta2 = "Albert Einstein";
Q34.Resposta3 = "Galileu Galilei";
Q34.Resposta4 = "Niels Bohr";
Q34.Resposta5 = "Stephen Hawking";
Q34.Respostacorreta = 2;
Q34.ConfiguraEstruturaDesenho(labelpergunta, button1, button2, button3, button4, button5);
listaQuestoes.Add(Q34);

var Q35 = new Questao();
Q35.Pergunta = "Qual é o nome da famosa torre inclinada na Itália?";
Q35.Resposta1 = "Torre de Pisa";
Q35.Resposta2 = "Torre de Londres";
Q35.Resposta3 = "Torre Eiffel";
Q35.Resposta4 = "Torre de Belém";
Q35.Resposta5 = "Torre de Dubai";
Q35.Respostacorreta = 1;
Q35.ConfiguraEstruturaDesenho(labelpergunta, button1, button2, button3, button4, button5);
listaQuestoes.Add(Q35);

var Q36 = new Questao();
Q36.Pergunta = "Qual é a maior cidade do mundo?";
Q36.Resposta1 = "Tóquio";
Q36.Resposta2 = "Nova York";
Q36.Resposta3 = "Xangai";
Q36.Resposta4 = "São Paulo";
Q36.Resposta5 = "Mumbai";
Q36.Respostacorreta = 1;
Q36.ConfiguraEstruturaDesenho(labelpergunta, button1, button2, button3, button4, button5);
listaQuestoes.Add(Q36);

var Q37 = new Questao();
Q37.Pergunta = "Qual é o principal gás do efeito estufa?";
Q37.Resposta1 = "Oxigênio";
Q37.Resposta2 = "Dióxido de carbono";
Q37.Resposta3 = "Metano";
Q37.Resposta4 = "Nitrogênio";
Q37.Resposta5 = "Hélio";
Q37.Respostacorreta = 2;
Q37.ConfiguraEstruturaDesenho(labelpergunta, button1, button2, button3, button4, button5);
listaQuestoes.Add(Q37);

var Q38 = new Questao();
Q38.Pergunta = "Qual é o idioma oficial do Brasil?";
Q38.Resposta1 = "Espanhol";
Q38.Resposta2 = "Inglês";
Q38.Resposta3 = "Francês";
Q38.Resposta4 = "Português";
Q38.Resposta5 = "Italiano";
Q38.Respostacorreta = 4;
Q38.ConfiguraEstruturaDesenho(labelpergunta, button1, button2, button3, button4, button5);
listaQuestoes.Add(Q38);

var Q39 = new Questao();
Q39.Pergunta = "Qual é a invenção de Thomas Edison?";
Q39.Resposta1 = "Telefone";
Q39.Resposta2 = "Lâmpada";
Q39.Resposta3 = "Rádio";
Q39.Resposta4 = "Televisão";
Q39.Resposta5 = "Computador";
Q39.Respostacorreta = 2;
Q39.ConfiguraEstruturaDesenho(labelpergunta, button1, button2, button3, button4, button5);
listaQuestoes.Add(Q39);

var Q40 = new Questao();
Q40.Pergunta = "Qual é a capital da Itália?";
Q40.Resposta1 = "Roma";
Q40.Resposta2 = "Milão";
Q40.Resposta3 = "Veneza";
Q40.Resposta4 = "Florença";
Q40.Resposta5 = "Nápoles";
Q40.Respostacorreta = 1;
Q40.ConfiguraEstruturaDesenho(labelpergunta, button1, button2, button3, button4, button5);
listaQuestoes.Add(Q40);

var Q41 = new Questao();
Q41.Pergunta = "Qual é o maior continente em área?";
Q41.Resposta1 = "Ásia";
Q41.Resposta2 = "África";
Q41.Resposta3 = "América do Norte";
Q41.Resposta4 = "América do Sul";
Q41.Resposta5 = "Oceania";
Q41.Respostacorreta = 1;
Q41.ConfiguraEstruturaDesenho(labelpergunta, button1, button2, button3, button4, button5);
listaQuestoes.Add(Q41);

var Q42 = new Questao();
Q42.Pergunta = "Quem é conhecido como o 'Rei do Pop'?";
Q42.Resposta1 = "Elvis Presley";
Q42.Resposta2 = "Michael Jackson";
Q42.Resposta3 = "Prince";
Q42.Resposta4 = "Madonna";
Q42.Resposta5 = "Whitney Houston";
Q42.Respostacorreta = 2;
Q42.ConfiguraEstruturaDesenho(labelpergunta, button1, button2, button3, button4, button5);
listaQuestoes.Add(Q42);

var Q43 = new Questao();
Q43.Pergunta = "Qual é o país com a maior população?";
Q43.Resposta1 = "Índia";
Q43.Resposta2 = "China";
Q43.Resposta3 = "Estados Unidos";
Q43.Resposta4 = "Indonésia";
Q43.Resposta5 = "Paquistão";
Q43.Respostacorreta = 2;
Q43.ConfiguraEstruturaDesenho(labelpergunta, button1, button2, button3, button4, button5);
listaQuestoes.Add(Q43);

var Q44 = new Questao();
Q44.Pergunta = "Qual é o elemento químico com o símbolo 'O'?";
Q44.Resposta1 = "Ouro";
Q44.Resposta2 = "Oxigênio";
Q44.Resposta3 = "Ósmio";
Q44.Resposta4 = "Ozônio";
Q44.Resposta5 = "Oganessônio";
Q44.Respostacorreta = 2;
Q44.ConfiguraEstruturaDesenho(labelpergunta, button1, button2, button3, button4, button5);
listaQuestoes.Add(Q44);

var Q45 = new Questao();
Q45.Pergunta = "Qual animal é conhecido como o 'Rei da Selva'?";
Q45.Resposta1 = "Elefante";
Q45.Resposta2 = "Tigre";
Q45.Resposta3 = "Leão";
Q45.Resposta4 = "Urso";
Q45.Resposta5 = "Gorila";
Q45.Respostacorreta = 3;
Q45.ConfiguraEstruturaDesenho(labelpergunta, button1, button2, button3, button4, button5);
listaQuestoes.Add(Q45);

var Q46 = new Questao();
Q46.Pergunta = "Qual é o nome do famoso cientista que desenvolveu a teoria da evolução?";
Q46.Resposta1 = "Isaac Newton";
Q46.Resposta2 = "Charles Darwin";
Q46.Resposta3 = "Galileu Galilei";
Q46.Resposta4 = "Albert Einstein";
Q46.Resposta5 = "Stephen Hawking";
Q46.Respostacorreta = 2;
Q46.ConfiguraEstruturaDesenho(labelpergunta, button1, button2, button3, button4, button5);
listaQuestoes.Add(Q46);

var Q47 = new Questao();
Q47.Pergunta = "Qual é a capital da Espanha?";
Q47.Resposta1 = "Barcelona";
Q47.Resposta2 = "Madrid";
Q47.Resposta3 = "Valência";
Q47.Resposta4 = "Sevilha";
Q47.Resposta5 = "Bilbao";
Q47.Respostacorreta = 2;
Q47.ConfiguraEstruturaDesenho(labelpergunta, button1, button2, button3, button4, button5);
listaQuestoes.Add(Q47);

var Q48 = new Questao();
Q48.Pergunta = "Qual é o principal ingrediente do guacamole?";
Q48.Resposta1 = "Tomate";
Q48.Resposta2 = "Abacate";
Q48.Resposta3 = "Cebola";
Q48.Resposta4 = "Pimenta";
Q48.Resposta5 = "Limão";
Q48.Respostacorreta = 2;
Q48.ConfiguraEstruturaDesenho(labelpergunta, button1, button2, button3, button4, button5);
listaQuestoes.Add(Q48);

var Q49 = new Questao();
Q49.Pergunta = "Qual é a capital do Canadá?";
Q49.Resposta1 = "Toronto";
Q49.Resposta2 = "Vancouver";
Q49.Resposta3 = "Ottawa";
Q49.Resposta4 = "Montreal";
Q49.Resposta5 = "Calgary";
Q49.Respostacorreta = 3;
Q49.ConfiguraEstruturaDesenho(labelpergunta, button1, button2, button3, button4, button5);
listaQuestoes.Add(Q49);

var Q50 = new Questao();
Q50.Pergunta = "Qual é a moeda oficial da União Europeia?";
Q50.Resposta1 = "Libra";
Q50.Resposta2 = "Dólar";
Q50.Resposta3 = "Franco";
Q50.Resposta4 = "Euro";
Q50.Resposta5 = "Coroa";
Q50.Respostacorreta = 4;
Q50.ConfiguraEstruturaDesenho(labelpergunta, button1, button2, button3, button4, button5);
listaQuestoes.Add(Q50);

var Q51 = new Questao();
Q51.Pergunta = "Qual é a cor da bandeira da Rússia?";
Q51.Resposta1 = "Verde, Amarelo e Vermelho";
Q51.Resposta2 = "Azul, Branco e Vermelho";
Q51.Resposta3 = "Vermelho, Branco e Verde";
Q51.Resposta4 = "Preto, Branco e Vermelho";
Q51.Resposta5 = "Azul, Vermelho e Verde";
Q51.Respostacorreta = 2;
Q51.ConfiguraEstruturaDesenho(labelpergunta, button1, button2, button3, button4, button5);
listaQuestoes.Add(Q51);

var Q52 = new Questao();
Q52.Pergunta = "Qual é o planeta conhecido como o Planeta Vermelho?";
Q52.Resposta1 = "Terra";
Q52.Resposta2 = "Marte";
Q52.Resposta3 = "Júpiter";
Q52.Resposta4 = "Saturno";
Q52.Resposta5 = "Mercúrio";
Q52.Respostacorreta = 2;
Q52.ConfiguraEstruturaDesenho(labelpergunta, button1, button2, button3, button4, button5);
listaQuestoes.Add(Q52);

var Q53 = new Questao();
Q53.Pergunta = "Qual é a principal função da hemoglobina?";
Q53.Resposta1 = "Transporte de nutrientes";
Q53.Resposta2 = "Transporte de oxigênio";
Q53.Resposta3 = "Defesa imunológica";
Q53.Resposta4 = "Coagulação do sangue";
Q53.Resposta5 = "Regulação da temperatura";
Q53.Respostacorreta = 2;
Q53.ConfiguraEstruturaDesenho(labelpergunta, button1, button2, button3, button4, button5);
listaQuestoes.Add(Q53);

var Q54 = new Questao();
Q54.Pergunta = "Qual é o oceano mais profundo do mundo?";
Q54.Resposta1 = "Atlântico";
Q54.Resposta2 = "Índico";
Q54.Resposta3 = "Pacífico";
Q54.Resposta4 = "Ártico";
Q54.Resposta5 = "Antártico";
Q54.Respostacorreta = 3;
Q54.ConfiguraEstruturaDesenho(labelpergunta, button1, button2, button3, button4, button5);
listaQuestoes.Add(Q54);

var Q55 = new Questao();
Q55.Pergunta = "Qual é o nome do famoso festival de música realizado em Woodstock?";
Q55.Resposta1 = "Glastonbury";
Q55.Resposta2 = "Coachella";
Q55.Resposta3 = "Lollapalooza";
Q55.Resposta4 = "Woodstock";
Q55.Resposta5 = "Tomorrowland";
Q55.Respostacorreta = 4;
Q55.ConfiguraEstruturaDesenho(labelpergunta, button1, button2, button3, button4, button5);
listaQuestoes.Add(Q55);

var Q56 = new Questao();
Q56.Pergunta = "Quem foi o líder sul-africano que lutou contra o apartheid?";
Q56.Resposta1 = "Desmond Tutu";
Q56.Resposta2 = "Nelson Mandela";
Q56.Resposta3 = "Frederik de Klerk";
Q56.Resposta4 = "Oliver Tambo";
Q56.Resposta5 = "Jacob Zuma";
Q56.Respostacorreta = 2;
Q56.ConfiguraEstruturaDesenho(labelpergunta, button1, button2, button3, button4, button5);
listaQuestoes.Add(Q56);

var Q57 = new Questao();
Q57.Pergunta = "Qual é a capital da França?";
Q57.Resposta1 = "Londres";
Q57.Resposta2 = "Paris";
Q57.Resposta3 = "Berlim";
Q57.Resposta4 = "Roma";
Q57.Resposta5 = "Madri";
Q57.Respostacorreta = 2;
Q57.ConfiguraEstruturaDesenho(labelpergunta, button1, button2, button3, button4, button5);
listaQuestoes.Add(Q57);

var Q58 = new Questao();
Q58.Pergunta = "Qual é a montanha mais alta da América do Sul?";
Q58.Resposta1 = "Aconcágua";
Q58.Resposta2 = "Everest";
Q58.Resposta3 = "Kilimanjaro";
Q58.Resposta4 = "Denali";
Q58.Resposta5 = "Huascarán";
Q58.Respostacorreta = 1;
Q58.ConfiguraEstruturaDesenho(labelpergunta, button1, button2, button3, button4, button5);
listaQuestoes.Add(Q58);

var Q59 = new Questao();
Q59.Pergunta = "Qual é a maior floresta tropical do mundo?";
Q59.Resposta1 = "Floresta Amazônica";
Q59.Resposta2 = "Floresta do Congo";
Q59.Resposta3 = "Floresta Boreal";
Q59.Resposta4 = "Floresta Atlântica";
Q59.Resposta5 = "Floresta de Taiga";
Q59.Respostacorreta = 1;
Q59.ConfiguraEstruturaDesenho(labelpergunta, button1, button2, button3, button4, button5);
listaQuestoes.Add(Q59);

var Q60 = new Questao();
Q60.Pergunta = "Qual é a unidade de medida da pressão?";
Q60.Resposta1 = "Pascal";
Q60.Resposta2 = "Joule";
Q60.Resposta3 = "Watt";
Q60.Resposta4 = "Newton";
Q60.Resposta5 = "Bar";
Q60.Respostacorreta = 1;
Q60.ConfiguraEstruturaDesenho(labelpergunta, button1, button2, button3, button4, button5);
listaQuestoes.Add(Q60);

var Q61 = new Questao();
Q61.Pergunta = "Qual é o nome do famoso quadro de Leonardo da Vinci com uma mulher sorrindo?";
Q61.Resposta1 = "A Última Ceia";
Q61.Resposta2 = "A Criação de Adão";
Q61.Resposta3 = "A Monalisa";
Q61.Resposta4 = "O Nascimento de Vênus";
Q61.Resposta5 = "A Escola de Atenas";
Q61.Respostacorreta = 3;
Q61.ConfiguraEstruturaDesenho(labelpergunta, button1, button2, button3, button4, button5);
listaQuestoes.Add(Q61);

var Q62 = new Questao();
Q62.Pergunta = "Qual é o símbolo químico do ouro?";
Q62.Resposta1 = "Au";
Q62.Resposta2 = "Ag";
Q62.Resposta3 = "Fe";
Q62.Resposta4 = "Pb";
Q62.Resposta5 = "Hg";
Q62.Respostacorreta = 1;
Q62.ConfiguraEstruturaDesenho(labelpergunta, button1, button2, button3, button4, button5);
listaQuestoes.Add(Q62);

var Q63 = new Questao();
Q63.Pergunta = "Qual é o animal que é conhecido por sua habilidade de mudar de cor?";
Q63.Resposta1 = "Camaleão";
Q63.Resposta2 = "Lobo";
Q63.Resposta3 = "Leão";
Q63.Resposta4 = "Urso";
Q63.Resposta5 = "Águia";
Q63.Respostacorreta = 1;
Q63.ConfiguraEstruturaDesenho(labelpergunta, button1, button2, button3, button4, button5);
listaQuestoes.Add(Q63);

var Q64 = new Questao();
Q64.Pergunta = "Quem pintou o teto da Capela Sistina?";
Q64.Resposta1 = "Michelangelo";
Q64.Resposta2 = "Leonardo da Vinci";
Q64.Resposta3 = "Rafael";
Q64.Resposta4 = "Caravaggio";
Q64.Resposta5 = "Donatello";
Q64.Respostacorreta = 1;
Q64.ConfiguraEstruturaDesenho(labelpergunta, button1, button2, button3, button4, button5);
listaQuestoes.Add(Q64);

var Q65 = new Questao();
Q65.Pergunta = "Qual é a capital da Austrália?";
Q65.Resposta1 = "Sydney";
Q65.Resposta2 = "Melbourne";
Q65.Resposta3 = "Canberra";
Q65.Resposta4 = "Brisbane";
Q65.Resposta5 = "Perth";
Q65.Respostacorreta = 3;
Q65.ConfiguraEstruturaDesenho(labelpergunta, button1, button2, button3, button4, button5);
listaQuestoes.Add(Q65);

var Q66 = new Questao();
Q66.Pergunta = "Qual é a principal língua falada no Brasil?";
Q66.Resposta1 = "Espanhol";
Q66.Resposta2 = "Francês";
Q66.Resposta3 = "Inglês";
Q66.Resposta4 = "Português";
Q66.Resposta5 = "Italiano";
Q66.Respostacorreta = 4;
Q66.ConfiguraEstruturaDesenho(labelpergunta, button1, button2, button3, button4, button5);
listaQuestoes.Add(Q66);

var Q67 = new Questao();
Q67.Pergunta = "Qual é o nome do famoso detetive criado por Arthur Conan Doyle?";
Q67.Resposta1 = "Hercule Poirot";
Q67.Resposta2 = "Sherlock Holmes";
Q67.Resposta3 = "Miss Marple";
Q67.Resposta4 = "Philip Marlowe";
Q67.Resposta5 = "Sam Spade";
Q67.Respostacorreta = 2;
Q67.ConfiguraEstruturaDesenho(labelpergunta, button1, button2, button3, button4, button5);
listaQuestoes.Add(Q67);

var Q68 = new Questao();
Q68.Pergunta = "Qual é o maior animal terrestre?";
Q68.Resposta1 = "Girafa";
Q68.Resposta2 = "Elefante Africano";
Q68.Resposta3 = "Rinoceronte";
Q68.Resposta4 = "Hipopótamo";
Q68.Resposta5 = "Búfalo";
Q68.Respostacorreta = 2;
Q68.ConfiguraEstruturaDesenho(labelpergunta, button1, button2, button3, button4, button5);
listaQuestoes.Add(Q68);

var Q69 = new Questao();
Q69.Pergunta = "Quem foi o primeiro homem a pisar na Lua?";
Q69.Resposta1 = "Buzz Aldrin";
Q69.Resposta2 = "Yuri Gagarin";
Q69.Resposta3 = "Neil Armstrong";
Q69.Resposta4 = "John Glenn";
Q69.Resposta5 = "Michael Collins";
Q69.Respostacorreta = 3;
Q69.ConfiguraEstruturaDesenho(labelpergunta, button1, button2, button3, button4, button5);
listaQuestoes.Add(Q69);

var Q70 = new Questao();
Q70.Pergunta = "Qual é o nome da famosa cadeia de montanhas que se estende pela América do Sul?";
Q70.Resposta1 = "Alpes";
Q70.Resposta2 = "Andes";
Q70.Resposta3 = "Rocosas";
Q70.Resposta4 = "Himalaias";
Q70.Resposta5 = "Apalaches";
Q70.Respostacorreta = 2;
Q70.ConfiguraEstruturaDesenho(labelpergunta, button1, button2, button3, button4, button5);
listaQuestoes.Add(Q70);

var Q71 = new Questao();
Q71.Pergunta = "Qual é a capital do Japão?";
Q71.Resposta1 = "Tóquio";
Q71.Resposta2 = "Pequim";
Q71.Resposta3 = "Seul";
Q71.Resposta4 = "Bangkok";
Q71.Resposta5 = "Hanoí";
Q71.Respostacorreta = 1;
Q71.ConfiguraEstruturaDesenho(labelpergunta, button1, button2, button3, button4, button5);
listaQuestoes.Add(Q71);

var Q72 = new Questao();
Q72.Pergunta = "Qual é a fórmula química da água?";
Q72.Resposta1 = "H2O";
Q72.Resposta2 = "CO2";
Q72.Resposta3 = "O2";
Q72.Resposta4 = "NaCl";
Q72.Resposta5 = "H2SO4";
Q72.Respostacorreta = 1;
Q72.ConfiguraEstruturaDesenho(labelpergunta, button1, button2, button3, button4, button5);
listaQuestoes.Add(Q72);

var Q72 = new Questao(); 
Q72.Pergunta= "Quem é o vilão da Rapunzel";
Q72.Resposta1= "Malévola";
Q72.Resposta2= "Úrsula";
Q72.Resposta3= "Gothel";
Q72.Resposta4= "Cruella";
Q72.Resposta5= "Rainha Má";
Q72.Respostacorreta= 3;
Q72.ConfiguraEstruturaDesenho(labelpergunta, button1, button2, button3, button4, button5 );
listaQuestoes.Add(Q72);

var Q73 = new Questao(); 
Q73.Pergunta= "Qual é o nome do rato amigo da Cinderela?";
Q73.Resposta1= "Gus";
Q73.Resposta2= "Lumière";
Q73.Resposta3= "Jaq";
Q73.Resposta4= "Timão";
Q73.Resposta5= "Remy";
Q73.Respostacorreta= 1;
Q73.ConfiguraEstruturaDesenho(labelpergunta, button1, button2, button3, button4, button5 );
listaQuestoes.Add(Q73);

var Q74 = new Questao(); 
Q74.Pergunta= "Em que ano foi lançado o filme Frozen?";
Q74.Resposta1= "2010";
Q74.Resposta2= "2012";
Q74.Resposta3= "2013";
Q74.Resposta4= "2015";
Q74.Resposta5= "2016";
Q74.Respostacorreta= 3;
Q74.ConfiguraEstruturaDesenho(labelpergunta, button1, button2, button3, button4, button5 );
listaQuestoes.Add(Q74);

var Q75 = new Questao(); 
Q75.Pergunta= "Qual é o nome do brinquedo cowboy em Toy Story?";
Q75.Resposta1= "Buzz Lightyear";
Q75.Resposta2= "Woody";
Q75.Resposta3= "Jessie";
Q75.Resposta4= "Sr. Cabeça de Batata";
Q75.Resposta5= "Slinky";
Q75.Respostacorreta= 2;
Q75.ConfiguraEstruturaDesenho(labelpergunta, button1, button2, button3, button4, button5 );
listaQuestoes.Add(Q75);

var Q76 = new Questao(); 
Q76.Pergunta= "Quem é o vilão em A Pequena Sereia?";
Q76.Resposta1= "Scar";
Q76.Resposta2= "Hades";
Q76.Resposta3= "Úrsula";
Q76.Resposta4= "Jafar";
Q76.Resposta5= "Dr. Facilier";
Q76.Respostacorreta= 3;
Q76.ConfiguraEstruturaDesenho(labelpergunta, button1, button2, button3, button4, button5 );
listaQuestoes.Add(Q76);

var Q77 = new Questao(); 
Q77.Pergunta= "Qual é o nome da princesa de A Bela e a Fera?";
Q77.Resposta1= "Aurora";
Q77.Resposta2= "Branca de Neve";
Q77.Resposta3= "Bela";
Q77.Resposta4= "Ariel";
Q77.Resposta5= "Cinderela";
Q77.Respostacorreta= 3;
Q77.ConfiguraEstruturaDesenho(labelpergunta, button1, button2, button3, button4, button5 );
listaQuestoes.Add(Q77);

var Q78 = new Questao(); 
Q78.Pergunta= "Qual o nome do dragão em Mulan?";
Q78.Resposta1= "Mushu";
Q78.Resposta2= "Khan";
Q78.Resposta3= "Sisu";
Q78.Resposta4= "Falkor";
Q78.Resposta5= "Tiamat";
Q78.Respostacorreta= 1;
Q78.ConfiguraEstruturaDesenho(labelpergunta, button1, button2, button3, button4, button5 );
listaQuestoes.Add(Q78);

var Q79 = new Questao(); 
Q79.Pergunta= "Qual é o nome do reino onde Elsa e Anna vivem?";
Q79.Resposta1= "Corona";
Q79.Resposta2= "Arendelle";
Q79.Resposta3= "Atlantis";
Q79.Resposta4= "Agrabah";
Q79.Resposta5= "Naboo";
Q79.Respostacorreta= 2;
Q79.ConfiguraEstruturaDesenho(labelpergunta, button1, button2, button3, button4, button5 );
listaQuestoes.Add(Q79);

var Q80 = new Questao(); 
Q80.Pergunta= "Qual o nome do gato em Alice no País das Maravilhas?";
Q80.Resposta1= "Cheshire";
Q80.Resposta2= "Figaro";
Q80.Resposta3= "Oliver";
Q80.Resposta4= "Simba";
Q80.Resposta5= "Salem";
Q80.Respostacorreta= 1;
Q80.ConfiguraEstruturaDesenho(labelpergunta, button1, button2, button3, button4, button5 );
listaQuestoes.Add(Q80);

var Q81 = new Questao(); 
Q81.Pergunta= "Quem é o vilão em A Bela Adormecida?";
Q81.Resposta1= "Jafar";
Q81.Resposta2= "Cruella";
Q81.Resposta3= "Malévola";
Q81.Resposta4= "Hades";
Q81.Resposta5= "Capitão Gancho";
Q81.Respostacorreta= 3;
Q81.ConfiguraEstruturaDesenho(labelpergunta, button1, button2, button3, button4, button5 );
listaQuestoes.Add(Q81);

var Q82 = new Questao(); 
Q82.Pergunta= "Qual é o nome do pássaro amigo do Aladdin?";
Q82.Resposta1= "Zazu";
Q82.Resposta2= "Iago";
Q82.Resposta3= "Abu";
Q82.Resposta4= "Diablo";
Q82.Resposta5= "Hei Hei";
Q82.Respostacorreta= 2;
Q82.ConfiguraEstruturaDesenho(labelpergunta, button1, button2, button3, button4, button5 );
listaQuestoes.Add(Q82);

var Q83 = new Questao(); 
Q83.Pergunta= "Qual é o nome do rei leão?";
Q83.Resposta1= "Simba";
Q83.Resposta2= "Mufasa";
Q83.Resposta3= "Scar";
Q83.Resposta4= "Sarabi";
Q83.Resposta5= "Nala";
Q83.Respostacorreta= 1;
Q83.ConfiguraEstruturaDesenho(labelpergunta, button1, button2, button3, button4, button5 );
listaQuestoes.Add(Q83);

var Q84 = new Questao(); 
Q84.Pergunta= "Quem são os pais de Hércules na mitologia grega?";
Q84.Resposta1= "Zeus e Hera";
Q84.Resposta2= "Poseidon e Anfitrite";
Q84.Resposta3= "Hades e Perséfone";
Q84.Resposta4= "Apolo e Ártemis";
Q84.Resposta5= "Ares e Afrodite";
Q84.Respostacorreta= 1;
Q84.ConfiguraEstruturaDesenho(labelpergunta, button1, button2, button3, button4, button5 );
listaQuestoes.Add(Q84);

var Q85 = new Questao(); 
Q85.Pergunta= "Qual é o nome da cidade onde a história de Zootopia acontece?";
Q85.Resposta1= "Zootropolis";
Q85.Resposta2= "Animaltown";
Q85.Resposta3= "Zootopia";
Q85.Resposta4= "Safari City";
Q85.Resposta5= "Metropolis";
Q85.Respostacorreta= 3;
Q85.ConfiguraEstruturaDesenho(labelpergunta, button1, button2, button3, button4, button5 );
listaQuestoes.Add(Q85);

// Repita o padrão para os próximos 15 códigos.
var Q86 = new Questao(); 
Q86.Pergunta= "Qual é o nome do peixe-palhaço em Procurando Nemo?";
Q86.Resposta1= "Dory";
Q86.Resposta2= "Marlin";
Q86.Resposta3= "Bruce";
Q86.Resposta4= "Nemo";
Q86.Resposta5= "Gill";
Q86.Respostacorreta= 4;
Q86.ConfiguraEstruturaDesenho(labelpergunta, button1, button2, button3, button4, button5 );
listaQuestoes.Add(Q86);

var Q87 = new Questao(); 
Q87.Pergunta= "Qual é o nome da cidade no filme Moana?";
Q87.Resposta1= "Motunui";
Q87.Resposta2= "Agrabah";
Q87.Resposta3= "Atlantis";
Q87.Resposta4= "Corona";
Q87.Resposta5= "Pandora";
Q87.Respostacorreta= 1;
Q87.ConfiguraEstruturaDesenho(labelpergunta, button1, button2, button3, button4, button5 );
listaQuestoes.Add(Q87);

var Q88 = new Questao(); 
Q88.Pergunta= "Quem é o vilão em O Rei Leão?";
Q88.Resposta1= "Shenzi";
Q88.Resposta2= "Scar";
Q88.Resposta3= "Zira";
Q88.Resposta4= "Hiena";
Q88.Resposta5= "Mufasa";
Q88.Respostacorreta= 2;
Q88.ConfiguraEstruturaDesenho(labelpergunta, button1, button2, button3, button4, button5 );
listaQuestoes.Add(Q88);

var Q89 = new Questao(); 
Q89.Pergunta= "Qual é o nome da princesa em A Princesa e o Sapo?";
Q89.Resposta1= "Ariel";
Q89.Resposta2= "Tiana";
Q89.Resposta3= "Mulan";
Q89.Resposta4= "Bela";
Q89.Resposta5= "Merida";
Q89.Respostacorreta= 2;
Q89.ConfiguraEstruturaDesenho(labelpergunta, button1, button2, button3, button4, button5 );
listaQuestoes.Add(Q89);

var Q90 = new Questao(); 
Q90.Pergunta= "Qual é o nome do cachorro em Up - Altas Aventuras?";
Q90.Resposta1= "Bolt";
Q90.Resposta2= "Dug";
Q90.Resposta3= "Pluto";
Q90.Resposta4= "Snoopy";
Q90.Resposta5= "Max";
Q90.Respostacorreta= 2;
Q90.ConfiguraEstruturaDesenho(labelpergunta, button1, button2, button3, button4, button5 );
listaQuestoes.Add(Q90);

var Q91 = new Questao(); 
Q91.Pergunta= "Quem é o vilão em Aladdin?";
Q91.Resposta1= "Scar";
Q91.Resposta2= "Hades";
Q91.Resposta3= "Jafar";
Q91.Resposta4= "Úrsula";
Q91.Resposta5= "Cruella";
Q91.Respostacorreta= 3;
Q91.ConfiguraEstruturaDesenho(labelpergunta, button1, button2, button3, button4, button5 );
listaQuestoes.Add(Q91);

var Q92 = new Questao(); 
Q92.Pergunta= "Quem é a princesa que perde seu sapato de cristal?";
Q92.Resposta1= "Branca de Neve";
Q92.Resposta2= "Cinderela";
Q92.Resposta3= "Aurora";
Q92.Resposta4= "Bela";
Q92.Resposta5= "Tiana";
Q92.Respostacorreta= 2;
Q92.ConfiguraEstruturaDesenho(labelpergunta, button1, button2, button3, button4, button5 );
listaQuestoes.Add(Q92);

var Q93 = new Questao(); 
Q93.Pergunta= "Qual é o nome do tigre amigo do Aladdin?";
Q93.Resposta1= "Rajah";
Q93.Resposta2= "Shere Khan";
Q93.Resposta3= "Simba";
Q93.Resposta4= "Bagheera";
Q93.Resposta5= "Nala";
Q93.Respostacorreta= 1;
Q93.ConfiguraEstruturaDesenho(labelpergunta, button1, button2, button3, button4, button5 );
listaQuestoes.Add(Q93);

var Q94 = new Questao(); 
Q94.Pergunta= "Quem é o vilão de 101 Dálmatas?";
Q94.Resposta1= "Jafar";
Q94.Resposta2= "Hades";
Q94.Resposta3= "Scar";
Q94.Resposta4= "Cruella";
Q94.Resposta5= "Úrsula";
Q94.Respostacorreta= 4;
Q94.ConfiguraEstruturaDesenho(labelpergunta, button1, button2, button3, button4, button5 );
listaQuestoes.Add(Q94);

var Q95 = new Questao(); 
Q95.Pergunta= "Qual é o nome do robô em Big Hero 6?";
Q95.Resposta1= "Wall-E";
Q95.Resposta2= "Baymax";
Q95.Resposta3= "R2-D2";
Q95.Resposta4= "EVA";
Q95.Resposta5= "C-3PO";
Q95.Respostacorreta= 2;
Q95.ConfiguraEstruturaDesenho(labelpergunta, button1, button2, button3, button4, button5 );
listaQuestoes.Add(Q95);

var Q96 = new Questao(); 
Q96.Pergunta= "Qual é o nome da ilha no filme Moana?";
Q96.Resposta1= "Agrabah";
Q96.Resposta2= "Motunui";
Q96.Resposta3= "Pandora";
Q96.Resposta4= "Atlantis";
Q96.Resposta5= "Isla Nublar";
Q96.Respostacorreta= 2;
Q96.ConfiguraEstruturaDesenho(labelpergunta, button1, button2, button3, button4, button5 );
listaQuestoes.Add(Q96);

var Q97 = new Questao(); 
Q97.Pergunta= "Quem é o vilão em A Bela e a Fera?";
Q97.Resposta1= "Gaston";
Q97.Resposta2= "Fera";
Q97.Resposta3= "LeFou";
Q97.Resposta4= "Lumière";
Q97.Resposta5= "Cogsworth";
Q97.Respostacorreta= 1;
Q97.ConfiguraEstruturaDesenho(labelpergunta, button1, button2, button3, button4, button5 );
listaQuestoes.Add(Q97);

var Q98 = new Questao(); 
Q98.Pergunta= "Qual é o nome da princesa que vive no mar?";
Q98.Resposta1= "Ariel";
Q98.Resposta2= "Bela";
Q98.Resposta3= "Cinderela";
Q98.Resposta4= "Aurora";
Q98.Resposta5= "Mulan";
Q98.Respostacorreta= 1;
Q98.ConfiguraEstruturaDesenho(labelpergunta, button1, button2, button3, button4, button5 );
listaQuestoes.Add(Q98);

var Q99 = new Questao(); 
Q99.Pergunta= "Qual é o nome do elefante voador em um filme da Disney?";
Q99.Resposta1= "Dumbo";
Q99.Resposta2= "Simba";
Q99.Resposta3= "Bambi";
Q99.Resposta4= "Baloo";
Q99.Resposta5= "Maximus";
Q99.Respostacorreta= 1;
Q99.ConfiguraEstruturaDesenho(labelpergunta, button1, button2, button3, button4, button5 );
listaQuestoes.Add(Q99);

var Q100 = new Questao(); 
Q100.Pergunta= "Quem é o vilão em Peter Pan?";
Q100.Resposta1= "Jafar";
Q100.Resposta2= "Capitão Gancho";
Q100.Resposta3= "Hades";
Q100.Resposta4= "Scar";
Q100.Resposta5= "Dr. Facilier";
Q100.Respostacorreta= 2;
Q100.ConfiguraEstruturaDesenho(labelpergunta, button1, button2, button3, button4, button5 );
listaQuestoes.Add(Q100);

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