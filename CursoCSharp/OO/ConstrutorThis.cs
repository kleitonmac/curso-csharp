namespace CursoCSharp.OO // Define um namespace para organizar o código
{
    public class Animal // Classe base (superclasse)
    {
        public string Nome { get; set; } // Propriedade pública com getter e setter

        public Animal(string nome) // Construtor da classe Animal
        {
            Nome = nome; // Atribui o valor recebido ao atributo Nome
        }
    }

    public class Cachorro : Animal // Classe Cachorro HERDA de Animal
    {
        public double Altura { get; set; } // Nova propriedade específica de Cachorro

        public Cachorro(string nome) : base(nome) // Construtor 1
        // : base(nome) chama o construtor da classe pai (Animal)
        {
            Console.WriteLine($"Cachorro {nome} foi inicializado");
            // Exibe mensagem ao criar o objeto
        }

        public Cachorro(string nome, double altura) : this(nome)
        // : this(nome) chama o OUTRO construtor da mesma classe
        {
            Altura = altura; // Define a altura depois de já ter chamado o construtor anterior
        }

        public override string ToString() // Sobrescreve o método ToString padrão
        {
            return $"{Nome} tem {Altura}cm de altura";
            // Retorna uma string personalizada ao imprimir o objeto
        }
    }

    public class ConstrutorThis // Classe para executar o exemplo
    {
        public static void Executar() // Método principal do exemplo
        {
            var jujuba = new Cachorro("Jujuba");
            // Chama o construtor 1:
            // -> base(nome) chama Animal
            // -> imprime mensagem no console

            var max = new Cachorro("Soneca", 30.1);
            // Chama o construtor 2:
            // -> this(nome) chama o construtor 1
            // -> depois define Altura

            Console.WriteLine(jujuba);
            // Chama automaticamente o ToString()
            // Como Altura não foi definida, será 0

            Console.WriteLine(max);
            // Chama ToString() com altura definida
        }
    }
}