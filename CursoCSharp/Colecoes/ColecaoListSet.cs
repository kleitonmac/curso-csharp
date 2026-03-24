using CursoCSharp.ClassesEMetodos; // Importa namespace com classe Produto
using System;
using System.Collections.Generic;   // Necessário para HashSet<T>

namespace CursoCSharp.Colecoes
{
    class ColecaoListSet
    {
        public static void Executar()
        {
            // Cria um produto específico
            var livro = new Produto("A maldição do Tigre", 70.9);

            // HashSet<Produto> = coleção que NÃO permite DUPLICATAS
            // Útil para carrinhos onde não queremos itens repetidos
            var carrinho = new HashSet<Produto>();
            carrinho.Add(livro);  // Adiciona 1º item ✓

            // HashSet com inicialização - cria 3 produtos diferentes
            var combo = new HashSet<Produto>()
            {
                new Produto("Camisa", 99.0),      // Produto 1
                new Produto("Bermuda", 79.9),     // Produto 2  
                new Produto("Marca Texto", 88.9), // Produto 3
            };

            // UnionWith() = JUNTAR dois HashSets (sem duplicatas)
            // Carrinho agora tem: livro + camisa + bermuda + marca texto = 4 itens
            carrinho.UnionWith(combo);
            Console.WriteLine(carrinho.Count); // Saída: 4

            // Percorre e mostra todos os produtos
            foreach (var item in carrinho)
            {
                Console.WriteLine($"{item.Nome} {item.Preco}");
            }

            Console.WriteLine(carrinho.Count); // Ainda 4

            // TENTATIVA de adicionar o MESMO livro novamente
            // HashSet REJEITA duplicatas automaticamente!
            carrinho.Add(livro);
            Console.WriteLine(carrinho.Count); // Saída: 4 (não virou 5!)
        }
    }
}
