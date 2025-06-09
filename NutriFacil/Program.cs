using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        Pessoa pessoa = new();

        Console.Write("Digite seu nome: ");
        pessoa.Nome = Console.ReadLine();

        Console.Write("Digite sua idade: ");
        pessoa.Idade = int.Parse(Console.ReadLine());

        Console.Write("Digite seu peso (kg): ");
        pessoa.Peso = double.Parse(Console.ReadLine());

        Console.Write("Digite sua altura (cm): ");
        pessoa.Altura = double.Parse(Console.ReadLine());

        Console.Write("Sexo (Masculino/Feminino): ");
        string sexoInput = Console.ReadLine().ToLower();
        pessoa.Sexo = sexoInput == "masculino" ? Sexo.Masculino : Sexo.Feminino;

        Console.WriteLine("\nSelecione sua dieta:");
        Console.WriteLine("1 - Mediterrânea");
        Console.WriteLine("2 - Low Carb");
        Console.WriteLine("3 - Cetogênica");
        Console.WriteLine("4 - Vegetariana");
        int dietaOpcao = int.Parse(Console.ReadLine());
        pessoa.Dieta = (TipoDieta)(dietaOpcao - 1);

        Console.WriteLine("\nObjetivo:");
        Console.WriteLine("1 - Emagrecimento");
        Console.WriteLine("2 - Hipertrofia");
        int objetivo = int.Parse(Console.ReadLine());
        pessoa.Objetivo = (Objetivo)(objetivo - 1);

        Console.WriteLine("\nDigite suas preferências alimentares (separadas por vírgula):");
        Console.WriteLine("Opções: Proteínas, Legumes, Verduras, Carboidratos");
        string[] prefs = Console.ReadLine().Split(',');
        foreach (var p in prefs)
            pessoa.Preferencias.Add(p.Trim());

        Console.WriteLine("\nPossui alguma restrição alimentar?");
        Console.WriteLine("Opções: Lactose, Glúten, Proteína do leite, Ovo, Frutos do mar, Nenhuma");
        string[] restricoes = Console.ReadLine().Split(',');
        foreach (var r in restricoes)
        {
            string restricao = r.Trim();
            if (!restricao.Equals("Nenhuma", StringComparison.OrdinalIgnoreCase))
                pessoa.Restricoes.Add(restricao);
        }

        Console.Clear();
        Console.WriteLine($"Olá {pessoa.Nome}, aqui está seu plano personalizado:\n");

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