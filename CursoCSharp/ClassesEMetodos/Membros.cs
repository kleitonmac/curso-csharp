using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    class Membros { // chamado da classe Pessoa.cs 
        public static void Executar() { 
            Pessoa moradores = new Pessoa();
            moradores.Nome = "Kleiton";
            moradores.Idade = 28;
            moradores.Endereco = "Rua Uberlandia";
            moradores.Sobrenome = "Macedo";

            //Console.WriteLine($"{moradores.Nome } {moradores.Sobrenome} tem {moradores.Idade}anos e seu endereço é {moradores.Endereco}");
            moradores.ApresentarNoConsole();

            var namorada = new Pessoa();
            namorada.Nome = "Alana";
            namorada.Idade = 23;
            namorada.Endereco = "Cuieté Velho";
            namorada.Sobrenome = "Arze";

            Console.WriteLine($"Meu nome é {namorada.Nome} {namorada.Sobrenome} tenho {namorada.Idade} anos e moro em SP na rua {namorada.Endereco}");
        }
    }
}
