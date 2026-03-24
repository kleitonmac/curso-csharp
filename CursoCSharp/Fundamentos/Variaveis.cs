using System;

namespace CursoCsharp.Fundamentos 
{
    public class Variaveis
    {
        public static void Executar()
        {

            
            double.TryParse(Console.ReadLine(), out double nota);
            double notaDeCorte = 7.0;

            // Variáveis são usadas para armazenar dados na memória do computador.
            // Elas possuem um tipo que define o tipo de dado que podem armazenar.
            // int inteiro = 10; // Variável do tipo inteiro
            // double real = 3.14; // Variável do tipo double (número com casas decimais)
            // string texto = "Olá, Mundo!"; // Variável do tipo string (texto)
            // char letra = 'A'; // Variável do tipo char (caractere)
            // bool verdadeiro = true; // Variável do tipo bool (verdadeiro ou falso

            /// constantes e uma variável imutável, ou seja, seu valor não pode ser alterado após a atribuição inicial.

            string nome = "Carlos";
            int idade = 50;
            string profissao = "engenheiro";
            bool ativo = true;

            
            Console.WriteLine($"Meu nome é {nome} tenho {idade} anos minha profissão é {profissao} e estou ativo? {ativo}");

            // operadores ternarios
            Console.WriteLine("Nota e valida? {0}", nota > 10.0); // relambrando sinais relacinais
            Console.WriteLine("Nota invalida? {0}", nota < 0.0);
            Console.WriteLine("Perfeito? {0}", nota == 10.0);
            Console.WriteLine("Tem como Melhorar?{0}", nota != 10.0);
            Console.WriteLine("Passou por media", nota >= notaDeCorte);
            Console.WriteLine("Recuperação", nota < notaDeCorte);
            Console.WriteLine("Reprovou", nota <= 5.0);


        }

    }
}
