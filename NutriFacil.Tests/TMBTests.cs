
using Xunit;
using NutriFacil.Classes;

namespace NutriFacil.Tests
{
    public class TMBTests
    {
        [Fact]
        public void CalcularTMB_DeveRetornarValorEsperadoParaMasculino()
        {
            var pessoa = new Pessoa
            {
                Peso = 70,
                Altura = 175,
                Idade = 30,
                Sexo = "Masculino"
            };

            double tmb = CalculadoraSaude.CalcularTMB(pessoa);

            Assert.InRange(tmb, 1600, 1700);
        }
    }
}
