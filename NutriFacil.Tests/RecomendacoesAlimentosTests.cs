
using Xunit;
using NutriFacil.Classes;

namespace NutriFacil.Tests
{
    public class RecomendacoesAlimentosTests
    {
        [Fact]
        public void Recomendacoes_Mediterranea_DeveConterAzeiteEPeixe()
        {
            string dieta = "Mediterrânea";
            string recomendacoes = RecomendacoesAlimentos.GerarRecomendacoes(dieta);

            Assert.Contains("azeite", recomendacoes.ToLower());
            Assert.Contains("peixe", recomendacoes.ToLower());
        }
    }
}
