using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturasDeControle
{
    public class Estrutura
    {
        /// <summary>
        /// 🎯 WHILE: Testa PRIMEIRO, executa DEPOIS (pode NÃO executar!)
        /// QUANDO USAR: Quando NÃO sabe quantas repetições, depende de condição variável
        /// PERFEITO para: jogos, menus S/N, aguardar usuário/entrada
        /// </summary>
        public static void Executar()
        {
            // 📌 INICIALIZAÇÃO - Prepara variáveis do jogo
            int palpite = 0;
            Random random = new Random();
            int numeroSecreto = random.Next(1, 6);
            bool numeroEncontrado = false;
            int tentativasRestantes = 5;
            int tentativas = 0;

            // 🔄 WHILE em ação: TESTA → EXECUTA → REPETE
            // while(CONDIÇÃO) = Continua ENQUANTO condição for TRUE
            while (tentativasRestantes > 0 && !numeroEncontrado)
            {
                // 🚀 1. TESTA: tem tentativas? Acertou? → SIM → entra no bloco
                // 📥 INPUT - Lê palpite do usuário
                Console.Write("Insira o seu Palpite (1-5): ");
                string entrada = Console.ReadLine();
                int.TryParse(entrada, out palpite);

                // 📊 CONTROLE - Atualiza contadores
                tentativas++;
                tentativasRestantes--;

                // 🎯 LÓGICA DO JOGO
                if (numeroSecreto == palpite)
                {
                    numeroEncontrado = true;  // ← Para o while!
                    var corAnterior = Console.BackgroundColor;
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("🎉 PARABÉNS! Número encontrado em {0} tentativas!", tentativas);
                    Console.BackgroundColor = corAnterior;
                }
                else if (palpite > numeroSecreto)
                {
                    Console.WriteLine("🔻 Menor... Tente Novamente!");
                    Console.WriteLine("Tentativas Restantes: {0}", tentativasRestantes);
                }
                else
                {
                    Console.WriteLine("🔺 Maior... Tente Novamente!");
                    Console.WriteLine("Tentativas Restantes: {0}", tentativasRestantes);
                }
                // ⬆️ Volta e testa while() novamente!
            }

            if (!numeroEncontrado)
            {
                Console.WriteLine("\n💥 GAME OVER! O número era: {0}", numeroSecreto);
            }

            Console.WriteLine("\nPressione ENTER para continuar...");
            Console.ReadLine();
        }
    }
}
