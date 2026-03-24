using System; // Importa funcionalidades básicas do .NET → permite usar Console.WriteLine

namespace Encapsulamento // Namespace → organização lógica do código (como uma “pasta”)
{
    // public → classe pode ser acessada por qualquer outro código (outros arquivos/projetos)
    public class SubCelebridade
    {
        // 🔓 public → acesso TOTAL
        // Pode ser acessado de qualquer lugar (classe, herança, outro projeto, etc.)
        public string InfoPublica = "Tenho instagram";

        // 🧬 protected → acesso por HERANÇA
        // Só pode ser acessado:
        // ✔ dentro da própria classe
        // ✔ por classes que HERDAM desta classe
        protected string CorDosOlhos = "Azul";

        // 🏢 internal → acesso por PROJETO (assembly)
        // Só pode ser acessado por classes do MESMO PROJETO
        // Mesmo namespace ≠ mesmo projeto (atenção nisso)
        internal ulong NumeroCelular = 5511999999999;

        // 🔄 protected internal → acesso híbrido
        // Pode ser acessado:
        // ✔ no mesmo projeto
        // ✔ OU por herança (mesmo em outro projeto)
        protected internal string JeitoDeFalar = "Uso muitas gírias";

        // 🔐 private protected (C# 7.2+)
        // Mais restritivo que o anterior
        // Só pode ser acessado:
        // ✔ dentro da própria classe
        // ✔ OU por herança, MAS apenas no MESMO projeto
        private protected string SegredoFamilia = "Blá blá";

        // 🔒 private (padrão se não declarar nada)
        // Só pode ser acessado DENTRO desta classe
        // Nem herança consegue acessar
        bool UsaMuitoPhotoshop = true;

        // Método público → pode ser chamado de qualquer lugar
        public void MeusAcessos()
        {
            // Exibe título no console
            Console.WriteLine("====Sub Celebridade====");

            // Dentro da própria classe:
            // 👉 TODOS os membros são acessíveis, independente do modificador

            Console.WriteLine(InfoPublica);
            // public → sempre acessível

            Console.WriteLine(CorDosOlhos);
            // protected → acessível aqui porque estamos na própria classe

            Console.WriteLine(NumeroCelular);
            // internal → acessível porque estamos no mesmo projeto

            Console.WriteLine(JeitoDeFalar);
            // protected internal → sempre acessível aqui

            Console.WriteLine(SegredoFamilia);
            // private protected → acessível dentro da própria classe

            Console.WriteLine(UsaMuitoPhotoshop);
            // private → acessível SOMENTE aqui dentro
        }
    }
}