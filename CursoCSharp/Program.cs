using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

using CursoCSharp.Colecoes;
using CursoCSharp.OO;
using CursoCSharp.EstruturasDeControle;
using CursoCSharp.MetodosEFuncoes;
namespace CursoCSharp.Fundamentos
{
    class Program
    {
        static void Main(string[] args)
        {
            CentralDeListaEExecutar();

            Console.WriteLine("Pressione qualquer tecla para encerrar...");
            Console.ReadKey();
        }

        static void CentralDeListaEExecutar()
        {
            // Lista de pares: (texto, método)
            var tarefas = new List<(string descricao, Action executar)>
            {
                // Estruturas de controle
                ("Estrutura de Controle - Do While", CursoCSharp.EstruturasDeControle.DoWhile.Executar),
                ("Estrutura de Controle - Estrutura For", CursoCSharp.EstruturasDeControle.EstruturaFor.Executar),
                ("Estrutura de Controle - Estrutura ForEach", CursoCSharp.EstruturasDeControle.EstruturaForEach.Executar),
                ("Estrutura de Controle - Break", CursoCSharp.EstruturasDeControle.EstruturaBreak.Executar),
                ("Estrutura de Controle - Continue", CursoCSharp.EstruturasDeControle.EstruturaDeContinue.Executar),

                // Classes e métodos
                ("Classes e Métodos - Membros", CursoCSharp.ClassesEMetodos.Membros.Executar),
                ("Classes e Métodos - Construtores", CursoCSharp.ClassesEMetodos.Construtores.Executar),
                ("Classes e Métodos - Métodos com Retorno", CursoCSharp.ClassesEMetodos.MetodosComRetorno.Executar),
                ("Classes e Métodos - Métodos Estáticos", CursoCSharp.ClassesEMetodos.MetodosEstatico.Executar),
                ("Classes e Métodos - Atributos Estáticos", CursoCSharp.ClassesEMetodos.AtributoEstaticos.Executar),
                ("Classes e Métodos - Desafio Atributo", CursoCSharp.ClassesEMetodos.DesafioAtributo.Executar),
                ("Classes e Métodos - Params", CursoCSharp.ClassesEMetodos.Params.Executar),
                ("Classes e Métodos - Params Nomeados", CursoCSharp.ClassesEMetodos.ParamsNomeados.Executar),
                ("Classes e Métodos - Get/Set", CursoCSharp.ClassesEMetodos.GetSet.Executar),
                ("Classes e Métodos - Props", CursoCSharp.ClassesEMetodos.Props.Executar),
                ("Classes e Métodos - Readonly", CursoCSharp.ClassesEMetodos.Readonly.Executar),
                ("Classes e Métodos - Exemplo Enum", CursoCSharp.ClassesEMetodos.ExemploEnum.Executar),
                ("Classes e Métodos - Exemplo Struct", CursoCSharp.ClassesEMetodos.ExemploStruct.Executar),
                ("Classes e Métodos - Struct vs Classe", CursoCSharp.ClassesEMetodos.StructVsClasse.Executar),
                ("Classes e Métodos - Valor vs Referência", CursoCSharp.ClassesEMetodos.ValorVsReferencia.Executar),
                ("Classes e Métodos - Parâmetro Padrão", CursoCSharp.ClassesEMetodos.ParamentroPadrao.Executar),

                // Coleções
                ("Coleções - Arrays", CursoCSharp.Colecoes.Arrays.Executar),
                ("Coleções - Coleção List", CursoCSharp.Colecoes.ColecaoList.Executar),
                ("Coleções - ArrayList", CursoCSharp.Colecoes.ColecoesArrayList.Executar),
                ("Coleções - ArraySetList", CursoCSharp.Colecoes.ColecaoListSet.Executar),
                ("Coleções - Fila ordernada", CursoCSharp.Colecoes.ColecoesQueue.Executar),
                ("Coleções - Usando Igualdade", CursoCSharp.Colecoes.Igualdade.Executar),
                ("Coleções - Usando Stack", CursoCSharp.Colecoes.ColecoesStack.Executar),
                ("Coleções - Usando Dicionario", CursoCSharp.Colecoes.ColecoesDicionario.Executar),

                // Orientação a objeto
                ("Orientação a Objeto - Herança", CursoCSharp.OO.Uno.Heranca.Executar),
                ("Orientação a Objeto - Construtor This", CursoCSharp.OO.ConstrutorThis.Executar),
                ("Orientação a Objeto - Encapsulamento", CursoCSharp.OO.Encapsulamento.Executar),
                ("Orientação a Objeto - Polimorfismo", CursoCSharp.OO.Polimorfismo.Executar),
                ("Orientação a Objeto - Classes Abstract", CursoCSharp.OO.Abstract.Executar),
                ("Orientação a Objeto - Classes Sealed", CursoCSharp.OO.Sealed.Executar),
                ("Orientação a Objeto - Interface", CursoCSharp.OO.Interface.Executar),

                // Metodos e Funcoees
                ("Metodos e Funçoes Lambda - Lambda", CursoCSharp.MetodosEFuncoes.ExemploLambda.Executar),
                ("Metodos e Funçoes Lambda - Usando Delegate", CursoCSharp.MetodosEFuncoes.UsandoDelegate.Executar),
            };

            // Executa cada tarefa, mostrando o texto no console
            foreach (var (descricao, executar) in tarefas)
            {
                Console.WriteLine("=".PadLeft(60, '='));
                Console.WriteLine(descricao);
                Console.WriteLine("=".PadLeft(60, '='));
                executar();   // <<< aqui chama o Executar()
                Console.WriteLine(); // linha em branco entre execuções
            }
        }
    }
}
