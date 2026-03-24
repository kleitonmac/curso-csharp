using System;

namespace CursoCSharp.ClassesEMetodos // Namespace para organizar as classes do projeto
{
    class Carro
    {
        // Classe que representa um carro (molde para criar objetos)
        public string Modelo;      // Atributo que guarda o modelo do carro
        public string Fabricante;  // Atributo que guarda o fabricante do carro
        public int Ano;            // Atributo que guarda o ano do carro

        // Construtor com parâmetros
        public Carro(string modelo, string fabricante, int ano)
        {
            Modelo = modelo;
            Fabricante = fabricante;
            Ano = ano;
        }

        // Construtor vazio que permite criar um carro sem passar dados
        public Carro()
        {
            // Valores padrão opcionais
            Modelo = "Desconhecido";
            Fabricante = "Desconhecido";
            Ano = 0;
        }
    }

    class Construtores
    {
        public static void Executar()
        {
            // Cria um objeto carro usando o construtor vazio
            var carro1 = new Carro();
            carro1.Fabricante = "Hyundai";
            carro1.Modelo = "Creta";
            carro1.Ano = 2026;

            Console.WriteLine($"O modelo do carro é {carro1.Modelo}, seu ano é {carro1.Ano}, e o fabricante é {carro1.Fabricante}");

            // Cria um carro usando o construtor com parâmetros
            var carro2 = new Carro("Ka", "Ford", 2018);
            Console.WriteLine($"Nome do meu carro: {carro2.Fabricante}, Ano: {carro2.Ano}, Modelo: {carro2.Modelo}");

            // Mantém o console aberto
            Console.WriteLine("Pressione ENTER para sair...");
            Console.ReadLine();
        }
    }
}