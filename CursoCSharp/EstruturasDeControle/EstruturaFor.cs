using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturasDeControle
{
    public class EstruturaFor
    {
        /// <summary>
        /// 🔢 FOR: Perfeito quando você SABE quantas vezes repetir!
        /// QUANDO USAR: Contar de 1 a 10, percorrer arrays, tabelas, menus fixos
        /// FORMATO: for(📍INÍCIO; 🧪CONDIÇÃO; ➕PASSO)
        /// </summary>
        public static void Executar() // metodo vazio void
        {
            //for (int i = 1; i <= 10; i++)
            //{

            //    Console.WriteLine($"O valor de i é {i} .");
            //}

            double somatorio = 0;
            string entrada;

            Console.Write("Informe o tamanho da Turma ");
            entrada = Console.ReadLine();
            int.TryParse(entrada, out int tamanhoTurma);

            for (int i = 1; i <= tamanhoTurma; i++)
            {
                Console.WriteLine("Informe a Nota dos Alunos {0}: ", i);
                entrada= Console.ReadLine();
                double.TryParse(entrada, out double notaAtual);

                somatorio += notaAtual;
            }
            double media = tamanhoTurma > 0 ? somatorio / tamanhoTurma : 0;
            Console.WriteLine(" Media da Turma : {0}", media);


        }
    }
}
