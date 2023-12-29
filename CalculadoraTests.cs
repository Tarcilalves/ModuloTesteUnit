using Calculadora.Services;
using Xunit;

namespace CalculadoraTestes;

public class CalculadoraTests
{
    //Vamos estanciar a classe calculadora AQUI!!
    private CalculadoraImp _calc;

    //Construtor
    public CalculadoraTests()
    {
        _calc = new CalculadoraImp();
    }

    [Fact]
    public void DeveSomar5Com10ERetornar15()
    {
        //Arrange - cenário
        int num1 = 5;
        int num2 = 10;

        //Act - agir | ação
        int resultado = _calc.Somar(num1, num2);

        //Assert validação do resultado
        //Equal significa a comparação de dois valores, se estivem iguais, logo está correto, senão estará incorreto.
        //Primeiro parâmetro >> resultado esperado. 
        //Segundo parâmetro o valor que retornou.
        Assert.Equal(15, resultado);
    }

    // teste para Verificação se um número é par
    [Fact]
    public void DeveVerificarSe4EhparERetornarVerdadeiro()
    {
        //Arrange - cenário
        int numero = 4;
        //Act - agir | ação
        bool resultado = _calc.EhPar(numero);
        
        //Assert validação do resultado
        Assert.True(resultado);       

    }

    [Theory]
    // recebe um array de inteiros
    [InlineData(new int[] { 2, 4 })]
    [InlineData(new int[] { 6, 4, 10 })]
    // poderia colocar tudo em um só elemento
   
    public void DeveVerificarSeOsNumerosSaoParesERetornarVerdadeiro(int[] numeros)
    {
         //Arrange - Não usamos nesse caso
        
        // VAMOS UNIR - Act - agir | ação  - Assert validação do resultado
        Assert.All(numeros, num => Assert.True(_calc.EhPar(num)));
    }

}