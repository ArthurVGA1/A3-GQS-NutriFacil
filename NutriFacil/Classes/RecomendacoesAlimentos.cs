using System;
using System.Collections.Generic;

public static class RecomendacoesAlimentos
{
    public static void ExibirRecomendacoes(TipoDieta dieta)
    {
        Console.WriteLine("Recomendações para a dieta " + dieta + ":");

        switch (dieta)
        {
            case TipoDieta.Mediterranea:
                Console.WriteLine("Azeite de oliva, peixes, grãos integrais, legumes e frutas.");
                break;
            case TipoDieta.LowCarb:
                Console.WriteLine("Proteínas magras, gorduras boas, vegetais de baixo amido.");
                break;
            case TipoDieta.Cetogenica:
                Console.WriteLine("Alta gordura, proteína moderada, quase nada de carboidrato.");
                break;
            case TipoDieta.Vegetariana:
                Console.WriteLine("Legumes, ovos, laticínios, vegetais, grãos.");
                break;
        }
    }
}
