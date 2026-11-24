using NewTalents;

namespace NewTalentsTest;

public class CalculadoraTeste
{
    public Calculadora Inicializar()
    {
        Calculadora calculadora = new Calculadora();
        return calculadora;
    }

    [Theory]
    [InlineData(10, 5, 15)]
    [InlineData(10, -5, 5)]
    [InlineData(-10, -5, -15)]
    public void TesteDeSoma(int num1, int num2, int resultadoE)
    {
        Calculadora calc = Inicializar();
        var resultado = calc.Soma(num1, num2);

        Assert.Equal(resultadoE, resultado);
    }

    [Theory]
    [InlineData(10, 5, 5)]
    [InlineData(10, -5, 15)]
    [InlineData(-10, -5, -5)]
    public void TesteDeSubritracao(int num1, int num2, int resultadoE)
    {
        Calculadora calc = Inicializar();

        var resultado = calc.Subtracao(num1, num2);

        Assert.Equal(resultadoE, resultado);
    }

    [Theory]
    [InlineData(10, 5, 50)]
    [InlineData(10, -5, -50)]
    [InlineData(-4, -5, 20)]
    public void TesteDeMultiplicacao(int num1, int num2, int resultadoE)
    {
        Calculadora calc = Inicializar();

        var resultado = calc.Multiplicacao(num1, num2);

        Assert.Equal(resultadoE, resultado);
    }

    [Theory]
    [InlineData(10, 2, 5)]
    [InlineData(0, 3, 0)]
    public void TesteDeDivisao(int num1, int num2, int resultadoE)
    {
        Calculadora calc = Inicializar();

        var resultado = calc.Divisao(num1, num2);

        Assert.Equal(resultadoE, resultado);
    }

    [Fact]
    public void TesteDevisaoPorZero()
    {
        Calculadora calc = Inicializar();

        Assert.Throws<DivideByZeroException>(() => calc.Divisao(3, 0));
    }

    [Fact]
    public void TesteHistorico()
    {
        Calculadora calc = Inicializar();

        calc.Divisao(2, 2);
        calc.Subtracao(2, 3);
        calc.Multiplicacao(2, 4);
        calc.Soma(2, 5);

        var lista = calc.Historico();

        Assert.NotEmpty(lista);
        Assert.Equal(3, lista.Count());
    }
}
