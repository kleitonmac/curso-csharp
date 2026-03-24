using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    class Params
    { 
        public static void Recepcionar(params string[] pessoas) //params utilizado para receber um número variável de argumentos do mesmo tipo, nesse caso,
                                                                //uma lista de strings representando os nomes das pessoas a serem recepcionadas.
        {
            foreach (var pessoa in pessoas) // looping foreach para iterar sobre cada elemento do array
                                            // 'pessoas' e imprimir uma mensagem de saudação personalizada para cada pessoa.
            {
                Console.WriteLine("Olá {0}", pessoa);
            }
        }
        public static void Executar()
        {
            Recepcionar("Kleiton","vo izabel","Luiza","tia keila","Alana"); // chamando o metodo Recepcionar e passando uma lista de nomes como argumentos.
                                                                  // O método irá imprimir uma mensagem de saudação para cada nome fornecido.
        }
    }
}
