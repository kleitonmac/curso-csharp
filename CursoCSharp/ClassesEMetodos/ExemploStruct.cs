using System;                                // ✅ Importa Console, Math e funções básicas do C#

namespace CursoCSharp.ClassesEMetodos       // ✅ Namespace organizacional - 1 ÚNICA chave de abertura
{
    // 1️⃣ INTERFACE → CONTRATO DE POO (Define COMPORTAMENTO de VEÍCULO)
    public interface IVeiculo               // ✅ Interface = contrato de POO (define o QUE o veículo faz)
    {
        void Ligar();                      // ✅ MÉTODO obrigatório: toda classe que ASSUME esse contrato deve ter
        void Desligar();                   // ✅ MÉTODO obrigatório: outra parte do comportamento do veículo
        bool EstaLigado { get; }           // ✅ PROPRIEDADE só‑leitura: expõe estado interno (POO: encapsulamento)
    }

    // 2️⃣ STRUCT → TIPO POR VALOR (POO simples, mas ainda é tipo próprio)
    public struct Ponto2D                   // ✅ Struct = tipo definido por você (POO: criar seus próprios tipos)
    {
        public double X, Y;                // ✅ CAMPOS públicos: atributos do objeto Ponto2D
        public Ponto2D(double x, double y) // ✅ CONSTRUTOR: inicializa o estado do objeto (POO: inicialização)
        {
            X = x; Y = y;                  // ✅ Atribui parâmetros aos campos (estado do objeto)
        }
        public double Distancia(Ponto2D outro)  // ✅ MÉTODO: operação que o ponto faz (POO: comportamento)
        {
            return Math.Sqrt((X - outro.X) * (X - outro.X) + (Y - outro.Y) * (Y - outro.Y));  // ✅ Fórmula: √((x2-x1)² + (y2-y1)²)
        }
    }

    // 3️⃣ CLASSE → OBJETO COM ESTADO E COMPORTAMENTO (POO completa)
    public class CarroNovo : IVeiculo       // ✅ Classe = modelo de objeto (implementa uma interface → POO / contrato)
    {
        private bool ligado = false;       // ✅ CAMPO PRIVADO: ENCAPSULAMENTO (estado interno protegido)

        public void Ligar()                // ✅ MÉTODO: altera o ESTADO do objeto (POO: comportamento que muda estado)
        {
            ligado = true;                 // ✅ Muda estado interno para ligado (estado do objeto)
            Console.WriteLine("🚗 Carro LIGADO!");  // ✅ Mensagem de confirmação
        }

        public void Desligar()             // ✅ MÉTODO: outro comportamento que muda estado
        {
            ligado = false;                // ✅ Muda estado interno para desligado
            Console.WriteLine("🚗 Carro DESLIGADO!");  // ✅ Mensagem de confirmação
        }

        public bool EstaLigado => ligado;  // ✅ PROPRIEDADE: expõe estado interno (ENCAPSULAMENTO + interfaces)
    }

    // 4️⃣ CLASSE DE TESTE → USA OBJETOS E POLIMORFISMO
    class ExemploStruct                    // ✅ Classe que usa objetos (instância de Ponto2D e CarroNovo → POO)
    {
        public static void Executar()      // ✅ MÉTODO ESTÁTICO: ponto de entrada do exemplo
        {
            // 🧮 TESTE STRUCT: cria objetos Ponto2D (POO com tipos definidos por você)
            var p1 = new Ponto2D(0, 0);    // ✅ CRIA objeto Ponto2D (instância)
            var p2 = new Ponto2D(3, 4);    // ✅ CRIA outro objeto Ponto2D
            Console.WriteLine($"Distância: {p1.Distancia(p2)}");  // ✅ CHAMA método do objeto (POO: enviando mensagem)

            // 🎯 TESTE INTERFACE → POLIMORFISMO (elemento chave de POO)
            var carro = new CarroNovo();   // ✅ CRIA objeto CarroNovo (instância de classe → POO)
            carro.Ligar();                 // ✅ CHAMA método da interface (polimorfismo implícito)
            Console.WriteLine($"Está ligado? {carro.EstaLigado}");  // ✅ LÊ propriedade da interface (POO: contrato)
        }
    }
}                                          // ✅ Fecha namespace corretamente
