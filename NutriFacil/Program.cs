using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        Pessoa pessoa = new();

        Console.Write("Digite seu nome: ");
        pessoa.Nome = Console.ReadLine();

        pessoa.Idade = LerInteiro("Digite sua idade: ", 1, 120);
        pessoa.Peso = LerDouble("Digite seu peso (kg): ", 1, 400);
        pessoa.Altura = LerDouble("Digite sua altura (cm): ", 50, 250);

        pessoa.Sexo = LerSexo();
        pessoa.Dieta = LerDieta();
        pessoa.Objetivo = LerObjetivo();

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

    static int LerInteiro(string mensagem, int min, int max)
    {
        int valor;
        while (true)
        {
            Console.Write(mensagem);
            if (int.TryParse(Console.ReadLine(), out valor) && valor >= min && valor <= max)
                return valor;
            Console.WriteLine($"Digite um número inteiro entre {min} e {max}.");
        }
    }

    static double LerDouble(string mensagem, double min, double max)
    {
        double valor;
        while (true)
        {
            Console.Write(mensagem);
            if (double.TryParse(Console.ReadLine(), out valor) && valor >= min && valor <= max)
                return valor;
            Console.WriteLine($"Digite um número válido entre {min} e {max}.");
        }
    }

    static Sexo LerSexo()
    {
        while (true)
        {
            Console.Write("Sexo (Masculino/Feminino): ");
            string entrada = Console.ReadLine().ToLower();
            if (entrada == "masculino") return Sexo.Masculino;
            if (entrada == "feminino") return Sexo.Feminino;
            Console.WriteLine("Entrada inválida. Digite 'Masculino' ou 'Feminino'.");
        }
    }

    static TipoDieta LerDieta()
    {
        Console.WriteLine("\nSelecione sua dieta:");
        Console.WriteLine("1 - Mediterrânea");
        Console.WriteLine("2 - Low Carb");
        Console.WriteLine("3 - Cetogênica");
        Console.WriteLine("4 - Vegetariana");
        int opcao = LerInteiro("Opção: ", 1, 4);
        return (TipoDieta)(opcao - 1);
    }

    static Objetivo LerObjetivo()
    {
        Console.WriteLine("\nObjetivo:");
        Console.WriteLine("1 - Emagrecimento");
        Console.WriteLine("2 - Hipertrofia");
        int opcao = LerInteiro("Opção: ", 1, 2);
        return (Objetivo)(opcao - 1);
    }
}
