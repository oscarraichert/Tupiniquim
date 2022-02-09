using System;

namespace Tupiniquim.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            do
            {
                for (int i = 1; i < 10; i++)
                {
                    Console.WriteLine($"Missão do Robô {i}: ");

                    Console.Write("\nTamanho X da área: ");
                    int gridX = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Tamanho Y da área: ");
                    int gridY = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Posição inicial X: ");
                    int posiX = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Posição inicial Y: ");
                    int posiY = Convert.ToInt32(Console.ReadLine());

                    if (posiX > gridX || posiY > gridY)
                    {
                        Console.WriteLine("\nO robô não pode ser colocado fora da área. Tente novamente.");
                        Console.WriteLine();
                        i--;
                        continue;
                    }

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

                    if (posiX > gridX || posiY > gridY || posiX < 0 || posiY < 0)
                    {
                        Console.WriteLine($"\nVocê perdeu o Robô {i}. Tente novamente.");
                    }
                    
                    else
                    {
                        Console.Write($"\nDestino final do Robô {i}: {posiX}, {posiY}, {sentido}");
                        Console.WriteLine();
                    }

                    Console.Write("\nDigite 'iniciar' para uma nova missão ou 'sair' para encerrar as missões: ");
                    string status = Console.ReadLine().ToLower();
                    Console.WriteLine();

                    if (status == "iniciar")
                    {
                        continue;
                    }

                    else if (status == "sair")
                    {
                        return;
                    }
                }

            } while (true);

        }
    }
}
