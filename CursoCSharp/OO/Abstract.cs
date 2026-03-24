using System;
using System.Collections.Generic;

namespace CursoCSharp.OO
{
    // Classe abstrata: não pode ser instanciada diretamente (new Celular() é proibido).
    // Ela serve como "modelo" para outros celulares (Samsung, Iphone, etc.).
    public abstract class Celular
    {
        // Método abstrato: só define a assinatura, não a implementação.
        // Toda classe filha (que herda de Celular) é OBRIGADA a implementar esse método.
        public abstract string Assistente();

        // Método concreto: já tem implementação aqui na classe base.
        // Todas as classes que herdam de Celular podem usar esse comportamento padrão.
        public string Tocar()
        {
            return "Trim Trim";
        }
    }

    // Samsung herda de Celular, ou seja: Samsung É-UM Celular.
    public class Samsung : Celular
    {
        // Obrigatório sobrescrever o método abstrato Assistente().
        // Aqui definimos o comportamento específico de uma Samsung.
        public override string Assistente()
        {
            return "Olá meu nome é Bixby";
        }
    }

    // Iphone também herda de Celular: é outro tipo de celular, mas com comportamento diferente.
    public class Iphone : Celular
    {
        // Implementamos o Assistente específico do iPhone.
        public override string Assistente()
        {
            return "Olá meu nome é Siri";
        }
    }

    // Classe de teste que demonstra o uso de classe abstrata e polimorfismo.
    public class Abstract
    {
        public static void Executar()
        {
            // Criamos uma lista de objetos do tipo Celular (classe abstrata).
            // Essa lista pode conter qualquer celular que implemente Celular.
            var celulares = new List<Celular>
            {
                new Iphone(),
                new Samsung()
            };

            // Polimorfismo em ação:
            // A variável 'celular' é do tipo Celular, mas em tempo de execução
            // é Samsung ou Iphone. O método correto (Assistente) é chamado automaticamente.
            foreach (var celular in celulares)
            {
                Console.WriteLine(celular.Assistente());
            }
        }
    }
}
