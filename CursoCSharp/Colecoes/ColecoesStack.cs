using System;
using System.Collections;  // ✅ Stack antigo está AQUI!

namespace CursoCSharp.Colecoes
{
    class ColecoesStack
    {
        public static void Executar()
        {
            var stack = new Stack();

            stack.Push(3);
            stack.Push("a");
            stack.Push(true);
            stack.Push(3.14);

            foreach (var item in stack)
            {
                Console.WriteLine($"{item}");
            }

            // ✅ Pop() = REMOVE E RETORNA o TOPO
            Console.WriteLine($"\nPop: {stack.Pop()}");

            Console.WriteLine($"\nPop {stack.Peek()}");
            Console.WriteLine($"\nPop {stack.Count}");
        }
    }
}
