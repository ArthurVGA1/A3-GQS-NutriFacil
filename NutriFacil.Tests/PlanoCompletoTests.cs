
using Xunit;
using NutriFacil.Classes;

namespace NutriFacil.Tests
{
    public class PlanoCompletoTests
    {
        [Fact]
        public void PlanoCompleto_DeveGerarRefeicoesParaPerfil()
        {
            var pessoa = new Pessoa
            {
                Peso = 60,
                Altura = 160,
                Idade = 25,
                Sexo = "Feminino"
            };

            string plano = RecomendacoesAlimentos.GerarRecomendacoes("Vegetariana");

            Assert.Contains("legumes", plano.ToLower());
        }
    }
}
