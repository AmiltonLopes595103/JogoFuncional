using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootLuck
{
    public class Partida
    {


        public  int DefinirJogadores(int opcao)
        {
            Player jogador1 = new Player();
            int[] jogadores2 = new int[2];
            int segundoJogador=0;
            String nome, nome2;
            int playerID = 0;
            jogadores2[0] = 1;//no primeiro indice[0] colocamos o id do primeiro jogador

            jogador1.setId(1);//Definindo o jogador1 e seu ID.



            if (opcao == 2)
            {
                Console.WriteLine("Informe o nome do segundo jogador: ");
                nome2 = Console.ReadLine();
                Player jogador2 = new Player();
                jogador2.setNome(nome2);
                jogador2.setId(2);
              //se o segundo jogador for escolhido o seu id oculpara o segundo indice [1]do vetor jogador2[]
                segundoJogador= jogador2.getID();

               


                //Console.WriteLine(player1.getNome() + " = 10 energias");
                Console.WriteLine(jogador2.getNome() + " = 10 energias");
            }
            else if (opcao == 3)
            {
                Console.WriteLine("Como deseja batizar a máquina?");
                String apelido = Console.ReadLine();
                Maquina maquina1 = new Maquina();
                maquina1.setNome(apelido);
                maquina1.setId(3);
               ;//senão se o jogador escolhido for a maquina o id da maquina oculpara o segundo indice[1] do vetor jogador2[]
                segundoJogador = maquina1.getId(); 
                



                // Console.WriteLine(nome + " = 10 energias");
                Console.WriteLine(maquina1.getNome() + " = 10 energias");
            }
            else if (opcao != 2 && opcao != 3)
            {
                do
                {
                    Console.WriteLine("Opção invalida! tente novamente: ");
                    opcao = int.Parse(Console.ReadLine());
                } while (opcao != 2 && opcao != 3);

            }

            return segundoJogador;//apos definir se o proximo jogador será uma pessoa ou a maquina retorne o id desse jogador.


        }

        public  void comecarRodada( int indiceSegundoJogador)
        {
            Player playerdaVEz = new Player();

            int jogadorDaVez;// a variavel jogadorDaVez recebe o ID do do proximo jogador a jogar caso esse id seja diferente do ID do ulrimo jogador que jogou.
            int ultimoJogador=0;
            int[] jogadores = new int[2];
            jogadores[0] = 1;
            jogadores[1] = indiceSegundoJogador;
            int contRodadas=0;
            int escolha=0;
            //Retornar o indice para o codigo principal ou retornar o
            //jogador pois vou precisar dele para começar a partida
            Random random1 = new Random();

            int randomIndex1 = random1.Next(jogadores.Length);//o random sempre pega um indice a menos do que o que foi declarado.
            // qual sera os ids 1 e 2 ou 1 e 3??

            //Console.WriteLine("O jogador : "+jogadores[randomIndex]+" irá começar o jogo.");
            Console.WriteLine("O jogador: "+jogadores[randomIndex1]+" irá começar o jodgo");
            jogadorDaVez = jogadores[randomIndex1];//decidindo que será o jogador da vez

           /* if ()
            {

            }

           

           if (contRodadas>1)//a partir da segunda rodada
            {
                for(int f = 0; f<2; f++){


                    if(jogadores[f] != ultimoJogador){ //vamos sortear quem será a vez de jogar 
                        jogadorDaVez = jogadores[f];

                       
                    }
                
            
                }

            }*/
            do
            {

                for (int f = 0; f < 2; f++)//a partir da segunda rodada
                {


                    if (jogadores[f] != ultimoJogador)
                    { //vamos sortear quem será a vez de jogar 
                        jogadorDaVez = jogadores[f];


                    }


                }

                Console.WriteLine();
                Console.WriteLine("Iniciar a partida(1) Finalizar o jogo(2)");
                Console.WriteLine("Escolha uma opção: ");
                escolha = int.Parse(Console.ReadLine());






                //return jogadores[randomIndex];//indice aleatorio dentro do vetor, quem vai comecar o jogo id 1, id 2 ou id 3?




                String[] valores = new String[3];
                int vezes = 0;

                int randomIndex = 0;
                int[] cont1 = new int[3];

                int[] referencia = new int[3];
                int contadorVezes = 0;
                int[] numeros1 = new int[3];

                int cont = 0;



                int[] quantidade = new int[3];
                int[] posicoes = new int[3];
                int[] resultado = new int[3];
                int valor, aux, k;
                int contVezes = 0;
                String[] cartas1 = new string[7];


                cartas1[0] = "Null";
                cartas1[1] = "Gol";
                cartas1[2] = "Penalti";
                cartas1[3] = "Falta";
                cartas1[4] = " Cartão_Amarelo";
                cartas1[5] = "Cartão_Vermelho";
                cartas1[6] = "Energia";
                int[] cartas2 = new int[7];


                //int[] cartas2 = { 0,1, 2, 3, 4, 5,6};
                cartas2[0] = 0;
                cartas2[1] = 1;
                cartas2[2] = 2;
                cartas2[3] = 3;
                cartas2[4] = 4;
                cartas2[5] = 5;
                cartas2[6] = 6;




                for (int i = 0; i < 3; i++)//preencher vetor 
                {



                    Random random = new Random();
                    randomIndex = random.Next(1, 7);//sorteador de indice de 1 a 6
                    Console.WriteLine(randomIndex);//Mostre os  indices sorteados 

                    switch (cartas2[randomIndex])// qual o numero saiu no indice sorteado?
                    {
                        case 1:
                            valores[i] = "Gol";
                            numeros1[i] = 1;
                            //[i] = 0;
                            break;
                        case 2:
                            valores[i] = "Penalti";
                            numeros1[i] = 2;
                            //cont1[i] = 1;
                            break;
                        case 3:
                            valores[i] = "Falta";
                            numeros1[i] = 3;

                            // cont1[i] = 2;
                            break;
                        case 4:
                            valores[i] = "Cartao_Amarelo";
                            numeros1[i] = 4;

                            cont1[i] = 3;
                            break;

                        case 5:
                            valores[i] = "Cartao_vermelho";
                            numeros1[i] = 5;
                            //cont1[i] = 4;
                            break;

                        case 6:
                            valores[i] = "Energia";
                            numeros1[i] = 6;
                            // cont1[i] = 5;
                            break;
                    }
                }




                Console.WriteLine();
                for (int t = 0; t < 3; t++)//mostrando os numeros do vetor
                {

                    Console.WriteLine("Valores: " + valores[t]);



                }

                Console.WriteLine();
                for (int w = 0; w < 3; w++)//mostrando os numeros do vetor
                {

                    Console.WriteLine("numeros1: " + numeros1[w]);



                }



                Console.WriteLine();
                for (int j = 0; j < 3; j++)//fazer as comparações
                {
                    k = 0;
                    Console.WriteLine("Indice J: " + j);



                    Console.WriteLine("Indice K: " + k);


                    if (numeros1[k] == numeros1[j])
                    {

                        resultado[k] = numeros1[j];


                        // posicoes[j] = j;
                        cont = cont + 1;//o numero foi encontrado pelo menos uma vez
                        quantidade[k] = cont;


                    }
                    else if (numeros1[j] != numeros1[j - 1])//se o numero atual em (j) for diferente do numero anterior em (j) então
                    {                                //resultado recebe esse vcalor como um valor diferente e contabiliza 1 para ele.

                        resultado[j] = numeros1[j];
                        cont = 1;//o numero foi encontrado pelo menos uma vez
                        quantidade[j] = cont;




                    }
                    else//senão se o numero atual em (j) for igual ao numero anterior em (j) então quantidade soma mais +1 para o mesmo valor
                    {


                        quantidade[j - 1] = cont + 1;
                    }




                    contVezes++;//quantas vezes  o indice (j) foi executado





                }






                Console.WriteLine("contVezes: " + contVezes);

                vezes += 1;




                Console.WriteLine();
                for (int i = 0; i < 3; i++)
                {

                    Console.WriteLine("resultado: " + resultado[i]);



                }




                for (int j = 0; j < 3; j++)
                {


                    Console.WriteLine("Qunatidade de vezes que o numero aparece: " + quantidade[j]);

                }


                for (int y = 0; y < 3; y++)
                {

                    switch (resultado[y])
                    {
                        case 1:
                            if (quantidade[y] == 1)
                            {
                                //Console.WriteLine("Gol");
                                Console.WriteLine("3 pontos: " + cartas1[1]);


                            }
                            else if (quantidade[y] == 2)
                            {
                                //Console.WriteLine("Gol");
                                Console.WriteLine("6 pontos: " + cartas1[1]);

                            }
                            else if (quantidade[y] == 3)
                            {
                                // Console.WriteLine("Gol");
                                Console.WriteLine("1 pontos: " + cartas1[1]);



                            }


                            break;
                        case 2:
                            if (quantidade[y] == 1)
                            {
                                //Console.WriteLine("Penalti");
                                Console.WriteLine("2 pontos: " + cartas1[2]);


                            }
                            else if (quantidade[y] == 2)
                            {
                                //Console.WriteLine("Penalti");
                                Console.WriteLine("4 pontos: " + cartas1[2]);

                            }
                            else if (quantidade[y] == 3)
                            {

                                Console.WriteLine(cartas1[2]);
                                Console.WriteLine("Direita (1), Esquerda(2), Centro(3)");
                                Console.WriteLine("Escolha uma opção: ");
                                int opcao = int.Parse(Console.ReadLine());




                            }
                            break;


                        case 3:
                            if (quantidade[y] == 1)
                            {
                                Console.WriteLine("1 ponto: " + cartas1[3]);


                            }
                            else if (quantidade[y] == 2)
                            {
                                Console.WriteLine("2 pontos: " + cartas1[3]);

                            }
                            else if (quantidade[y] == 3)
                            {
                                Console.WriteLine(cartas1[3]);
                                Console.WriteLine("Passa a vez! " + cartas1[3]);


                            }

                            break;

                        case 4:
                            if (quantidade[y] == 1)
                            {
                                Console.WriteLine("1 ponto: " + cartas1[4]);


                            }
                            else if (quantidade[y] == 2)
                            {
                                Console.WriteLine("2 pontos: " + cartas1[4]);

                            }
                            else if (quantidade[y] == 3)
                            {
                                Console.WriteLine(cartas1[4]);
                                Console.WriteLine("Perde uma energia, no próximo cartão amarelo perderá duas energias, e passa a vês para o adversário.");


                            }

                            break;
                        case 5:
                            if (quantidade[y] == 1)
                            {
                                Console.WriteLine("0 pontos: " + cartas1[5]);


                            }
                            else if (quantidade[y] == 2)
                            {
                                Console.WriteLine("0 pontos: " + cartas1[5]);

                            }
                            else if (quantidade[y] == 3)
                            {
                                Console.WriteLine(cartas1[5]);
                                Console.WriteLine("O usuário perde duas energias, e passa a vês para o adversário.");


                            }

                            break;

                        case 6:
                            if (quantidade[y] == 1)
                            {
                                Console.WriteLine("2 pontos: " + cartas1[6]);


                            }
                            else if (quantidade[y] == 2)
                            {
                                Console.WriteLine("4 pontos: " + cartas1[6]);

                            }
                            else if (quantidade[y] == 3)
                            {
                                Console.WriteLine(cartas1[6]);
                                Console.WriteLine("O jogador ganha mais uma energia para jogar, e passa a vês para o adversário. ");


                            }



                            break;
                            ultimoJogador = jogadorDaVez; // variavel ultimo jogafdor guarda oID de quem foi o ultomo jogador a jogar.








                    }
                }
                contRodadas++;
            } while (escolha != 2);




            
































        }


    }






}

















