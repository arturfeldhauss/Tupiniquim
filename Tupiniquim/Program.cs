using System;

namespace Tupiniquim
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
             
            
            Console.WriteLine("Bem vindo a nave espacial Tupiniquim!!!");
            Console.WriteLine("Digite a coordenada da area!!");
            string[] coordenada = Console.ReadLine().Split(' ');
            int[] coordenadas = new int[2];
            coordenadas[0] = Convert.ToInt32(coordenada[0]);
            coordenadas[1] = Convert.ToInt32(coordenada[1]);
            
            Console.WriteLine("Digite a coordenada e a direção que o robo ira iniciar!!");
            string[] inicio = Console.ReadLine().Split(' ');
            int[] inicioA = new int[2];
            inicioA[0]= Convert.ToInt32(inicio[0]);
            inicioA[1] = Convert.ToInt32(inicio[1]);
            char direcao = Convert.ToChar(inicio[2]);
            Console.WriteLine("================================");
            Console.WriteLine("Digite o comando para movimentar o robo!");
            string COMANDO = Console.ReadLine();
            char[] COMANDOA = COMANDO.ToCharArray();

            for (int i = 0; i < COMANDOA.Length; i++)
            {
                if (COMANDOA[ i ] == 'E') 
                {
                    if (direcao == 'N')
                    {
                        direcao = 'O';
                    }
                    else if (direcao == 'O')
                    {
                        direcao = 'S';
                    }
                    else if (direcao == 'S') 
                    {
                        direcao = 'L'; 
                    }
                    else if(direcao == 'L')
                    {
                        direcao = 'N';
                    }
                }
                if (COMANDOA[i] == 'D') 
                {
                    if (direcao == 'N') 
                    {
                        direcao = 'L';
                    }
                    else if (direcao == 'L') 
                    {
                        direcao = 'S';
                    }
                    else if(direcao == 'S')
                    {
                        direcao = 'O';
                    }
                    else if (direcao == 'O')
                    {
                        direcao = 'N';
                    }
                }
                if (COMANDOA[i] == 'M')
                {
                    if (direcao == 'N')
                    {
                        inicioA[1] = inicioA[1] + 1;
                    }
                    else if (direcao == 'S')
                    {
                        inicioA[1] = inicioA[1] - 1;
                    }
                    else if (direcao == 'O')
                    {
                        inicioA[0] = inicioA[0] - 1;
                    }
                    else if (direcao == 'L') 
                    {
                        inicioA[0] = inicioA[0] + 1;
                    }      
                }
               
            }
            Console.WriteLine("O robo terminou nas coordenadas {0};{1}", inicioA[1], inicioA[0]);           
            Console.ReadLine();
            Console.WriteLine("Agora vamos passar as instruções pro segundo robo!!!!");
            Console.WriteLine("Digite as coordenadas da area!!!");
            string[] coordenadaB = Console.ReadLine().Split(' ');
            int[] coordenadasBC = new int[2];
            coordenadasBC[0] = Convert.ToInt32(coordenadaB[0]);
            coordenadasBC[1] = Convert.ToInt32(coordenadaB[1]);
            Console.WriteLine("Digite a coordenada e a direção que o robo 2 ira iniciar!!");
            string[] inicio2 = Console.ReadLine().Split(' ');
            int[] inicioA2 = new int[2];
            inicioA2[0] = Convert.ToInt32(inicio2[0]);
            inicioA2[1] = Convert.ToInt32(inicio2[1]);
            char direcao2 = Convert.ToChar(inicio2[2]);
            Console.WriteLine("================================");
            Console.WriteLine("Digite o comando para movimentar o robo!");
            string COMANDO2 = Console.ReadLine();
            char[] COMANDOA2 = COMANDO.ToCharArray();

            for (int i = 0; i < COMANDOA2.Length; i++)
            {
                if (COMANDOA2[i] == 'E')
                {
                    if (direcao2 == 'N')
                    {
                        direcao2 = 'O';
                    }
                    else if (direcao2 == 'O')
                    {
                        direcao2 = 'S';
                    }
                    else if (direcao2 == 'S')
                    {
                        direcao2 = 'L';
                    }
                    else if (direcao2 == 'L')
                    {
                        direcao2 = 'N';
                    }
                }
                if (COMANDOA2[i] == 'D')
                {
                    if (direcao2 == 'N')
                    {
                        direcao2 = 'L';
                    }
                    else if (direcao2 == 'L')
                    {
                        direcao2 = 'S';
                    }
                    else if (direcao2 == 'S')
                    {
                        direcao2 = 'O';
                    }
                    else if (direcao2 == 'O')
                    {
                        direcao2 = 'N';
                    }
                }
                if (COMANDOA2[i] == 'M')
                {
                    if (direcao2 == 'N')
                    {
                        inicioA2[1] = inicioA2[1] + 1;
                    }
                    else if (direcao2 == 'S')
                    {
                        inicioA2[1] = inicioA2[1] - 1;
                    }
                    else if (direcao2 == 'O')
                    {
                        inicioA2[0] = inicioA2[0] - 1;
                    }
                    else if (direcao2 == 'L')
                    {
                        inicioA2[0] = inicioA2[0] + 1;
                    }
                }

            }
            Console.WriteLine("O robo 1 terminou nas coordenadas {0};{1} e o segundo robo terminou nas coordenadas {2};{3}", inicioA[1], inicioA[0], inicioA2[1], inicio2[0] );
            Console.ReadLine();










            Console.ReadKey();
        }
    }
}
