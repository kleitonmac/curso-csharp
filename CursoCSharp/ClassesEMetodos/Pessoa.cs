using System;

namespace CursoCSharp.ClassesEMetodos
{
    class Pessoa
    {
        // Atributos da classe
        public string Nome;
        public string Sobrenome;
        public int Idade;
        public string Endereco;

        // Método que retorna uma string formatada
        public string Apresentar()
        {
            return $"Olá! Me chamo {Nome} {Sobrenome}, tenho {Idade} anos e meu endereço é {Endereco}";
        }

        // Método que imprime no console
        public void ApresentarNoConsole()
        {
            Console.WriteLine(Apresentar());
        }
    }

    class TestePessoa
    {
        public static void Executar()
        {
            // Criando um objeto Pessoa e preenchendo os atributos
            var pessoa1 = new Pessoa();
            pessoa1.Nome = "Kleiton";
            pessoa1.Sobrenome = "Macedo";
            pessoa1.Idade = 30;
            pessoa1.Endereco = "Rua das Flores, 123";

            // Chamando o método que imprime no console
            pessoa1.ApresentarNoConsole();

            // Mantém o console aberto
            Console.WriteLine("Pressione ENTER para sair...");
            Console.ReadLine();
        }
    }
}