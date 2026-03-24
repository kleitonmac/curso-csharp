namespace CursoCSharp.ClassesEMetodos
{                    // ✅ Define o espaço de nomes organizacional - APENAS 1 chave!
    public class CarroOpicional                          // Classe "molde" para opcionais de carro
    {
        double desconto = 0.1;                         // CAMPO PRIVADO: desconto fixo de 10% (0.1)
        string nome;                                   // CAMPO PRIVADO: guarda nome real do opcional

        public string Nome                            // PROPRIEDADE PÚBLICA com GET e SET personalizados
        {
            get => "Opcional: " + nome;                // GET: sempre adiciona "Opcional: " na frente
            set => nome = value;                       // SET: guarda o valor recebido no campo privado
        }

        public double Preco { get; set; }              // AUTO-PROPRIEDADE: get/set automáticos (campo interno criado pelo C#)

        public double PrecoComDesconto => Preco - (desconto * Preco);  // PROPRIEDADE SOMENTE LEITURA: calcula desconto automático

        // ✅ Construtor padrão (sem parâmetros) - permite criar carro sem dados
        public CarroOpicional() { }                    // FAZ NADA: só existe para permitir new CarroOpicional()

        public CarroOpicional(string nome, double preco)  // CONSTRUTOR COM PARÂMETROS: inicializa com nome + preço
        {
            this.nome = nome;                          // this.nome → campo da classe | nome → parâmetro do construtor
            this.Preco = preco;                        // this.Preco → propriedade da classe | preco → parâmetro
        }
    }

    public class Props                                  // Classe de TESTE para demonstrar uso
    {
        public static void Executar()                  // MÉTODO ESTÁTICO: ponto de entrada do exemplo
        {
            var op1 = new CarroOpicional("Ar condicionado", 3499.90);  // CRIA 1º carro com construtor completo
            Console.WriteLine(op1.Nome);               // IMPRIME: "Opcional: Ar condicionado" (get personalizada)
            Console.WriteLine(op1.PrecoComDesconto);   // IMPRIME: 3149.91 (calcula 10% de desconto)

            var op2 = new CarroOpicional();            // CRIA 2º carro com construtor VAZIO ✅
            op2.Nome = "Direção Elétrica";             // SET: armazena "Direção Elétrica" no campo nome
            op2.Preco = 2349.0;                        // SET: armazena preço na auto-propriedade
            Console.WriteLine(op2.Nome);               // IMPRIME: "Opcional: Direção Elétrica"
            Console.WriteLine(op2.PrecoComDesconto);   // IMPRIME: 2114.1 (10% de desconto automático)
        }
    }
}                                                      // ✅ Fecha namespace CORRETAMENTE
