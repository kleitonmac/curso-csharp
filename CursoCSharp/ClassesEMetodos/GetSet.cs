using System;                                           // Importa Console, DateTime e funções básicas do C#
using System.Collections.Generic;                       // Importa List, Dictionary (não usado aqui)
using System.Text;                                      // Importa StringBuilder (não usado aqui)

namespace CursoCSharp.ClassesEMetodos                   // Espaço de nomes organizacional do projeto
{
    public class Moto                                   // Classe "molde" para criar motos
    {
        private string Marca;                           // CAMPO PRIVADO: só acessível DENTRO da classe
        private string Modelo;                          // CAMPO PRIVADO: guarda modelo da moto
        private int Cilindrada;                         // CAMPO PRIVADO: cilindrada em cc

        public Moto(string marca, string modelo, int cilindrada)
        {  // CONSTRUTOR COMPLETO: cria moto com dados
            Marca = marca;                             // Copia parâmetro para campo privado
            Modelo = modelo;                           // Copia parâmetro para campo privado  
            Cilindrada = cilindrada;                   // Copia parâmetro para campo privado
        }

        public Moto() { }                              // CONSTRUTOR VAZIO: permite criar moto sem dados iniciais

        // 🔍 GETTERS: métodos para LER valores dos campos privados
        public string GetMarca() { return Marca; }     // Lê e devolve a marca
        public string GetModelo() { return Modelo; }   // Lê e devolve o modelo
        public int GetCilindrada() { return Cilindrada; }  // Lê e devolve cilindrada

        // ✏️ SETTERS: métodos para ALTERAR valores dos campos privados
        public void SetMarca(string marca) { Marca = marca; }      // Muda a marca
        public void SetModelo(string modelo) { Modelo = modelo; }  // Muda o modelo
        public void SetKm(int cilindrada) { Cilindrada = cilindrada; }  // ❌ BUG: nome do método enganoso!
    }

    class GetSet                                         // Classe de exemplo para TESTAR
    {
        public static void Executar()
        {                     // MÉTODO ESTÁTICO: demonstra uso da classe Moto
            var moto1 = new Moto("Kawasaki", "Ninja ZX-6R", 636);  // CRIA moto esportiva
            Console.WriteLine(moto1.GetCilindrada());      // IMPRIME: 636
            Console.WriteLine(moto1.GetModelo());          // IMPRIME: Ninja ZX-6R
            Console.WriteLine(moto1.GetMarca());           // IMPRIME: Kawasaki
            Console.WriteLine("exercicio de getters e setters", moto1);  // ❌ BUG: Console.WriteLine não aceita 2 parâmetros assim!

            var moto2 = new Moto("Honda", "Bis", 150);       // CRIA moto popular
            Console.WriteLine(moto2.GetCilindrada());      // IMPRIME: 150
            Console.WriteLine(moto2.GetModelo());          // IMPRIME: Bis
            Console.WriteLine(moto2.GetMarca());           // IMPRIME: Honda
        }
    }
}
