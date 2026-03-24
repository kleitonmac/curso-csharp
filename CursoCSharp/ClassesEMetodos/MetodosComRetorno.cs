using System;

namespace CursoCSharp.ClassesEMetodos
{
    // Interface pública para o Fluent Interface (Chain)
    public interface ICalculadoraCadeia
    {
        ICalculadoraCadeia Somar(int a);       // Soma à memória
        ICalculadoraCadeia Multiplicar(int a); // Multiplica a memória
        ICalculadoraCadeia Limpar();           // Zera a memória
        ICalculadoraCadeia Imprimir();         // Imprime a memória
        int Resultado();                       // Retorna o valor final
    }

    // Classe principal da calculadora
    public class CalculadoraComum
    {
        // ===== MÉTODOS SIMPLES =====
        public int Somar(int a, int b) { return a + b; }
        public int Subtrair(int a, int b) { return a - b; }
        public int Multiplicar(int a, int b) { return a * b; }

        // ===== CLASSE INTERNA PRIVADA PARA FLUENT INTERFACE =====
        private class CalculadoraCadeia : ICalculadoraCadeia
        {
            private int memoria;

            public ICalculadoraCadeia Somar(int a) { memoria += a; return this; }
            public ICalculadoraCadeia Multiplicar(int a) { memoria *= a; return this; }
            public ICalculadoraCadeia Limpar() { memoria = 0; return this; }
            public ICalculadoraCadeia Imprimir() { Console.WriteLine(memoria); return this; }
            public int Resultado() { return memoria; }
        }

        // ===== MÉTODO PÚBLICO PARA INICIAR O CHAIN =====
        public ICalculadoraCadeia Chain()
        {
            return new CalculadoraCadeia();
        }
    }

    // ===== CLASSE DE EXECUÇÃO =====
    public class MetodosComRetorno
    {
        public static void Executar()
        {
            var calculadora = new CalculadoraComum();

            // Operações simples
            Console.WriteLine("Soma Simples: " + calculadora.Somar(3, 3));          // 6
            Console.WriteLine("Subtração Simples: " + calculadora.Subtrair(10, 3)); // 7
            Console.WriteLine("Multiplicação Simples: " + calculadora.Multiplicar(5, 8)); // 40

            // ===== FLUENT INTERFACE =====
            calculadora.Chain()
                .Somar(3)       // memória = 3
                .Multiplicar(3) // memória = 9
                .Imprimir()     // imprime 9
                .Limpar()       // memória = 0
                .Imprimir();    // imprime 0

            // Mantém o console aberto para ver os resultados
            Console.WriteLine("Pressione ENTER para sair...");
            Console.ReadLine();
        }
    }
}