namespace CursoCSharp.ClassesEMetodos
{
    class DesafioAtributo
    {
        int a = 10; // A variável 'a' é um atributo da classe 'DesafioAtributo' e é inicializada com o valor 10.

        public static void Executar()
        {
            DesafioAtributo desafio = new DesafioAtributo(); // Criamos uma instância da classe 'DesafioAtributo' para acessar o atributo 'a', que é um membro de instância.
            Console.WriteLine("Resultado do Desafio {0}" ,desafio.a); // Imprime o valor do atributo 'a' da instância 'desafio' na tela. O resultado será "Resultado do Desafio 10" porque 'a' foi inicializada com o valor 10.
        }

        
        }
    }
