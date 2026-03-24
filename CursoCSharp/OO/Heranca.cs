using System; // Importa funcionalidades básicas (Console, etc.)

namespace CursoCSharp.OO // Organização lógica do código
{
    // Classe base (superclasse)
    // Representa o comportamento comum de QUALQUER carro
    public class Carro
    {
        // readonly = só pode ser atribuído no construtor
        // protected = acessível nas classes filhas (Uno, Ferrari)
        protected readonly int VelocidadeMaxima;

        // Velocidade atual do carro
        // protected = subclasses podem acessar
        // = 0 garante valor inicial padrão
        protected int VelocidadeAtual = 0;

        // Construtor da classe base
        public Carro(int velocidadeMaxima)
        {
            // Inicializa o campo readonly
            VelocidadeMaxima = velocidadeMaxima;
        }

        // Método responsável por alterar velocidade
        // protected = só subclasses usam diretamente
        // virtual = pode ser sobrescrito
        protected virtual int AlterarVelocidade(int delta)
        {
            int novaVelocidade = VelocidadeAtual + delta; // Soma ou subtrai velocidade

            // Não pode ser menor que 0
            if (novaVelocidade < 0)
                VelocidadeAtual = 0;

            // Não pode ultrapassar o limite máximo
            else if (novaVelocidade > VelocidadeMaxima)
                VelocidadeAtual = VelocidadeMaxima;

            // Valor válido
            else
                VelocidadeAtual = novaVelocidade;

            return VelocidadeAtual; // Retorna a velocidade final
        }

        // Método público para acelerar
        public virtual int Acelerar() => AlterarVelocidade(5);

        // Método público para frear
        public virtual int Frear() => AlterarVelocidade(-5);
    }

    // Classe Uno herda de Carro
    public class Uno : Carro
    {
        // Construtor chama o da classe pai
        public Uno() : base(200) // Uno tem limite de 200
        {
        }

        // ⚠️ ATENÇÃO: Ferrari está DENTRO de Uno (classe aninhada)
        public class Ferrari : Carro
        {
            public Ferrari() : base(370) // Ferrari tem limite maior
            {
            }

            // override = substitui comportamento da classe pai
            public override int Acelerar()
            {
                return AlterarVelocidade(380);
                // Ferrari acelera MUITO mais rápido
            }

            // new = ESCONDE o método da classe pai (não é override)
            public new int Frear()
            {
                return AlterarVelocidade(-170);
            } // comportamento diferente de frenagem
        }

        // Classe de teste
        public class Heranca
        {
            public static void Executar()
            {
                Console.WriteLine("=== DEMO Uno ===");

                // Instanciando objetos
                Uno carro1 = new Uno();
                Ferrari carro2 = new Ferrari();

                // Testando Uno
                Console.WriteLine($"Acelerar: {carro1.Acelerar()}"); // 5
                Console.WriteLine($"Acelerar: {carro1.Acelerar()}"); // 10
                Console.WriteLine($"Frear:    {carro1.Frear()}");    // 5
                Console.WriteLine($"Frear:    {carro1.Frear()}");    // 0

                Console.WriteLine("======Ferrari====");

                // Testando Ferrari
                Console.WriteLine($"Acelerando a Ferrari a {carro2.Acelerar()}");
                Console.WriteLine($"Freando a Ferrari {carro2.Frear()}");
            }
        }
    }
}