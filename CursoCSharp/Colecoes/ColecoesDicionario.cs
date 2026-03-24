namespace CursoCSharp.Colecoes
{
    class ColecoesDicionario
    {
        public static void Executar()
        {
            // 🗂️ Dictionary: chave ÚNICA → valor (como "indice → conteúdo")
            // Chave = int (ano), Valor = string (nome filme)
            var filmes = new Dictionary<int, string>();

            // 📥 ADICIONA 5 pares chave/valor (todas chaves únicas ✓)
            filmes.Add(2022, "Os vingadores");   // {2022 → "Os vingadores"}
            filmes.Add(2023, "Homem-Aranha");    // {2023 → "Homem-Aranha"}
            filmes.Add(2024, "The Gotam");       // {2024 → "The Gotam"}
            filmes.Add(2025, "Elementos");       // {2025 → "Elementos"}
            filmes.Add(2026, "Patrulha Canina"); // {2026 → "Patrulha Canina"}
            // Estado: 5 itens ✅

            if (filmes.ContainsKey(2023))  // VERDADEIRO! 2023 existe
            {
                // 🔥 PROBLEMA: Diz "2023" mas acessa 2026!
                Console.WriteLine("2023" + filmes[2026]);
                // filmes[2026] = "Patrulha Canina" → "2023Patrulha Canina"

                Console.WriteLine("2023" + filmes.GetValueOrDefault(2026));
                // GetValueOrDefault(2026) = "Patrulha Canina"

                Console.WriteLine(filmes.ContainsValue("Elementos"));
                // True (existe na chave 2025)

                Console.WriteLine($"Removeu? {filmes.Remove(2026)}");
                // Remove 2026 → True. Estado: 4 itens

                filmes.TryGetValue(2022, out string filmes2022);
                // filmes2022 = "Os vingadores" (seguro!)

                // 🔥 1️⃣ PRIMEIRO FOREACH: SÓ CHAVES (anos)
                foreach (var chaves in filmes.Keys)
                {
                    Console.WriteLine(chaves);
                    // Imprime: 2022, 2023, 2024, 2025
                }

                // 🔥 2️⃣ SEGUNDO FOREACH: SÓ VALORES (filmes)
                foreach (var valor in filmes.Values)
                {
                    Console.WriteLine(valor);
                    // Imprime: "Os vingadores", "Homem-Aranha", etc.
                }

                // 🔥 3️⃣ TERCEIRO FOREACH: CHAVE + VALOR (KeyValuePair)
                foreach (KeyValuePair<int, string> filme in filmes)
                {
                    // filme.Key = ano, filme.Value = nome
                    Console.WriteLine($"{filme.Value} é de {filme.Key}");
                    // "Os vingadores é de 2022"
                }
            }
        }
    }
}
