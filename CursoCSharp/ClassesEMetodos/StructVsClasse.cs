
namespace CursoCSharp.ClassesEMetodos
{

    // 1️⃣ STRUCT: tipo POR VALOR (value type)
    // Quando você copia um struct, COPIA DE VERDADE os dados
    public struct SPonto
    {
        public int X;
        public int Y;
    }

    // 2️⃣ CLASS: tipo POR REFERÊNCIA (reference type)
    // Quando você copia um objeto classe, você copia só a "seta" (referência),
    // não o bloco de dados em si
    public class CPonto
    {
        public int X;
        public int Y;
    }

    class StructVsClasse
    {
        public static void Executar()
        {

            // 3️⃣ CRIANDO UM STRUCT E UMA CÓPIA
            // Aqui a mágica acontece: SPonto é tipo de valor
            SPonto ponto1 = new SPonto() { X = 1, Y = 2 };
            // ponto1: na memória há um bloco com X=1 e Y=2

            SPonto copiaPonto1 = ponto1;
            // copiaPonto1: é criado um SEGUNDO bloco na memória,
            // com X=1 e Y=2, INDEPENDENTE de ponto1

            ponto1.X = 5;
            // ponto1 agora é: X=5, Y=2
            // copiaPonto1 continua: X=1, Y=2 (não é o mesmo bloco)

            // OUTPUT:
            Console.WriteLine("Ponto 1 X: {0}", ponto1.X);
            // Resulta: "Ponto 1 X: 5"
            Console.WriteLine("Copia Ponto 1 X: {0}", copiaPonto1.X);
            // Resulta: "Copia Ponto 1 X: 1"
            // --> prova de que são dois blocos diferentes na memória

        }
    }
}
