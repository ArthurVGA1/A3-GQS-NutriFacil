
using Xunit;
using NutriFacil.Classes;

namespace NutriFacil.Tests
{
    public class CalculadoraSaudeTests
    {
        [Fact]
        public void CalcularIMC_DeveRetornarValorCorreto()
        {
            double peso = 70.0;
            double altura = 1.75;

            double imc = CalculadoraSaude.CalcularIMC(peso, altura);

            Assert.Equal(22.86, imc, 2);
        }
    }
}
