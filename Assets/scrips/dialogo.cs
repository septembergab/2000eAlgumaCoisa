using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Diagnostics;
using UnityEngine.Audio;

public class dialogo : MonoBehaviour
{
    public GameObject ludovico;
    public GameObject jotave;
    public int QuemFala;
    public Text Dialogo;
    public int QualFala;
    public int SomAudio;
    public GameObject Escolha1;
    public GameObject Escolha2;
    public GameObject Escolha3;
    public int Cena;
    public AudioClip audioCafe;
    

    // Start is called before the first frame update
    void Start()
    {
        // aqui pra começar a cena
        Cena = SceneManager.GetActiveScene().buildIndex;
        Dialogo.text = "";
       // aqui que a fala faleria 0, pra em cada clique ir pra proxima cena
        QualFala = 0;
        QuemFala = 0;
        SomAudio = 0;
        Escolha1.SetActive(false);
        Escolha2.SetActive(false);
        Escolha3.SetActive(false);
    }

    // Update is called once per frame
 
    void Update()
    {


        if (SomAudio == 3)
        {
            audioCafe = GetComponent<AudioClip>();

        }




        if (QuemFala == 1)
        {

            ludovico.SetActive(true);
            jotave.SetActive(false);


        }
        if (QuemFala == 2)
        {
            ludovico.SetActive(false);
            jotave.SetActive(true);

        }
        /*if(QuemFala != 1 && QuemFala != 2)
         {
            ludovico.SetActive(false);
            jotave.SetActive(false);
        }*/

        if (Input.GetMouseButtonUp(0))
        {
            // input pra clicar e mudar a fala
            QualFala = QualFala + 1;
            

        }

        //aqui começam as cenas e os diálogos, com as escolhas
        if (Cena == 0)
        {
            switch (QualFala)
            {
                case 0:
                    Dialogo.text = "A";
                    Escolha1.SetActive(true);
                    Escolha2.SetActive(true);
                    Escolha3.SetActive(true);
                    break;

            }
        }
        if (Cena == 1)
        {
            switch (QualFala)
            {
                case 0:
                    Dialogo.text = "";
                    Escolha1.SetActive(true);
                    Escolha2.SetActive(true);
                    Escolha3.SetActive(true);
                    break;

            }
        } 

        if (Cena == 2)
        {
            switch (QualFala)
            {
                case 0:
                    Dialogo.text = "";
                    break;

                case 1:
                    
                    Dialogo.text = "Dono do melhor bar do centro de São Paulo. Famoso pelo seu pingado e pão na chapa. O Bar do Ludovico é sempre muito bem frequentado.";
                    break;

                case 2:
                    Dialogo.text = "Ás 8h da manhã, ele abre seu bar. Assim que prepara o café, ele liga o rádio. Seus clientes sempre variam, mas de manhã é um sucesso entre os estudantes. ";
                    break;

                case 3:
                    
                    Dialogo.text = "A maioria vai tomar café da manhã antes da aula. Ludovico adora, ajuda a matar a saudade dos netos.  Sua esposa, Miriam, sempre disse que pra continuar trabalhando aos 75 anos ou é por necessidade ou por amor. ";
                    break;

                case 4:
                   
                    Dialogo.text = "Com certeza era por amor.";
                    break;

                case 5:
                    Dialogo.text = "Como sempre, um dos seus clientes favoritos chegou. João Victor ia tomar café antes do cursinho. Eles sempre jogavam conversa fora, conversavam sobre a vida.";
                    break;

                case 6:
                    Dialogo.text = "Ludovico apelidou ele de JV, anos atrás quando JV ainda estava na escola. Ludovico viu o menino crescer, acompanhou suas vitórias como se ele fosse da família. ";
                    break;

                case 7:
                    QuemFala = 2;
                    Dialogo.text = "Bom dia, Seu Ludovico. Tudo bem? ";
                    break;

                case 8:
                    QuemFala = 1;
                    Dialogo.text = "Ludovico percebeu que JV parecia chateado.";
                    break;

                case 9:
                    QuemFala = 1;
                    Dialogo.text = "Bom dia, JV. Tudo sim, graças a Deus. E você? Ta bom? Vai querer o de sempre?";
                    break;

                case 10:
                    QuemFala = 2;
                    Dialogo.text = "Ah, tô bem. Sabe como é, né. O cursinho tá me deixando doido. JV suspirou.";
                    break;

                case 11:
                    QuemFala = 2;
                    Dialogo.text = "Vou querer o de sempre sim, por favor.";
                    break;

                case 12:
                    QuemFala = 1;
                    Dialogo.text = "Ah mas tá perto já da prova né? Aquela famosa pra entrar na USP. Não sei o nome, meu neto fez. Não passou de primeira. ";
                    break;

                case 13:
                    SomAudio = 3;
                    Dialogo.text = "Ludovico começou a colocar o café no copo. ";
                    break;

                case 14:
                    QuemFala = 2;
                    Dialogo.text = " É, tá perto sim. É esse final de semana. Tô com medo de não passar, sabe? Minha mãe tem gastado muito dinheiro comigo. ";
                    break;

                case 15:
                    QuemFala = 2;
                    Dialogo.text = "Ela entende que medicina é difícil, mas não sei se conseguiria continuar pagando se eu não passar. ";
                    break;

                case 16:
                    QuemFala = 1;
                    Dialogo.text = "Ela é tão difícil assim? Essa prova? Eu num entendo muito…";
                    break;

                case 17:
                    QuemFala = 2;
                    Dialogo.text = "Ela é bem difícil. Tem muita gente querendo passar em faculdade pública, principalmente na USP. Um pessoal que teria dinheiro pra pagar particular… É direito deles também, mas pra gente que é pobre é mais difícil. ";
                    break;

                case 18:
                    QuemFala = 2;
                    Dialogo.text = "Lá no cursinho tem uma garota que faz á três anos. Estudou nas melhores escolas de São Paulo… Claro que ela tem muito mais chance do que eu, mas imagina… Se ela já tá á três anos, eu não passo, né?";
                    break;


                case 19:
                    QuemFala = 1;
                    Dialogo.text = "Você acha que tenho chance? Que devo tentar?";
                    Escolha1.SetActive(true);
                    Escolha2.SetActive(true);
                    Escolha3.SetActive(true);
                    break;

            }
        }
        if (Cena == 3)
        {
            switch (QualFala)
            {
                case 0:
                    QuemFala = 1;
                    Dialogo.text = "Acho importante você tentar. Você tá se dedicando tanto.";
                    break;

                case 1:
                    QuemFala = 2;
                    Dialogo.text = "Ah, eu sei... Mas tenho medo de ser perda de tempo.";
                    break;

                case 2:
                    QuemFala = 1;
                    Dialogo.text = "Duvido muito que seria, JV.";
                    break;

                case 3:
                    QuemFala = 1;
                    Dialogo.text = "Mas você tem que ter em mente que:";
                    Escolha1.SetActive(true);
                    Escolha2.SetActive(true);
                    Escolha3.SetActive(true);
                    break;

            }
        }



        if (Cena == 4)
        {
            switch (QualFala)
            {
                case 0:
                    QuemFala = 1;
                    Dialogo.text = "Pensa no tanto que você estudou pra chegar até aqui.";
                    break;

                case 1:
                    QuemFala = 2;
                    Dialogo.text = "Eu sei, mas mesmo assim tenho medo de não passar. Jogar o dinheiro dela fora, sabe?";
                    break;

                case 2:
                    QuemFala = 1;
                    Dialogo.text = "Tenho certeza que sua mãe não pensaria dessa forma";
                    break;

                case 3:
                    QuemFala = 1;
                    Dialogo.text = "Você sabe que:";
                    Escolha1.SetActive(true);
                    Escolha2.SetActive(true);
                    Escolha3.SetActive(true);
                    break;

            }




        }
        if (Cena == 5)
        {
            switch (QualFala)
            {
                case 0:
                    QuemFala = 1;
                    Dialogo.text = "Você sente que não vai conseguir passar?";
                    break;
                case 1:
                    QuemFala = 2;
                    Dialogo.text = "Acho que não tô tendo o melhor aproveitamento";
                    break;
                case 2:
                    QuemFala = 1;
                    Dialogo.text = "Se você acha que vai ser perda de tempo, talvez não seja a melhor opção. Você acha que sua mãe ficaria brava?";
                    break;
                case 3:
                    QuemFala = 2;
                    Dialogo.text = "Talvez decepcionada.";
                    break;

                case 4:
                    QuemFala = 1;
                    Dialogo.text = "Mas você pensa muito no seu futuro em medicina? É algo que você quer muito?";
                    Escolha1.SetActive(true);
                    Escolha2.SetActive(true);
                    Escolha3.SetActive(true);
                    break;


            }

        }
        if (Cena == 6)
        {
            switch (QualFala)
            {
                case 0:
                    QuemFala = 1;
                    Dialogo.text = "Tá todo mundo vendo você estudando e correndo atrás.";
                    break;

                case 1:
                    QuemFala = 2;
                    Dialogo.text = "Mas e se isso não for o bastante, sabe? Tenho medo de estar me esforçando por algo que não tenho chances nenhuma de passar.";
                    break;

                case 2:
                    QuemFala = 1;
                    Dialogo.text = "JV...";
                    Escolha1.SetActive(true);
                    Escolha2.SetActive(true);
                    Escolha3.SetActive(true);
                    break;
            }
        }

        if (Cena == 7)
        {
            switch (QualFala)
            {
                case 0:
                    QuemFala = 1;
                    Dialogo.text = "Bom, na minha época, trabalhar sempre foi mais importante. ";
                    break;

                case 1:
                    QuemFala = 2;
                    Dialogo.text = "Afinal, é isso que vai fazer entrar dinheiro em casa.";
                    break;
                case 2:
                    QuemFala = 1;
                    Dialogo.text = "Talvez se você quiser ajudar sua mãe, a melhor opção seria trabalhar, posso ver se encontro algo pra você por aqui.";
                    break;

                case 3:
                    QuemFala = 2;
                    Dialogo.text = "É, acho que minha mãe ficaria até feliz se eu ajudasse com a renda de casa.";
                    break;

                case 4:
                    QuemFala = 2;
                    Dialogo.text = "Conseguisse dar menos gastos e ajudar com as contas.";
                    break;

                case 5:
                    QuemFala = 1;
                    Dialogo.text = "É, mas: ";
                    Escolha1.SetActive(true);
                    Escolha2.SetActive(true);
                    Escolha3.SetActive(true);
                    break;

            }
        }

        if (Cena == 8)
        {
            switch (QualFala)
            {
                case 0:
                    QuemFala = 1;
                    Dialogo.text = "Você tem muita coisa pela frente, JV. ";
                    break;

                case 1:
                    QuemFala = 1;
                    Dialogo.text = "Você é jovem, não tem que colocar tanto peso nas suas decisões agora.";
                    break;

                case 2:
                    QuemFala = 1;
                    Dialogo.text = "Sua mãe te acompanha, vê que você não falta às aulas, vê que se esforça.";
                    break;

                case 3:
                    QuemFala = 1;
                    Dialogo.text = "Não tem motivos pra você se cobrar tanto agora.";
                    break;

                case 4:
                    QuemFala = 2;
                    Dialogo.text = "Eu realmente espero que dê certo. Eu quero muito.";
                    break;

                case 5:
                    QuemFala = 1;
                    Dialogo.text = "Jv, não tenha medo de errar.";
                    break;

                case 6:
                    QuemFala = 1;
                    Dialogo.text = "Você ainda é jovem, tem tempo para escolher o que quer fazer.";
                    Escolha1.SetActive(true);
                    Escolha2.SetActive(true);
                    Escolha3.SetActive(true);
                    break;

            }
        }


        if (Cena == 9)
        {
            switch (QualFala)
            {
                case 0:
                    QuemFala = 1;
                    Dialogo.text = "Se seu objetivo é ajudar em casa, independente do seu diploma, ganharia bem mais se você fizesse alguma faculdade.";
                    break;

                case 1:
                    QuemFala = 1;
                    Dialogo.text = "Falo por mim. Eu amo o que eu faço, mas eu teria mais oportunidades se tivesse escolhido estudar. Meu bar podia não ter dado certo.";
                    break;                

                case 2:
                    QuemFala = 1;
                    Dialogo.text = "Aproveita o tempo que você tem.";
                    Escolha1.SetActive(true);
                    Escolha2.SetActive(true);
                    Escolha3.SetActive(true);
                    break;

            }
        }

        if (Cena == 10)
        {
            switch (QualFala)
            {
                case 0:
                    QuemFala = 1;
                    Dialogo.text = "Você escolhendo outro curso, talvez seja mais fácil. Você já pensou nisso?";
                    break;

                case 1:
                    QuemFala = 2;
                    Dialogo.text = "Nunca me interessei muito por outro curso,  sempre quis ajudar as pessoas. Desde pequenininho, você lembra, né?";
                    break;

                case 2:
                    QuemFala = 1;
                    Dialogo.text = "Lembro sim… Você pequenininho vinha pra cá com aquele negócio de colocar no pescoço, qual o nome mesmo?";
                    break;

                case 3:
                    QuemFala = 2;
                    Dialogo.text = "Estetoscópio. Hahahah.";
                    break;

                case 4:
                    QuemFala = 1;
                    Dialogo.text = "Hahahaha. Mas meu filho, não existem outros cursos? Enfermagem, não conheço muito… Mas talvez tenham outras possibilidades.";
                    break;

                case 5:
                    QuemFala = 2;
                    Dialogo.text = "É, tem razão. Meu medo de não passar é porque sei que minha mãe não teria dinheiro pra pagar outro ano de cursinho.";
                    break;

                case 6:
                    QuemFala = 1;
                    Dialogo.text = "Você tem tempo, filho. Tempo de tentar e errar.";
                    Escolha1.SetActive(true);
                    Escolha2.SetActive(true);
                    Escolha3.SetActive(true);
                    break;

            }
        }

        if (Cena == 11)
        {
            switch (QualFala)
            {
                case 0:
                    QuemFala = 1;
                    Dialogo.text = "É importante você focar nos estudos agora, mesmo que talvez sua mãe não consiga pagar ano que vem...";
                    break;

                case 1:
                    QuemFala = 2;
                    Dialogo.text = "Infelizmente, nem todo mundo tem as mesmas oportunidades.";
                    break;

                case 2:
                    QuemFala = 2;
                    Dialogo.text = "Eu fico triste em pensar que se minha família tivesse mais dinheiro, seria tudo mais fácil.";
                    break;
                                    
                case 3:
                    QuemFala = 1;
                    Dialogo.text = "Não pensa nisso. Pensa apenas no seu futuro.";
                    Escolha1.SetActive(true);
                    Escolha2.SetActive(true);
                    Escolha3.SetActive(true);
                    break;

            }
        }

        if (Cena == 12)
        {
            switch (QualFala)
            {
                case 0:
                    QuemFala = 1;
                    Dialogo.text = "Eu entendo o peso que é deixar na mão de um jovem o seu futuro.";
                    break;

                case 1:
                    QuemFala = 1;
                    Dialogo.text = "Mas eu sei, Jv… Eu te conheço, você sabe. Te vejo aqui estudando, subindo e descendo com esse tanto de livros. ";
                    break;

                case 2:
                    QuemFala = 1;
                    Dialogo.text = "Não duvida da sua capacidade, você nunca vai saber o resultado se não tentar.";
                    break;

                case 3:
                    QuemFala = 1;
                    Dialogo.text = "E sei que você iria se arrepender de não ter tentado.";
                    break;

                case 4:
                    QuemFala = 1;
                    Dialogo.text = "Você é um jovem prodígio. Só de ter essa cabeça.";
                    break;

                case 5:
                    QuemFala = 2;
                    Dialogo.text = "Valeu mesmo, Seu Ludovico. Você é incrível.";
                    break;

                case 6:
                    QuemFala = 2;
                    Dialogo.text = "Acho que sei o que vou fazer.";
                    break;

                case 7:
                    QuemFala = 2;
                    Dialogo.text = "Vou indo nessa! Até depois, fica com Deus!!";
                    break;

                case 8:
                    QuemFala = 1;
                    Dialogo.text = "Não vou desejar sorte, porque quem se dedica não precisa de sorte. ";
                    break;

                case 9:
                    QuemFala = 1;
                    Dialogo.text = "Vai com Ele, JV.  Manda um abraço pra sua mãe!";
                    Escolha1.SetActive(true);
                    Escolha2.SetActive(true);
                    Escolha3.SetActive(true);
                    break;

            }
        }

        if (Cena == 13)
        {
            switch (QualFala)
            {
                case 0:
                    QuemFala = 1;
                    Dialogo.text = "Você é muito jovem, JV. O mundo cabe na sua mão.";
                    break;

                case 1:
                    QuemFala = 1;
                    Dialogo.text = "Suas escolhas de hoje são importantes, mas você tem tempo.";
                    break;

                case 2:
                    QuemFala = 1;
                    Dialogo.text = "O seu sonho pode ser realizado, mesmo que não seja agora.";
                    break;

                case 3:
                    Dialogo.text = "…";
                    break;

                case 4:
                    QuemFala = 1;
                    Dialogo.text = "A única pessoa que você depende para realizar seu sonho é você mesmo";
                    Escolha1.SetActive(true);
                    Escolha2.SetActive(true);
                    Escolha3.SetActive(true);
                    break;

            }
        }

        if (Cena == 14)
        {
            switch (QualFala)
            {
                case 0:
                    Dialogo.text = "...alguns meses depois...";
                Escolha1.SetActive(true);
                Escolha2.SetActive(true);
                Escolha3.SetActive(true);
                    break;
            }
        }

        if (Cena == 15)
        {
            switch (QualFala)
            {
                case 0:
                    Dialogo.text = "8h da manhã em ponto, Ludovico abre seu bar. O dia estava nublado, do jeito que ele gostava. ";
                    break;

                case 1:
                    Dialogo.text = "Ele começou a fazer o café e a limpar o balcão.  Novamente ligou o rádio, até que em uma das notícias ouviu sobre a fuvest";
                    break;

                case 2:
                    Dialogo.text = "…";
                    break;

                case 3:
                    Dialogo.text = "Foi só pensar em JV, que o viu chegando de longe.";
                    break;


                case 4:
                    QuemFala = 2;
                    Dialogo.text = "Opa, Seu Ludovico! Vim aqui contar pro senhor, eu passei na prova!!!";
                    break;


                case 5:
                    QuemFala = 1;
                    Dialogo.text = "Graças a Deus, meu filho! Torci muito por você, JV. Pedi até pra Miriam acender uma vela lá na igreja, sabe? Nossa, hoje o café é por minha conta!";
                    break;

                case 6:
                    QuemFala = 2;
                    Dialogo.text = "Poxa, muito obrigado, Seu Ludovico, mas eu só vim contar pro senhor mesmo!";
                    break;

                case 7:
                    QuemFala = 2;
                    Dialogo.text = "Vou comemorar com a minha mãe! Imagina, o primeiro da família a fazer faculdade… Medicina ainda!";
                    break;

                case 8:
                    QuemFala = 1;
                    Dialogo.text = "Ah, mas vê se volta, viu? O café fica guardado aqui pro seu primeiro dia de aula.";
                    break;

                case 9:
                    QuemFala = 2;
                    Dialogo.text = "Hahaha. Eu volto sim, muito obrigado!! Até mais, Seu Ludovico!! Fica com Deus!!";
                    break;

                case 10:
                    QuemFala = 1;
                    Dialogo.text = "Magina, JV. Vai com Ele.";
                    break;


                case 11:
                    QuemFala = 1;
                    Dialogo.text = "Ludovico pensou em todas as coisas que passou com o bar. Pensou que tem dias que é muito difícil… Mas que na maioria deles, vale a pena.";
                    Escolha1.SetActive(true);
                    Escolha2.SetActive(true);
                    Escolha3.SetActive(true);
                    break;

            }
        }


        if (Cena == 16)
        {
            switch (QualFala)
            {
                case 0:
                    Dialogo.text = "...alguns meses depois...";
                    Escolha1.SetActive(true);
                    Escolha2.SetActive(true);
                    Escolha3.SetActive(true);
                    break;
            }
        }

        if (Cena == 17)
        {
            switch (QualFala)
            {
                case 0:
                    QuemFala = 1;
                    Dialogo.text = "Eu entenderia o lado dela, mas acredito que você tomará a melhor decisão.";
                    break;

                case 1:
                    QuemFala = 1;
                    Dialogo.text = "Obviamente ela ficaria chateada, mas faz parte. Nem sempre conseguimos fazer tudo que nossos pais querem. Meus pais queriam que eu fosse advogado… Hahahaha";
                    break;

                case 2:
                    QuemFala = 1;
                    Dialogo.text = "Hoje sou dono de bar… Loucura né?";
                    break;

                case 3:
                    QuemFala = 2;
                    Dialogo.text = "Eu queria ser o primeiro da família a ter faculdade…";
                    break;


                case 4:
                    QuemFala = 1;
                    Dialogo.text = "Nem sempre temos tudo aquilo que queremos, JV… ";
                    break;


                case 5:
                    QuemFala = 1;
                    Dialogo.text = "É um aprendizado que você deve levar pra vida.";
                    break;

                case 6:
                    QuemFala = 2;
                    Dialogo.text = "É… Tem razão… ";
                    break;

                case 7:
                    QuemFala = 2;
                    Dialogo.text = "Vou indo nessa, Seu Ludovico.";
                    break;

                case 8:
                    QuemFala = 1;
                    Dialogo.text = "Ta bom, filho. Vai com Deus.";
                    break;
               
                case 9:
                    QuemFala = 2;
                    Dialogo.text = "Fica com ele.";
                    Escolha1.SetActive(true);
                    Escolha2.SetActive(true);
                    Escolha3.SetActive(true);
                    break;

            }
        }


        if (Cena == 18)
        {
            switch (QualFala)
            {
                case 0:
                    Dialogo.text = "8h da manhã em ponto, Ludovico abre seu bar. O dia estava nublado, do jeito que ele gostava.";
                    break;

                case 1:
                    Dialogo.text = "Ele começou a fazer o café e a limpar o balcão.  Novamente ligou o rádio, até que em uma das notícias ouviu sobre a fuvest";
                    break;

                case 2:
                    Dialogo.text = "…";
                    break;

                case 3:
                    QuemFala = 1;
                    Dialogo.text = "Foi lembrar de JV, que Ludovico sentiu saudade. Lembrou dele pequeno entrando no bar com a sua mãe.";
                    break;


                case 4:
                    QuemFala = 1;
                    Dialogo.text = "Se perguntou qual decisão ele tinha tomado, mas no fundo ele sabia.";
                    break;


                case 5:
                    QuemFala = 1;
                    Dialogo.text = "Tem muita gente que desiste antes de tentar.";
                    break;


                case 6:
                    QuemFala = 1;
                    Dialogo.text = "Fica com Deus, filho.";
                    Escolha1.SetActive(true);
                    Escolha2.SetActive(true);
                    Escolha3.SetActive(true);
                    break;

            }
        }




        if (Cena == 19)
        {
            switch (QualFala)
            {
                case 0:
                    Dialogo.text = "FIM";
                    Escolha1.SetActive(true);
                    Escolha2.SetActive(true);
                    Escolha3.SetActive(true);
                    break;
            }
        }


        if (Cena == 20)
        {
            switch (QualFala)
            {
                case 0:
                    Dialogo.text = "Direção de Arte: Gabriella Santos";
                    
                    break;
                case 1:
                    Dialogo.text = "Programação: Gabriella Santos";
                    break;
                case 2:
                    Dialogo.text = "Roteiro/Narrativa: Gabriella Santos";
                    break;
                case 3:
                    Dialogo.text = "Animação: Gabriella Santos";
                    break;
                case 4:
                    Dialogo.text = "Áudio: Gabriella Santos";
                    break;
                case 5:
                    Dialogo.text = "Beta testers: Ítalo Loureiro, Renato Barreto, João Oliveira, Sarah Souza, Gustavo Pinheiro, Davi Seibert, Eduarda Corrêa e Max Latacz";
                    break;
                case 6:
                    Dialogo.text = "E muito obrigada! ";
                    break;
                case 7:
                    Dialogo.text = "Principalmente ao Ítalo, por todas as madrugadas testando comigo e por todos esses anos acreditando em mim.";
                    break;

                case 8:
                    Dialogo.text = "Por não ter desistido, até quando eu desisti.";
                    break;

                case 9:
                    Dialogo.text = "E obrigada a você que acompanhou eu, Jotavê e o Seu Ludovico.";
                    Escolha1.SetActive(true);
                    Escolha2.SetActive(true);
                    Escolha3.SetActive(true);
                    break;

            }
        }

        


    }


    public void trocaPersonagem()
    { 
        
    }
        
        
        }
   
