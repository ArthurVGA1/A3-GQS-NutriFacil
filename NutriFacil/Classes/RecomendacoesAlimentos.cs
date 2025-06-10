using System;
using System.Collections.Generic;

public static class RecomendacoesAlimentos
{
    public static void ExibirRecomendacoes(TipoDieta dieta)
    {
        Console.WriteLine("🔍 Recomendações Nutricionais Personalizadas:");
        Console.WriteLine($"Dieta selecionada: {dieta}\n");

        switch (dieta)
        {
            case TipoDieta.Mediterranea:
                ExibirDetalhes(
                    "Azeite de oliva, peixes, grãos integrais, legumes e frutas.",
                    new Dictionary<string, List<string>> {
                        { "Proteínas", new() { "Peixe", "Frango", "Iogurte grego" } },
                        { "Legumes", new() { "Abobrinha", "Berinjela", "Cenoura" } },
                        { "Verduras", new() { "Alface", "Espinafre", "Rúcula" } },
                        { "Carboidratos", new() { "Arroz integral", "Grão-de-bico", "Pão integral" } }
                    },
                    2000
                );
                break;

            case TipoDieta.LowCarb:
                ExibirDetalhes(
                    "Redução de carboidratos, foco em proteínas e gorduras boas.",
                    new Dictionary<string, List<string>> {
                        { "Proteínas", new() { "Carne magra", "Frango", "Ovos" } },
                        { "Legumes", new() { "Abobrinha", "Brócolis", "Couve-flor" } },
                        { "Verduras", new() { "Alface", "Agrião", "Espinafre" } },
                        { "Gorduras boas", new() { "Abacate", "Azeite de oliva", "Castanhas" } }
                    },
                    1800
                );
                break;

            case TipoDieta.Cetogenica:
                ExibirDetalhes(
                    "Muito baixa em carboidratos, rica em gordura. Foco em cetose.",
                    new Dictionary<string, List<string>> {
                        { "Gorduras boas", new() { "Óleo de coco", "Azeite", "Abacate" } },
                        { "Proteínas moderadas", new() { "Frango", "Peixe", "Ovos" } },
                        { "Legumes", new() { "Couve-flor", "Abobrinha", "Espinafre" } }
                    },
                    1600
                );
                break;

            case TipoDieta.Vegetariana:
                ExibirDetalhes(
                    "Sem carnes, inclui vegetais, grãos, ovos e laticínios.",
                    new Dictionary<string, List<string>> {
                        { "Proteínas", new() { "Ovos", "Tofu", "Lentilha" } },
                        { "Legumes", new() { "Beterraba", "Cenoura", "Abóbora" } },
                        { "Verduras", new() { "Couve", "Espinafre", "Rúcula" } },
                        { "Carboidratos", new() { "Arroz integral", "Quinoa", "Batata-doce" } }
                    },
                    1900
                );
                break;
        }
    }

    private static void ExibirDetalhes(string descricao, Dictionary<string, List<string>> grupos, int caloriasMedia)
    {
        Console.WriteLine($"📝 Descrição: {descricao}");
        Console.WriteLine($"🔥 Calorias diárias médias recomendadas: ~{caloriasMedia} kcal");

        foreach (var grupo in grupos)
        {
            Console.WriteLine($"\n🍽 {grupo.Key}:");
            foreach (var alimento in grupo.Value)
            {
                Console.WriteLine($"  - {alimento}");
            }
        }

        Console.WriteLine("\n📌 Dica: Consuma de forma equilibrada. Beba bastante água e adapte conforme seu objetivo e restrições!");
    }
}
