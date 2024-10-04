using Xunit;

namespace atividade_imc_xunit
{
    public class UnitTest1
    {
        [Fact]
        public void Teste_Calculo_IMC()
        {
            double imc_previsto = 31.25;
            IMC i = new IMC();
            i.peso = 80;
            i.altura = 1.60;
            i.Calcular_IMC();
            Assert.Equal(imc_previsto, i.imc);
        }

        [Theory]
        [InlineData(17, "Abaixo do peso")]
        [InlineData(22, "Peso normal")]
        [InlineData(27, "Sobrepeso")]
        [InlineData(32, "Obesidade Grau I")]
        [InlineData(37, "Obesidade Grau II")]
        [InlineData(42, "Obesidade Grau III")]
        public void Teste_Categoria_IMC(double imc, string categoriaEsperada)
        {
            IMC i = new IMC();
            i.peso = 80; // Valor qualquer apenas para manter a estrutura
            i.altura = 1.60; // Valor qualquer apenas para manter a estrutura
            i.imc = imc;
            i.Classificar_IMC();
            Assert.Equal(categoriaEsperada, i.categoria);
        }
    }
}
