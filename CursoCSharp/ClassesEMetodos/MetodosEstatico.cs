using System;

namespace CursoCSharp.ClassesEMetodos
{
    public class CalculadoraEstatica
    {
        // Métodos estáticos: não precisam criar objeto
        public static int Somar(int a, int b) => a + b; // => retorno direto
        public static int Multiplicar(int a, int b) => a * b; // retorno direto
    }

    public class MetodosEstatico
    {
        public static void Executar()
        {
            // Chamando métodos estáticos diretamente pela classe
            var resultado = CalculadoraEstatica.Multiplicar(4, 4);
            Console.WriteLine("Resultado é {0}", resultado);

            Console.WriteLine("Soma: {0}", CalculadoraEstatica.Somar(2, 2));
        }
    }
}