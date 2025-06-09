using System;
using System.Collections.Generic;

public enum Sexo { Masculino, Feminino }
public enum TipoDieta { Mediterranea, LowCarb, Cetogenica, Vegetariana }
public enum Objetivo { Emagrecimento, Hipertrofia }

public class Pessoa
{
    public string Nome { get; set; }
    public int Idade { get; set; }
    public double Peso { get; set; } 
    public double Altura { get; set; } 
    public Sexo Sexo { get; set; }
    public TipoDieta Dieta { get; set; }
    public Objetivo Objetivo { get; set; }
    public List<string> Preferencias { get; set; } = new();
    public List<string> Restricoes { get; set; } = new();
}