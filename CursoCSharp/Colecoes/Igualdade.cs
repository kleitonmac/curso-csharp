using System;
using System.Collections.Generic;  // Não usado aqui, mas ok manter
using System.Text;                 // Não usado aqui, mas ok manter

namespace CursoCSharp.Colecoes
{
    class Igualdade
    {
        public static void Executar()
        {
            // 1️⃣ CRIA 2 OBJETOS DIFERENTES na MEMÓRIA
            var p1 = new Produto("Caneta", 1.89);  // ← OBJETO #1 (endereço A)
            var p2 = new Produto("Caneta", 1.89);  // ← OBJETO #2 (endereço B)
            var p3 = p2;                           // ← REFERÊNCIA (mesmo endereço B)

            // 2️⃣ p1 == p2 → FALSO (referências diferentes!)
            // == COMPARA REFERÊNCIAS (endereços na memória), NÃO CONTEÚDO
            Console.WriteLine(p1 == p2);  // SAÍDA: False

            // 3️⃣ p3 == p2 → VERDADEIRO (MESMA REFERÊNCIA!)
            // p3 APONTA para o MESMO objeto que p2 (endereço B)
            Console.WriteLine(p3 == p2);  // SAÍDA: True

            // 4️⃣ MESMA COISA DE NOVO
            Console.WriteLine(p3 == p2);  // SAÍDA: True
        }
    }
}
