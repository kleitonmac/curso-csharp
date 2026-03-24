using System;
using System.Threading.Channels;

namespace CursoCsharp.Fundamentos
{
    public class PrimeiroPrograma
    {
        public static void Executar()
        {

           

            // Lê o nome
            Console.Write("Digite seu nome: ");
            string nome = Console.ReadLine();

            // Lê a idade (converte string para int)
            Console.Write("Digite sua idade: ");
            string idadeTexto = Console.ReadLine();
            int idade = int.Parse(idadeTexto);

            // Lê a profissão
            Console.Write("Digite sua profissão: ");
            string job = Console.ReadLine();

            // Mostra tudo junto com interpolação
            Console.WriteLine($"Meu nome é {nome}, eu tenho {idade} anos, sou {job}");

            // Switch case exemplo
            string linguagem = "JavaScript";

            switch (linguagem)
            {
                case "C#":
                    Console.WriteLine("Linguagem de programação");
                    break;
                case "Java":
                    Console.WriteLine("Linguagem de programação");
                    break;
                case "Python":
                    Console.WriteLine("É linguagem de programação");
                    break;
                case "JavaScript":
                    Console.WriteLine("Linguagem de programação");
                    break;
                default:
                    Console.WriteLine("Não é linguagem");
                    break;

                    


            }

            // Saída adicional
            Console.WriteLine("Primeiro Programa");
            Console.WriteLine("Primeira linha");
            Console.WriteLine("Segunda linha");
            Console.WriteLine("Terceira linha");
            Console.WriteLine("Quarta linha");
            Console.WriteLine("Terminou");

            // Mantém o console aberto
            Console.WriteLine("Pressione ENTER para sair...");
            Console.ReadLine();

            
        }
    }
}