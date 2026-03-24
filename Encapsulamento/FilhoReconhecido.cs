using System; // Importa funcionalidades básicas → permite usar Console.WriteLine

namespace Encapsulamento // Mesmo namespace/projeto da classe pai
{
    // FilhoReconhecido HERDA de SubCelebridade
    // Ou seja: ganha acesso aos membros permitidos pela herança
    public class FilhoReconhecido : SubCelebridade
    {
        // new → NÃO é sobrescrita (override)
        // Ele apenas ESCONDE o método da classe pai
        // ⚠️ Não existe polimorfismo aqui
        public new void MeusAcessos()
        {
            // Exibe título
            Console.WriteLine("Filho Reconhecido");

            // ===============================
            // ✔ ACESSOS PERMITIDOS
            // ===============================

            // 🔓 public → acessível em qualquer lugar
            // Classe, herança, outro projeto, tudo
            Console.WriteLine(InfoPublica);

            // 🧬 protected → acessível por HERANÇA
            // Como essa classe herda, ela pode acessar
            Console.WriteLine(CorDosOlhos);

            // 🏢 internal → acessível dentro do MESMO PROJETO
            // Como estamos no mesmo namespace/projeto → funciona
            Console.WriteLine(NumeroCelular);

            // 🔄 protected internal → acessível por:
            // ✔ herança OU
            // ✔ mesmo projeto
            // Aqui temos os dois → funciona
            Console.WriteLine(JeitoDeFalar);

            // 🔐 private protected → acessível por:
            // ✔ herança
            // ✔ E mesmo projeto (os dois são obrigatórios)
            // Aqui atende as duas regras → funciona
            Console.WriteLine(SegredoFamilia);

            // ===============================
            // ❌ ACESSO NEGADO (para estudo)
            // ===============================

            // 🔒 private → NÃO é herdado
            // Só pode ser acessado dentro da própria classe SubCelebridade
            // Console.WriteLine(UsaMuitoPhotoshop);
        }
    }
}