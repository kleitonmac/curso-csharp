using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturasDeControle
{
    public class EstruturaBreak
    {
        public static void Executar()
        {
            // ✅ CRIANDO UM NÚMERO ALEATÓRIO SECRETO (entre 1 e 50)
            // Random.Next(1, 51) gera números de 1 até 50 (o 51 é EXCLUSIVO)
            Random random = new Random();
            int numero = random.Next(1, 51);

            // 📢 MOSTRA O NÚMERO SECRETO (só para fins didáticos)
            // Na vida real, isso seria um "spoiler" do jogo!
            Console.WriteLine("O numero que queremos é {0}.", numero);

            // 🔄 LAÇO FOR: vai testar TODOS os números de 1 até 50
            for (int i = 1; i <= 50; i++)
            {
                // ❓ PERGUNTA: "Este é o número certo?"
                Console.WriteLine("{0} é o numero que queremos? ", i);

                if (i == numero)
                {
                    // 🎉 ACHEI! É este número mesmo!
                    Console.WriteLine("Sim");

                    // 🚪 BREAK = SAIR IMEDIATAMENTE do laço
                    // O laço PARA aqui e não testa mais números
                    break; // vai sair do laço de repetição
                }
                else
                {
                    // ❌ Não é este... continua procurando
                    Console.WriteLine("Não");
                }
                // 💡 Sem o BREAK, o laço continuaria até 50
                // Com o BREAK, para ASSIM QUE ACHAR o número
            }

            // 📍 Este código só executa DEPOIS do break ou do fim natural do laço
            Console.WriteLine("Fim da busca!");
        }
    }
}
