using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturasDeControle
{
    public class EstruturaDeContinue
    {
        public static void Executar() // metodo vazio void
        {
            Console.WriteLine("🔍 Buscando números PARES de 1 até 20");
            Console.WriteLine("Os ímpares serão PULADOS com CONTINUE!\n");

            // 🔄 Laço que testa TODOS os números de 1 até 20
            for (int i = 1; i <= 20; i++)
            {
                // ❓ TESTA: este número é ÍMPAR?
                if (i % 2 != 0)  // % é resto da divisão. Resto != 0 = ÍMPAR
                {
                    Console.WriteLine("{0} é ÍMPAR ➡️ PULANDO para próximo...", i);

                    // 🚀 CONTINUE = PULA RESTO DO CÓDIGO e vai para PRÓXIMA iteração
                    continue; // Ignora o Console.WriteLine("É par!") e vai pro i++
                }

                // ✅ SÓ CHEGA AQUI SE FOR PAR (não foi pulado pelo continue)
                Console.WriteLine("{0} é PAR! ✓", i);
            }

            Console.WriteLine("\n🏁 Fim da busca!");
        }
    }
}
