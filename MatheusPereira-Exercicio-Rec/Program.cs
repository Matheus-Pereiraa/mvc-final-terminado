using System;
using System.Collections.Generic;

namespace Nova_Pasta
{
    class Program
    {
        static List<string> ListaNomes = new List<string>();
        private static string Pessoa;

         static string Escolha;
        static void Main(string[] args)
        {

            do
            {
                Console.WriteLine($@" 
                
            
             Escolha entre uma das opcões 
             1 - Cadastrar Participante || 2 - Listar mais um Nome  ||  3 - Cancelar");
        

                Escolha = (Console.ReadLine());

                switch (Escolha)
                {
                    case "1":

                        Console.WriteLine("Escreva seu nome!!!");
                        string Nome = Console.ReadLine();

                        Console.WriteLine("Digite sua idade!!!");
                        int IdadePessoa = int.Parse(Console.ReadLine());

                        if (IdadePessoa >= 16)
                        {
                            CadastraNome(Nome);

                        }
                        else
                        {
                            Console.WriteLine($"Você está acompanhado dos seus pais ou responsáveis?");
                            string Acompanhado = Console.ReadLine().ToLower();
                            if (Acompanhado == "sim")
                            {
                                CadastraNome(Nome);
                            }
                            else if (Acompanhado == "não" && IdadePessoa < 15)
                            {
                                Console.WriteLine($"Você não pode vim para nosso Rockin SENAI, venha com seu responsável, ou até você ter 16 :(");

                            }
                            
                        }

                        break;
                    case "2":
                        MonstrarNome();
                        break;
                    case "3":
                        Console.WriteLine("Cancelando...");
                        break;
                    default:
                        Console.WriteLine($"Opção invalida, digite uma das opções acima!");

                        break;
                }

            } while (Escolha != "3");
        }

        static void MonstrarNome()
        {

            foreach (var CadaItem in ListaNomes)
            {
                Console.WriteLine($"Nome: {CadaItem}");
            }
        }

        static void CadastraNome(string Nome)
        {

            Console.WriteLine($"Você poderá vir até a nossa festa :)");
            ListaNomes.Add(Nome);
        }
    }
}