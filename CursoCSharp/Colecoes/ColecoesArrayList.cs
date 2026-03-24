using System;
using System.Collections;  // Namespace necessário para ArrayList (coleções não-genéricas)

// arraylist nao utilizar collection generic - Correto! ArrayList é antigo, prefira List<T> em projetos novos
namespace CursoCSharp.Colecoes
{
    class ColecoesArrayList
    {
        public static void Executar()
        {
            // Cria uma instância de ArrayList - coleção dinâmica que aceita QUALQUER tipo de dado
            // Diferente de array comum, cresce automaticamente quando adiciona itens
            var arraylist = new ArrayList{
                "Palavra",    // string (texto)
                3,           // int (número inteiro)
                true,        // bool (verdadeiro/falso)
            };

            // Adiciona mais um elemento (double) - ArrayList aceita qualquer tipo sem erro de compilação
            arraylist.Add(3.14);

            // Percorre todos os itens usando foreach - simples e eficiente
            // Nota: 'item' é do tipo 'object' (tipo base de tudo em C#)
            foreach (var item in arraylist)
            {
                // Mostra o valor E o tipo real de cada item usando GetType()
                // Útil para entender que ArrayList armazena tudo como 'object'
                Console.WriteLine("{0} => {1}", item, item.GetType());
            }
        }
    }
}
