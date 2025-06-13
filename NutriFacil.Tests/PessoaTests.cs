
using Xunit;
using NutriFacil.Classes;

namespace NutriFacil.Tests
{
    public class PessoaTests
    {
        [Fact]
        public void CriarPessoa_ComPesoNegativo_DeveFalhar()
        {
            var pessoa = new Pessoa();

            Assert.Throws<System.ArgumentException>(() => pessoa.Peso = -50);
        }
    }
}
