using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturasDeControle
{
    public class EstruturaForEach
    {
        /// <summary>
        /// 🔄 FOREACH: "Para CADA item em coleção" - Mais simples e seguro!
        /// QUANDO USAR: Percorrer arrays, listas, strings SEM precisar de índices
        /// VANTAGEM: Não dá erro de índice, código mais limpo
        /// </summary>
        public static void Executar() // metodo vazio que realizar a funcao
        {
            var palavra = "Opa!";  // String = coleção de caracteres

            // 🚀 FOREACH em ação: foreach(ITEM in COLEÇÃO)
            // Pega CADA letra da palavra, uma por vez
            foreach (var letra in palavra)
            {
                // 🎯 1ª volta: letra='O'  → Print "O"
                //     2ª volta: letra='p'  → Print "p"
                //     3ª volta: letra='a'  → Print "a"
                //     4ª volta: letra='!'  → Print "!"
                Console.WriteLine(letra);
            }
            // 💀 FIM: Quando acaba a coleção
            var alunos = new string[] { "Kleiton", "Alana", "Luzia" };
            foreach(string aluno in alunos){
                Console.WriteLine(aluno);
            }
        }   
          
    }
}
