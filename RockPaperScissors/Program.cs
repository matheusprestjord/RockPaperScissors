using System;

namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            // "desenhando" a "logo"
            Console.WriteLine("-------------------------");
            Console.WriteLine("ROCK, PAPER AND SCISSORS!");
            Console.WriteLine("-------------------------\n");

            // decidindo se o jogador quer jogar
            bool play = true;
            string answer = "";
            while (answer != "y" || answer != "n")
            {
                Console.Write("Do you want to play \"rock, paper and scissors\"? (y/n) ");
                answer = Console.ReadLine();
                if (answer == "y")
                {
                    play = true;
                    Console.WriteLine();
                    break;
                }
                else if (answer == "n")
                {
                    play = false;
                    break;
                }
                else
                {
                    Console.WriteLine("\nThis isn't an option!\n");
                    continue;
                }
            }

            // criando uma variável para saber se o jogador quer jogar de novo
            bool playAgain = false;

            // criando um loop para o jogador jogar enquanto recusar parar
            if (play)
            {
                do
                {
                    // criando as variáveis do jogador e do computador
                    string computer = "";
                    string player = "";

                    // criando um número aleatório que vai escolher o que o computador vai jogar
                    Random random = new Random();
                    int computerChoice = random.Next(3);
                    switch (computerChoice)
                    {
                        case 0:
                            computer = "rock";
                            break;
                        case 1:
                            computer = "paper";
                            break;
                        case 2:
                            computer = "scissors";
                            break;
                    }

                    // obrigando o jogador a escolher uma resposta válida através de um loop
                    while (player != "rock" && player != "paper" && player != "scissors")
                    {
                        // armazenando o que o jogador vai jogar
                        Console.Write("Choose between rock, paper and scissors: ");
                        player = Console.ReadLine().ToLower();

                        // descobrindo se o que o jogador respondeu é uma das opções
                        if (player != "rock" && player != "paper" && player != "scissors")
                        {
                            Console.WriteLine("\nThis isn't an option!");
                        }
                        Console.WriteLine();
                    }

                    // mostrando as escolhas de ambos
                    Console.WriteLine("You choose " + player);
                    Console.WriteLine("The computer chooses " + computer);

                    // decidindo o vencedor
                    switch (player)
                    {
                        case "rock":
                            switch (computer)
                            {
                                case "rock":
                                    Console.WriteLine("\nIt's a draw!");
                                    break;
                                case "paper":
                                    Console.WriteLine("\nYou lose!");
                                    break;
                                case "scissors":
                                    Console.WriteLine("\nYou win!");
                                    break;
                            }
                            break;
                        case "paper":
                            switch (computer)
                            {
                                case "rock":
                                    Console.WriteLine("\nYou win!");
                                    break;
                                case "paper":
                                    Console.WriteLine("\nIt's a draw!");
                                    break;
                                case "scissors":
                                    Console.WriteLine("\nYou lose!");
                                    break;
                            }
                            break;
                        case "scissors":
                            switch (computer)
                            {
                                case "rock":
                                    Console.WriteLine("\nYou lose!");
                                    break;
                                case "paper":
                                    Console.WriteLine("\nYou win!");
                                    break;
                                case "scissors":
                                    Console.WriteLine("\nIt's a draw!");
                                    break;
                            }
                            break;
                    }

                    // decidindo se o jogador vai jogar de novo
                    string answer2 = "";
                    // mantendo ele em um loop até ele responder com uma opção válida
                    while (answer2 != "y" || answer2 != "n")
                    {
                        Console.Write("\nDo you want to play again? (y/n) ");
                        answer2 = Console.ReadLine();
                        if (answer2 == "y")
                        {
                            playAgain = true;
                            Console.WriteLine();
                            break;
                        }
                        else if (answer2 == "n")
                        {
                            playAgain = false;
                            break;
                        }
                        else
                        {
                            Console.WriteLine("\nThis isn't an option!");
                            continue;
                        }
                    }
                } while (playAgain);
            }

            Console.WriteLine("\nThanks for playing!");

            Console.ReadKey();
        }
    }
}