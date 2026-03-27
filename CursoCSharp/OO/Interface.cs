using System;

namespace CursoCSharp.OO
{
    // Interface: contrato UNIFORME para todas operações binárias
    public interface OperacaoBinaria
    {
        int Operacao(int a, int b);
    }

    // ✅ Soma: implementa interface corretamente
    public class Soma : OperacaoBinaria
    {
        public int Operacao(int a, int b) => a + b; // Expression-bodied para concisão
    }

    // ✅ Subtração: OK, mas formatado
    public class Subtracao : OperacaoBinaria
    {
        public int Operacao(int a, int b) => a - b;
    }

    // ✅ Multiplicação: OK
    public class Multiplicao : OperacaoBinaria
    {
        public int Operacao(int a, int b) => a * b;
    }

    // ✅ Divisão: MUDADO para int (compatível com interface); usa cast e erro /0
    public class Divisao : OperacaoBinaria
    {
        public int Operacao(int a, int b)
        {
            if (b == 0) throw new DivideByZeroException("Divisão por zero!");
            return a / b; // int / int = int (truncado); ex: 10/3=3
        }
    }

    public class Interface
    {
        public static void Executar()
        {
            // Array polimórfico: todas via interface
            OperacaoBinaria[] operacoes = { new Soma(), new Subtracao(), new Multiplicao(), new Divisao() };

            int x = 10, y = 3;
            Console.WriteLine("=== CALCULADORA POLIMÓRFICA (10 e 3) ===\n");

            foreach (OperacaoBinaria op in operacoes)
            {
                string nome = op.GetType().Name;
                int resultado = op.Operacao(x, y);

                // Saída LIMPA e didática por operação
                switch (nome)
                {
                    case "Soma":
                        Console.WriteLine($"SOMA:     10 + 3 = {resultado}");
                        break;
                    case "Subtracao":
                        Console.WriteLine($"SUBTRAÇÃO: 10 - 3 = {resultado}");
                        break;
                    case "Multiplicao":
                        Console.WriteLine($"MULTIPLICAÇÃO: 10 × 3 = {resultado}");
                        break;
                    case "Divisao":
                        Console.WriteLine($"DIVISÃO:   10 ÷ 3 = {resultado} (truncado)");
                        break;
                }
            }
            Console.WriteLine("\n=== Polimorfismo: mesmo método, resultados diferentes! ===");
        }
    }
}