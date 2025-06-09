using System;
using System.Collections.Generic;

public static class CalculadoraSaude
{
    public static double CalcularTMB(Pessoa pessoa)
    {
        if (pessoa.Sexo == Sexo.Masculino)
            return 10 * pessoa.Peso + 6.25 * pessoa.Altura - 5 * pessoa.Idade + 5;
        else
            return 10 * pessoa.Peso + 6.25 * pessoa.Altura - 5 * pessoa.Idade - 161;
    }

    public static double CalcularIMC(Pessoa pessoa)
    {
        double alturaMetros = pessoa.Altura / 100;
        return pessoa.Peso / (alturaMetros * alturaMetros);
    }

    public static double CalcularConsumoAgua(Pessoa pessoa)
    {
        return pessoa.Peso * 35; 
    }

    public static string ClassificarIMC(double imc)
    {
        if (imc < 18.5) return "Abaixo do peso";
        else if (imc < 25) return "Peso normal";
        else if (imc < 30) return "Sobrepeso";
        else return "Obesidade";
    }
}