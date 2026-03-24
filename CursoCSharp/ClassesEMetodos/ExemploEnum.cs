using System;                                           // Importa Console, DateTime e funções básicas
using System.Collections.Generic;                       // Importa List, Dictionary (não usado aqui)
using System.Text;                                      // Importa StringBuilder (não usado aqui)

namespace CursoCSharp.ClassesEMetodos                   // Espaço de nomes organizacional
{
    public enum StatusPedidos
    {                           // 🔢 ENUM: Lista fixa de OPÇÕES nomeadas (começa em 0)
        Entregue,                                        // = 0 (posição 0)
        Enviado,                                         // = 1 (posição 1) 
        Pendentes                                         // = 2 (posição 2)
    };  // ✅ Ponto e vírgula fecha enum

    public class Sedex
    {                                  // Classe para representar encomendas Sedex
        public string Pedidos;                           // Campo público: nome/descritivo do pedido
        public StatusPedidos StatusPedidos;              // Campo público: usa o ENUM para status
    }

    class ExemploEnum
    {                                   // Classe de exemplo para demonstrar enum

        public static void Executar()
        {                  // MÉTODO ESTÁTICO: demonstra uso do enum
            // 🎯 CAST NUMÉRICO: converte enum para seu número interno
            int id = (int)StatusPedidos.Enviado;         // Enviado = posição 1 → id = 1
            Console.WriteLine(id);                       // IMPRIME: 1

            var entregas = new Sedex();                  // CRIA objeto Sedex
            entregas.Pedidos = "Ovo de Pascoa";          // DEFINE nome do pedido
            entregas.StatusPedidos = StatusPedidos.Entregue;  // DEFINE status usando enum
            Console.WriteLine("{0} é {1}!", entregas.Pedidos, entregas.StatusPedidos);  // IMPRIME: "Ovo de Pascoa é Entregue!"
        }
    }
}
