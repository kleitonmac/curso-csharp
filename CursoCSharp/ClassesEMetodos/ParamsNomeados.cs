using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
     class ParamsNomeados
    {
        public static void Formatar(int dia , int mes , int ano){
            Console.WriteLine("{0:D2}/{1:D2}/{2}", dia , mes, ano); /// criação de datas por padrao nomeados 


        }

        public static void Executar(){
            Formatar(mes:03, dia:17 , ano:2026 );
        }
    }
}
