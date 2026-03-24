using System; // Importa funcionalidades básicas → permite usar Console.WriteLine

namespace Encapsulamento // Mesmo namespace/projeto da classe SubCelebridade
{
    // Classe comum → NÃO herda de SubCelebridade
    // Ou seja: aqui temos COMPOSIÇÃO, não herança
    public class AmigosProximos
    {
        // readonly → a referência do objeto não pode ser alterada depois
        // ✔ pode usar o objeto normalmente
        // ❌ não pode fazer: amiga = new SubCelebridade();

        // Cria um objeto da classe SubCelebridade (composição: "tem-um")
        public readonly SubCelebridade amiga = new SubCelebridade();

        public void MeusAcessos()
        {
            // Exibe título
            Console.WriteLine("=====Amigos Proximos");

            // ===============================
            // ✔ ACESSOS PERMITIDOS
            // ===============================

            // 🔓 public → acessível de qualquer lugar
            // Independente de herança ou projeto
            Console.WriteLine(amiga.InfoPublica);

            // 🏢 internal → acessível porque estamos no MESMO PROJETO
            // Mesmo sem herança, funciona
            Console.WriteLine(amiga.NumeroCelular);

            // 🔄 protected internal → acessível por:
            // ✔ mesmo projeto OU
            // ✔ herança
            // Aqui funciona porque estamos no mesmo projeto
            Console.WriteLine(amiga.JeitoDeFalar);

            // ===============================
            // ❌ ACESSOS NEGADOS (para estudo)
            // ===============================

            // 🧬 protected → precisa de HERANÇA
            // Aqui NÃO tem herança (é composição)
            // Console.WriteLine(amiga.CorDosOlhos);

            // 🔐 private protected → precisa:
            // ✔ herança
            // ✔ E mesmo projeto
            // Aqui falta herança → erro
            // Console.WriteLine(amiga.SegredoFamilia);

            // 🔒 private → só dentro da própria classe SubCelebridade
            // Não é herdado nem acessado por composição
            // Console.WriteLine(amiga.UsaMuitoPhotoshop);
        }
    }
}