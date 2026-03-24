using CursoCSharp.ClassesEMetodos; // ⚠️ DESNECESSÁRIO: Produto está nesta mesma classe!
using System;
using System.Collections.Generic;   // ✅ NECESSÁRIO: para usar List<T>

namespace CursoCSharp.Colecoes
{
    // CLASSE PRODUTO DEFINIDA AQUI (redefinindo se já existir em outro lugar)
    public class Produto
    {
        // 📚 PROPRIEDADES AUTO-IMPLEMENTADAS (C# 3.0+)
        // O compilador cria automaticamente o campo privado (_nome, _preco)
        public string Nome { get; set; }
        public double Preco { get; set; }

        // 🔨 CONSTRUTOR: inicializa o objeto com valores
        public Produto(string nome, double preco)
        {
            Nome = nome;    // Atribui parâmetro à propriedade
            Preco = preco;  // Atribui parâmetro à propriedade
        }

        // ⚠️ SOBREESCREVE Equals(): define quando 2 objetos são "iguais"
        // IMPORTANTE para List.IndexOf(), HashSet, etc.
        public override bool Equals(object? obj)
        {
            // 🔴 PROBLEMA: Cast direto pode dar NullReferenceException!
            // SE obj não for Produto, crash no runtime
            Produto outroProduto = (Produto)obj;

            // Compara nome E preço (critério de igualdade personalizado)
            bool mesmoNome = Nome == outroProduto.Nome;
            bool mesmoPreco = Preco == outroProduto.Preco;

            // Retorna true só se AMBOS forem iguais
            return mesmoNome && mesmoPreco;
        }

        // ⚠️ SOBREESCREVE GetHashCode(): gera número único para o objeto
        // CRÍTICO para HashSet/Dictionary! Define "buckets" na memória
        public override int GetHashCode()
        {
            // 🔴 PROBLEMA: Nome.Length é MUITO simples!
            // "Ana" (3) e "Bob" (3) têm mesmo hash → colisão ruim
            return Nome.Length;
        }

        // ✅ VERSÃO CORRETA do GetHashCode() (adicione isso):
        /*
        public override int GetHashCode()
        {
            return HashCode.Combine(Nome, Preco); // C# 7.3+ PERFEITO!
            // OU manual:
            // return Nome.GetHashCode() ^ Preco.GetHashCode();
        }
        
        // ✅ VERSÃO SEGURA do Equals() (substitua):
        public override bool Equals(object? obj)
        {
            if (obj is Produto p)  // Verifica tipo E faz cast seguro
                return Nome == p.Nome && Preco == p.Preco;
            return false;
        }
        */
    }

    // 🛒 CLASSE PRINCIPAL: demonstra List<Produto>
    class ColecaoList
    {
        public static void Executar()
        {
            // 1️⃣ CRIA 1º PRODUTO
            var livro = new Produto("A maldição do Tigre", 70.9);

            // 2️⃣ LISTA DINÂMICA (diferente de array fixo)
            var carrinho = new List<Produto>();
            carrinho.Add(livro);  // carrinho: [livro] ← 1 item

            // 3️⃣ LISTA COM INICIALIZAÇÃO (collection initializer)
            var combo = new List<Produto>()
            {
                new Produto("Camisa", 99.0),           // índice 0
                new Produto("Bermuda", 79.9),          // índice 1
                new Produto("Marca Texto", 88.9),      // índice 2
            };

            // 4️⃣ ADICIONA combo INTEIRO no FINAL da lista
            carrinho.AddRange(combo);
            // carrinho agora: [livro, camisa, bermuda, marca-texto] ← 4 itens
            Console.WriteLine(carrinho.Count);  // SAÍDA: 4

            // 5️⃣ REMOVE pelo ÍNDICE (posição 3 = "Marca Texto")
            carrinho.RemoveAt(3);
            // carrinho agora: [livro, camisa, bermuda] ← 3 itens

            // 6️⃣ PERCORRE E MOSTRA ÍNDICE + PRODUTO
            foreach (var item in carrinho)
            {
                // IndexOf() usa Equals() que você sobrescreveu!
                // Procura "item" na lista e retorna posição (0, 1, 2...)
                Console.Write(carrinho.IndexOf(item));
                Console.WriteLine($"{item.Nome} {item.Preco}");
            }
        }
    }
}
