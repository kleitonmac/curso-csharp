using CursoCSharp.EstruturasDeControle;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Channels;

namespace CursoCSharp.Colecoes
{
     class Arrays{

        public static void Executar(){
            string[] alunos = new string[5]; // lista de arrays
            alunos[0] = "Ellen";
            alunos[1] = "Willyam";
            alunos[2] = "Kleisson";
            alunos[3] = "Kleiton";
            alunos[4] = "Alana";

            foreach(var aluno in alunos){ // looping do array alunos
                Console.WriteLine(aluno);
            }
            

            double somatorio = 0; // atributos dos arrays alunos
            double[] notas = { 9.7, 5.5, 8.0, 7.0, 10.0 };

            foreach (var nota in notas) {  // looping das  notas de alunos
            somatorio += nota;
            }

            double media = somatorio / notas.Length;
            Console.WriteLine(media);

            // array de char um caracter
            char[] letras = { 'a', 'b', 'c', 'd' , 'e' };
            string palavra = new string(letras);
            Console.WriteLine(letras);

        }
    }

       
}
