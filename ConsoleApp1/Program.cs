using System;
using System.Collections;
using FootLuck;


namespace Program
{
    class Aplication
    {

        public static void Main(String[] args)
        {
            Partida partida = new Partida();
            List<Object> jogadores1 = new List<Object>();
            Player player1 = new Player();
            int playerID;
            //Player player2 = new Player();
            //Player maquina1 = new Player();
            int opcao, escolha, cont = 0;
            String nome, nome2;





            Console.WriteLine("-------FootLuck-------");
            Console.WriteLine("Qualquer tecla para startar");
            Console.Clear();
            Console.WriteLine("-------FootLuck-------");
            Console.WriteLine("Infome o nome do primeiro jogador: ");
            nome = Console.ReadLine();
            player1.setNome(nome);
            player1.setId(1);
            




            Console.Clear();

            Console.WriteLine("-------FootLuck-------");
            Console.WriteLine("-------Escolha uma opção-------");
            Console.WriteLine("Jogador 2 precione (2)");
            Console.WriteLine("Jogar contra a maquina precione (3)");



            opcao = int.Parse(Console.ReadLine());
            playerID = partida.DefinirJogadores(opcao);
            partida.comecarRodada(playerID);
            

            //Console.WriteLine("O jogador: " + playerID + " irá começar o jogo");
            
           











            /*if (opcao == 2)
            {
                Console.WriteLine("Informe o nome do segundo jogador: ");
                 nome2= Console.ReadLine();
                 Player jogador2 = new Player();
                 jogador2.setNome(nome2);
                jogadores1[1] = jogador2;
                //ComecarJogo(player1, player2);




                Console.WriteLine(player1.getNome()+ " = 10 energias");
                Console.WriteLine(jogador2.getNome() + " = 10 energias");
            }
            else if (opcao == 0)
            {
                Console.WriteLine("Como deseja batizar a máquina?");
                String apelido = Console.ReadLine();
                Maquina maquina1 = new Maquina();
                maquina1.setNome(apelido);
                jogadores1[1] = maquina1;
            //ComecarJogo(player1,maquina1);




            Console.WriteLine(nome + " = 10 energias");
                Console.WriteLine(maquina1.getNome() + " = 10 energias");
            }
            else if (opcao != 2 && opcao != 0)
            {
            do { 
            Console.WriteLine("Opção invalida! tente novamente: ");
                opcao = int.Parse(Console.ReadLine());
            } while (opcao != 2 && opcao != 0);

            }

            if (cont==0)
               {
                   //ComecarJogo(player1, player2, maquina1);

               }

               Console.WriteLine("Pressione (Play) para inciar a partida ou (1) para finalizar o jogo");
               escolha = int.Parse(Console.ReadLine());*/

            //Console.WriteLine(ComecarJogo(player1, player2, maquina1));
            // Console.WriteLine(ComecarJogo(player1, player2));






            /* while (opcao == 1 || opcao == 2)
             {

             }*/


        }

        private static void Opcao(String nome, int opcao)
        {
            Player player1 = new Player();
            player1.setNome(nome);



            if (opcao == 2)
            {

                Console.WriteLine("Informe o nome do segundo jogador: ");
                String nome2 = Console.ReadLine();


                Console.WriteLine(player1.getNome() + " = 10 energias");
                Console.WriteLine(nome2 + " = 10 energias");

            }
            else if (opcao == 0)
            {
                Console.WriteLine("Como deseja batizar a máquina?");
                String maquina = Console.ReadLine();
                Console.WriteLine(player1.getNome() + " = 10 energias");
                Console.WriteLine(maquina + " = 10 energias");
            }

        }



       






    }
}