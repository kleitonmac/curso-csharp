using System;                                   // Importa a biblioteca básica do C# (Console, DateTime, etc)
using System.Collections.Generic;              // Importa suporte a List, Dictionary e outras coleções dinâmicas
using System.Text;                             // Importa StringBuilder e métodos de manipulação de texto

namespace CursoCSharp.ClassesEMetodos         // Define o "espaço de nomes" organizacional do projeto
{
    public class Cliente
    {                      // Cria a classe "molde" para objetos Cliente
        public string Nome;                    // Campo público que armazena o nome (pode ser lido e alterado de qualquer lugar)
        readonly DateTime Nascimento;          // Campo IMUTÁVEL: só recebe valor no construtor, depois trava para sempre

        public Cliente(string nome, DateTime nascimento)
        {  // CONSTRUTOR: método especial chamado AUTOMATICAMENTE ao criar objeto
            Nome = nome;                       // Copia o parâmetro "nome" para o campo "Nome" da classe
            Nascimento = nascimento;           // Copia a data para o campo readonly (ÚLTIMA chance de definir esse valor!)
        }

        public string GetDataDeNascimento()
        {   // MÉTODO: função que "expõe" a data de forma formatada
            return String.Format("{0}/{1}/{2}", Nascimento.Day, Nascimento.Month, Nascimento.Year);  // Monta string no formato dia/mês/ano
        }                                      // Exemplo: "11/1/1993"
    }

    class Readonly
    {                            // Classe de exemplo para TESTAR a classe Cliente

        public static void Executar()
        {         // MÉTODO ESTÁTICO: roda SEM precisar criar objeto da classe Readonly
            var novoCliente = new Cliente("Alana Arze", new DateTime(1993, 1, 11));  // CRIA OBJETO: chama construtor com nome e data
            Console.WriteLine(novoCliente.Nome);  // IMPRIME: acessa campo público e mostra no console
            Console.WriteLine(novoCliente.GetDataDeNascimento());  // IMPRIME: chama método e mostra data formatada
        }                                      // Resultado: "Alana Arze" e "11/1/1993"
    }
}                                              // Fecha namespace
