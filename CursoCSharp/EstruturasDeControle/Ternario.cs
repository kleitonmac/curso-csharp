//using System;

//namespace CursoCSharp.EstruturasDeControle
//{
//    /// <summary>
//    /// CLASSE DE ESTUDOS: Operadores Ternários (? :) e Null-Coalescing (??)
//    /// Demonstra todos os usos práticos com exemplos didáticos
//    /// </summary>
//    class Ternario
//    {
//        /// <summary>
//        /// MÉTODO PRINCIPAL - Executa todos os exemplos sequencialmente
//        /// Chame este método no Main() do seu projeto
//        /// </summary>
//        public static void Executar()
//        {
//            Console.WriteLine("=== ESTUDOS - OPERADORES TERNÁRIOS ===\n");

//            // ✅ EXECUTA TODOS OS EXEMPLOS NUMERADOS
//            PontosChave();      // 1-5: Conceitos fundamentais
//            ExemploBasico();    // 6: Sintaxe simples
//            ComparacaoIfElse(); // 7: if/else X ternário
//            ExemploAninhado();  // 8: Múltiplas condições
//            ExemploString();    // 9: Strings dinâmicas
//            ExemploCalculo();   // 10: Matemática prática
//            ExemploNullCoalescing(); // 11: Null safety
//        }

//        /// <summary>
//        /// 1-5. PONTOS-CHAVE: Regras essenciais para usar ternários corretamente
//        /// Cada exemplo demonstra UMA REGRA IMPORTANTÍSSIMA
//        /// </summary>
//        static void PontosChave()
//        {
//            Console.WriteLine("📚 PONTOS-CHAVE PARA ESTUDO\n");

//            // ═══════════════════════════════════════════════════════════════
//            // 1️⃣ REGRA #1: ? : = "SE VERDADEIRO, SENÃO"
//            // Sintaxe: condição ? "sim" : "não"
//            Console.WriteLine("1. ? : = \"SE VERDADEIRO, SENÃO\"");
//            bool chovendo = false;
//            // Lê-se: "Se chovendo? Ficar em casa : Sair para passear"
//            string planejar = chovendo ? "Ficar em casa" : "Sair para passear";
//            Console.WriteLine($"Chovendo? {chovendo} → {planejar}\n");

//            // ═══════════════════════════════════════════════════════════════
//            // 2️⃣ REGRA #2: 1 LINHA = 4 LINHAS DE IF/ELSE
//            // Ternário economiza código SEM perder clareza
//            Console.WriteLine("2. 1 LINHA = 3-4 LINHAS IF/ELSE");
//            int idade = 16;

//            Console.WriteLine("   IF/ELSE (4 linhas):");
//            // ❌ TRADICIONAL: 4 linhas para algo simples
//            string acesso1;
//            if (idade >= 18)
//            {
//                acesso1 = "LIBERADO";
//            }
//            else
//            {
//                acesso1 = "BLOQUEADO";
//            }
//            Console.WriteLine($"   Idade {idade}: {acesso1}");

//            Console.WriteLine("   TERNÁRIO (1 linha):");
//            // ✅ TERNÁRIO: Mesma lógica em 1 linha
//            string acesso2 = idade >= 18 ? "LIBERADO" : "BLOQUEADO";
//            Console.WriteLine($"   Idade {idade}: {acesso2}\n");

//            // ═══════════════════════════════════════════════════════════════
//            // 3️⃣ REGRA #3: ANINHAR MÁXIMO 2-3 NÍVEIS
//            // Mais que isso = código ilegível
//            Console.WriteLine("3. ANINHAR (MÁX 2-3 NÍVEIS)");
//            int nivel = 7;
//            // ✅ CORRETO: 2 níveis = legível
//            string dificuldade = (nivel <= 3) ? "FÁCIL" :
//                                (nivel <= 7) ? "MÉDIO" : "DIFÍCIL";
//            Console.WriteLine($"Nível {nivel}: {dificuldade} ✓\n");

//            // ═══════════════════════════════════════════════════════════════
//            // 4️⃣ REGRA #4: ?? = "SE NULL, USE PADRÃO"
//            // Proteção contra valores nulos
//            Console.WriteLine("4. ?? = \"SE NULL, USE ESTE VALOR\"");
//            string? email = null; // Simula dado ausente do banco
//            // Lê-se: "email OU, se null, email@nao.informado"
//            string emailMostrar = email ?? "email@nao.informado";
//            Console.WriteLine($"Email: '{email ?? "NULL"}' → Mostrar: '{emailMostrar}'\n");

//            // ═══════════════════════════════════════════════════════════════
//            // 5️⃣ REGRA #5: LEGIBILIDADE > ECONOMIA
//            // Se fica confuso, use switch/if
//            Console.WriteLine("5. LEGIBILIDADE > ECONOMIA");
//            int complexidade = 42;

//            // ❌ NUNCA FAÇA ISSO EM PRODUÇÃO
//            string ruim = complexidade > 10 ? complexidade > 20 ? complexidade > 30 ? "Alta" : "Média" : "Baixa" : "Trivial";

//            // ✅ SEMPRE PREFIRA ISSO
//            string bom = complexidade switch
//            {
//                <= 10 => "Trivial",  // C# 8+ switch expression
//                <= 25 => "Baixa",
//                <= 40 => "Média",
//                _ => "Alta"
//            };

//            Console.WriteLine($"Ternário ruim: {ruim}");
//            Console.WriteLine($"✅ Melhor forma: {bom}\n");
//        }

//        /// <summary>
//        /// 6️⃣ SINTAXE BÁSICA - Par ou ímpar
//        /// Exemplo mais simples possível
//        /// </summary>
//        static void ExemploBasico()
//        {
//            Console.WriteLine("6. SINTAXE BÁSICA");
//            int numero = 7;
//            // (condição) ? verdadeiro : falso
//            string resultado = (numero % 2 == 0) ? "PAR" : "ÍMPAR";
//            Console.WriteLine($"7 % 2 = {resultado}\n");
//        }

//        /// <summary>
//        /// 7️⃣ COMPARAÇÃO VISUAL: if/else X ternário
//        /// Hora do dia com duas abordagens
//        /// </summary>
//        static void ComparacaoIfElse()
//        {
//            Console.WriteLine("7. IF/ELSE vs TERNÁRIO");
//            int hora = DateTime.Now.Hour;

//            Console.WriteLine("   IF/ELSE tradicional:");
//            // 3 linhas para algo simples
//            string saudacao1;
//            if (hora < 12)
//                saudacao1 = "BOM DIA!";
//            else
//                saudacao1 = "BOA TARDE!";
//            Console.WriteLine($"   Hora {hora}h: {saudacao1}");

//            Console.WriteLine("   TERNÁRIO (1 linha):");
//            // 1 linha faz o mesmo!
//            string saudacao2 = hora < 12 ? "BOM DIA!" : "BOA TARDE!";
//            Console.WriteLine($"   Hora {hora}h: {saudacao2}\n");
//        }

//        /// <summary>
//        /// 8️⃣ ANINHAMENTO PRÁTICO - Sistema de notas
//        /// 4 condições em 1 linha (limite recomendado)
//        /// </summary>
//        static void ExemploAninhado()
//        {
//            Console.WriteLine("8. ANINHAMENTO");
//            int nota = 85;
//            // Avaliação escolar completa
//            string conceito = nota >= 90 ? "A - EXCELENTE" :
//                             nota >= 70 ? "B - BOM" :
//                             nota >= 50 ? "C - REGULAR" : "D - REPROVADO";
//            Console.WriteLine($"Nota {nota}: {conceito}\n");
//        }

//        /// <summary>
//        /// 9️⃣ STRINGS DINÂMICAS - Nome do usuário
//        /// Interpolação + ternário
//        /// </summary>
//        static void ExemploString()
//        {
//            Console.WriteLine("9. COM STRINGS");
//            string nome = "Kleiton";
//            // Verifica tamanho do nome
//            bool nomeLongo = nome.Length > 6;
//            string mensagem = nomeLongo ? $"{nome} (nome longo)" : $"{nome} (nome curto)";
//            Console.WriteLine($"\"{nome}\" → {mensagem}\n");
//        }

//        /// <summary>
//        /// 🔟 CÁLCULOS MATEMÁTICOS - Desconto progressivo
//        /// Ternário em operações financeiras
//        /// </summary>
//        static void ExemploCalculo()
//        {
//            Console.WriteLine("10. CÁLCULOS");
//            double preco = 150.50;
//            // Desconto de 10% para compras > R$100
//            double desconto = preco > 100 ? preco * 0.10 : 0;
//            Console.WriteLine($"Preço R${preco:F2} → Desconto: R${desconto:F2}");
//            Console.WriteLine($"Total: R${preco - desconto:F2}\n");
//        }

//        /// <summary>
//        /// 1️⃣1️⃣ NULL-SAFETY - Proteção contra null
//        /// Essencial em APIs e bancos de dados
//        /// </summary>
//        static void ExemploNullCoalescing()
//        {
//        {
//            Console.WriteLine("11. NULL-COALESCING (??)");
//            string? nomeUsuario = null; // Dados ausentes
//            // ?? = "se null, use o próximo valor"
//            string nomeExibicao = nomeUsuario ?? "Visitante Anônimo";
//            Console.WriteLine($"nomeUsuario = {(nomeUsuario == null ? "NULL" : nomeUsuario)}");
//            Console.WriteLine($"✅ Exibir: \"{nomeExibicao}\"");
//        }
//    }
//}
