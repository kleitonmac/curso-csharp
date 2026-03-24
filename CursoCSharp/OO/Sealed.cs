using System;

namespace CursoCSharp.OO
{
    // sealed = não pode ser herdada
    sealed class BancoSeguro
    {
        public string NomeCliente { get; set; }
        private double saldo;

        public BancoSeguro(string nomeCliente, double saldoInicial)
        {
            NomeCliente = nomeCliente;
            saldo = saldoInicial;
        }

        public double ObterSaldo()
        {
            return saldo;
        }

        public void Depositar(double valor)
        {
            if (valor > 0)
                saldo += valor;
        }

        public void Sacar(double valor)
        {
            if (valor > 0 && valor <= saldo)
                saldo -= valor;
        }
    }

    class Sealed
    {
        public static void Executar()
        {
            var banco = new BancoSeguro("Kleiton", 3_000.00);
            

            banco.Depositar(1_500.00);
            banco.Sacar(950.00);

            
            Console.WriteLine("=== Banco Seguro (sealed) ===");
            Console.WriteLine($"Cliente: {banco.NomeCliente}");
            Console.WriteLine($"Saldo final: R${banco.ObterSaldo():F2}");
            Console.WriteLine();

            var banco2 = new BancoSeguro("Alana", 5_000.00);
            banco2.Depositar(7_000.00);
            banco2.Sacar(3_000.00);
            Console.WriteLine($"Cliente: {banco2.NomeCliente}");
            Console.WriteLine($"Saldo Final R${banco2.ObterSaldo()}");
        }
    }
}
