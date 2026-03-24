using System;
using System.Collections.Generic;

namespace CursoCSharp.Colecoes
{
    class ColecoesQueue{

        public static void Executar(){
            var fila = new Queue<string>();
            fila.Enqueue("Marta"); // enqueue em filera 
            fila.Enqueue("João");
            fila.Enqueue("Maria");
            fila.Enqueue("Frida");

            Console.WriteLine(fila.Peek());
            Console.WriteLine(fila.Count);

            Console.WriteLine(fila.Dequeue()); // dequeue desenfilera a fila a ordem
            Console.WriteLine(fila.Count);

            foreach(var pessoa in fila)
            {
                Console.WriteLine(pessoa); 
              }
        }
    }
}
