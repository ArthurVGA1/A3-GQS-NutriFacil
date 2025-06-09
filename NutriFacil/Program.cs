using System;
using System.Collections.Generic;

public class Programa
{
    public static void Main()
    {
        Pessoa pessoa = new()
        {
            Nome = "Arthur",
            Idade = 25,
            Peso = 75,
            Altura = 178,
            Sexo = Sexo.Masculino,
            Dieta = TipoDieta.Mediterranea,
            Objetivo = Objetivo.Hipertrofia,
            Preferencias = new List<string> { "Proteínas", "Legumes" },
            Restricoes = new List<string> { "Glúten" }
        };

        Console.WriteLine($"Olá {pessoa.Nome}, aqui está seu plano personalizado:");
        double tmb = CalculadoraSaude.CalcularTMB(pessoa);
        double imc = CalculadoraSaude.CalcularIMC(pessoa);
        double agua = CalculadoraSaude.CalcularConsumoAgua(pessoa);
        string classIMC = CalculadoraSaude.ClassificarIMC(imc);

        Console.WriteLine($"TMB: {tmb:F2} kcal/dia");
        Console.WriteLine($"IMC: {imc:F2} - {classIMC}");
        Console.WriteLine($"Consumo diário de água: {agua / 1000:F2} litros");

        Console.WriteLine("\nRestrições alimentares:");
        Console.WriteLine(pessoa.Restricoes.Count == 0 ? "Nenhuma" : string.Join(", ", pessoa.Restricoes));

        Console.WriteLine("\nPreferências:");
        Console.WriteLine(string.Join(", ", pessoa.Preferencias));

        Console.WriteLine();
        RecomendacoesAlimentos.ExibirRecomendacoes(pessoa.Dieta);
    }
}
