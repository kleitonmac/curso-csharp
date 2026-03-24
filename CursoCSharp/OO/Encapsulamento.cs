using System; // Importa funcionalidades básicas → permite usar Console.WriteLine
using System.Collections.Generic; // Biblioteca de listas (não usada aqui)
using System.Text; // Manipulação de texto (não usada aqui)
using Encapsulamento;
// Importa OUTRO namespace onde estão:
// SubCelebridade, AmigosProximos, FilhoReconhecido

// ⚠️ IMPORTANTE:
// Namespace ≠ classe
// Namespace é apenas organização lógica
namespace CursoCSharp.OO // Namespace DIFERENTE (simula outro projeto)
{
    // Classe filha → HERDA de SubCelebridade
    public class FilhoNaoReconhecido : SubCelebridade
    {
        // new → NÃO sobrescreve
        // Apenas ESCONDE o método da classe pai
        // (não tem polimorfismo real aqui)
        public new void MeusAcessos()
        {
            // Imprime título
            Console.WriteLine("=====Filhos Não Reconhecido ====");

            // 🔓 public → sempre acessível
            // Pode ser acessado de qualquer classe/projeto
            Console.WriteLine(InfoPublica);

            // 🧬 protected → acessível por HERANÇA
            // Mesmo estando em outro namespace/projeto
            Console.WriteLine(CorDosOlhos);

            // 🔄 protected internal → acessível por:
            // ✔ herança OU
            // ✔ mesmo projeto
            // Aqui funciona por causa da HERANÇA
            Console.WriteLine(JeitoDeFalar);

            // ===============================
            // ❌ NÃO FUNCIONA (para estudo)
            // ===============================

            // internal → só funciona no MESMO projeto
            // Como estamos simulando outro projeto, dá erro
            // Console.WriteLine(NumeroCelular);

            // private protected → precisa:
            // ✔ herança
            // ✔ mesmo projeto
            // Aqui NÃO atende → erro
            // Console.WriteLine(SegredoFamilia);

            // private → só existe dentro da própria classe
            // Não herda → erro
            // Console.WriteLine(UsaMuitoPhotoshop);
        }
    }

    // Classe comum (NÃO herda de SubCelebridade)
    public class AmigoDistante
    {
        // readonly → não pode trocar a referência depois
        // composição → essa classe TEM um objeto SubCelebridade
        public readonly SubCelebridade amiga = new SubCelebridade();

        public void MeusAcessos()
        {
            // Título
            Console.WriteLine("Amigos distantes");

            // 🔓 public → sempre acessível
            Console.WriteLine(amiga.InfoPublica);

            // ===============================
            // ❌ NÃO FUNCIONA (para estudo)
            // ===============================

            // internal → outro projeto NÃO pode acessar
            // Console.WriteLine(amiga.NumeroCelular);

            // protected → só funciona com HERANÇA
            // Aqui é composição → erro
            // Console.WriteLine(amiga.CorDosOlhos);

            // protected internal → precisa:
            // ✔ herança OU
            // ✔ mesmo projeto
            // Aqui NÃO tem nenhum dos dois → erro
            // Console.WriteLine(amiga.JeitoDeFalar);
        }
    }

    // Classe responsável por EXECUTAR tudo
    class Encapsulamento
    {
        public static void Executar()
        {
            // ===============================
            // 1. CLASSE BASE
            // ===============================

            // Cria um objeto da classe SubCelebridade
            SubCelebridade sub = new SubCelebridade();

            // Chama método dentro da própria classe
            // → aqui TODOS os atributos são acessíveis
            sub.MeusAcessos();

            // ===============================
            // 2. FILHO EM OUTRO "PROJETO"
            // ===============================

            // Cria objeto da classe filha
            // (herança, mas fora do namespace original)
            new FilhoNaoReconhecido().MeusAcessos();

            // ===============================
            // 3. MESMO PROJETO (COMPOSIÇÃO)
            // ===============================

            // Classe do mesmo namespace Encapsulamento
            // → tem acesso a internal
            new AmigosProximos().MeusAcessos();

            // ===============================
            // 4. FILHO NO MESMO PROJETO
            // ===============================

            // Melhor cenário:
            // ✔ herança
            // ✔ mesmo projeto
            new FilhoReconhecido().MeusAcessos();

            // ===============================
            // 5. PIOR CENÁRIO
            // ===============================

            // Classe sem herança + outro projeto
            // → só acessa public
            new AmigoDistante().MeusAcessos();
        }
    }
}