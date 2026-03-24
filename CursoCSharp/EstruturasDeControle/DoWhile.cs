using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturasDeControle
{
    public class DoWhile
    {
        /// <summary>
        /// 🔄 DO-WHILE: Executa PRIMEIRO, testa DEPOIS!
        /// VANTAGEM: Garante que o bloco rode PELO MENOS 1 VEZ
        /// DIFERENÇA do while: while testa PRIMEIRO (pode NÃO executar)
        /// </summary>
        public static void Executar()
        {
            string entrada;

            // 🚀 DO-WHILE em ação:
            // 1️⃣ PRIMEIRO executa o bloco { }
            // 2️⃣ DEPOIS testa a condição while()
            // 3️⃣ Se TRUE → repete desde o início
            // 4️⃣ Se FALSE → SAI do loop
            do
            {
                // 📥 1ª EXECUÇÃO: Sempre acontece!
                Console.WriteLine("Qual e o seu nome");
                entrada = Console.ReadLine();

                Console.WriteLine("Seja Bem-vindo");
                Console.WriteLine("Deseja Continuar ? S/N");
                entrada = Console.ReadLine();  // ← Resposta que decide!
            }
            // 🧪 CONDIÇÃO NO FINAL: Só testa APÓS 1ª execução
            while (entrada.ToLower() == "s");  // ✅ ; obrigatório aqui!
        }
    }
}
