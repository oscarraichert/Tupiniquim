using System;

namespace Tupiniquim.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Tamanho X da área: ");
            int gridX = Convert.ToInt32(Console.ReadLine());

            Console.Write("Tamanho Y da área: ");
            int gridY = Convert.ToInt32(Console.ReadLine());

            Console.Write("Posição inicial X: ");
            int posiX = Convert.ToInt32(Console.ReadLine());

            Console.Write("Posição inicial Y: ");
            int posiY = Convert.ToInt32(Console.ReadLine());

            Console.Write("Sentido inicial: ");
            char sentido = Convert.ToChar(Console.ReadLine().ToUpper());

            Console.Write("Comando de movimento: ");
            string comandos = Console.ReadLine().ToUpper();

            foreach (char comando in comandos)
            {
                if (comando == 'M')
                {
                    if (sentido == 'N')
                    {
                        posiY++;
                    }
                    else if (sentido == 'S')
                    {
                        posiY--;
                    }
                    else if (sentido == 'O')
                    {
                        posiX--;
                    }
                    else if (sentido == 'L')
                    {
                        posiX++;
                    }
                }

                if (comando == 'E')
                {
                    if (sentido == 'N')
                    {
                        sentido = 'O';
                    }
                    else if (sentido == 'O')
                    {
                        sentido = 'S';
                    }
                    else if (sentido == 'S')
                    {
                        sentido = 'L';
                    }
                    else if (sentido == 'L')
                    {
                        sentido = 'N';
                    }
                }

                if (comando == 'D')
                {
                    if (sentido == 'N')
                    {
                        sentido = 'L';
                    }
                    else if (sentido == 'L')
                    {
                        sentido = 'S';
                    }
                    else if (sentido == 'S')
                    {
                        sentido = 'O';
                    }
                    else if (sentido == 'O')
                    {
                        sentido = 'N';
                    }
                }


            }

            if (posiX > gridX || posiY > gridY)
            {
                Console.WriteLine("O robô saiu da área.");
            }
            else
            {
                Console.Write($"{posiX}, {posiY}, {sentido}");
            }
        }
    }
}
