using System;

namespace CursoCSharp.OO
{
    // Classe que representa Feijão
    public class Feijao
    {
        public double Peso; // Peso do feijão
    }

    // Classe que representa Arroz
    public class Arroz
    {
        public double Peso; // Peso do arroz
    }

    // Classe que representa Carne
    public class Carne
    {
        public double Peso; // Peso da carne
    }

    public class Pessoa
    {
        public double Peso; // Peso da pessoa

        // Método Comer para Arroz
        public void Comer(Arroz arroz)
        {
            Peso += arroz.Peso;
        }

        // Método Comer para Feijão
        public void Comer(Feijao feijao)
        {
            Peso += feijao.Peso;
        }

        // Método Comer para Carne
        public void Comer(Carne carne)
        {
            Peso += carne.Peso;
        }

        /*
         * 🔥 POLIMORFISMO ACONTECE AQUI 🔥
         * 
         * Temos vários métodos com o mesmo nome: "Comer"
         * Porém, cada um recebe um tipo diferente (Arroz, Feijao, Carne).
         * 
         * Isso é chamado de:
         * 👉 POLIMORFISMO DE SOBRECARGA (Overload)
         * 
         * Ou seja:
         * "Muitas formas de executar o mesmo método"
         */
    }

    class Polimorfismo
    {
        public static void Executar()
        {
            // Criando os alimentos
            var ingrediente1 = new Feijao();
            ingrediente1.Peso = 0.3;

            var ingrediente2 = new Arroz();
            ingrediente2.Peso = 0.35;

            var ingrediente3 = new Carne();
            ingrediente3.Peso = 0.50;

            // Criando a pessoa
            var cliente = new Pessoa();
            cliente.Peso = 90.2;

            /*
             * Aqui o C# decide qual método "Comer" chamar
             * baseado no tipo do objeto passado.
             * 
             * Isso é POLIMORFISMO em ação!
             */

            cliente.Comer(ingrediente1); // chama Comer(Feijao)
            cliente.Comer(ingrediente2); // chama Comer(Arroz)
            cliente.Comer(ingrediente3); // chama Comer(Carne)

            // Resultado final
            Console.WriteLine($"Peso total: {cliente.Peso} kg");

            Console.ReadKey(); // pausa o console
        }
    }
}