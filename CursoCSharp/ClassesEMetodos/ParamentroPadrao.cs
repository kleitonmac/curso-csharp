using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    // Classe que serve apenas para agrupar o método de exemplo sobre parâmetros padrão.
    class ParamentroPadrao  // <<< Note: "Parâmetro" é o correto, mas o nome não interfere no funcionamento.
    {
        // Método estático que recebe dois parâmetros inteiros.
        // int a = 1   -> parâmetro opcional com valor padrão 1
        // int b = 3   -> parâmetro opcional com valor padrão 3
        // Quando o chamador não passar valor, o C# usa o valor padrão definido.
        public static int Somar(int a = 1, int b = 3)
        {
            // Realiza a soma entre 'a' e 'b' e retorna o resultado.
            return a + b;
        }

        // Método estático de teste para executar o exemplo.
        public static void Executar()
        {
            // 1º chamada: passa dois valores.
            // a = 10, b = 23 -> usa os valores passados, ignorando os padrões.
            // Resultado: 10 + 23 = 33
            Console.WriteLine(Somar(10, 23));

            // 2º chamada: passa apenas um valor.
            // a = 50, b = padrão (3) -> o segundo usa o valor padrão definido na assinatura.
            // Resultado: 50 + 3 = 53
            Console.WriteLine(Somar(50));

            // 3º chamada: não passa nenhum valor.
            // a = padrão (1), b = padrão (3) -> ambos usam os valores padrão da assinatura.
            // Resultado: 1 + 3 = 4
            Console.WriteLine(Somar());
        }
    }
}
