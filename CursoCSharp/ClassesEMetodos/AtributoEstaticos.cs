using System;

namespace CursoCSharp.ClassesEMetodos
{
    public class Produto
    {
        public string Nome;
        public double Preco;
        public double Desconto = 0.1;

        // Construtor com parâmetros
        public Produto(string nome, double preco, double desconto)
        {
            Nome = nome;
            Preco = preco;
            Desconto = desconto;
        }

        // Construtor vazio com valores padrão
        public Produto()
        {
            Nome = "Sem nome";
            Preco = 0.0;
            Desconto = 0.1;
        }

        public double CalcularDesconto()
        {
            return Preco - (Preco * Desconto);
        }
    }

    class AtributoEstaticos
    {
        public static void Executar()
        {
            var produto1 = new Produto("Caneta", 7.99, 0.1);

            var produto2 = new Produto()
            {
                Nome = "Borracha",
                Preco = 3.45,
                Desconto = 0.1
            };

            Console.WriteLine("Preço com desconto {0}", produto1.CalcularDesconto());
            Console.WriteLine("Preço com desconto {0}", produto2.CalcularDesconto());
        }
    }
}