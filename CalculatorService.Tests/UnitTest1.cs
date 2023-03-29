namespace CalculatorService.Tests;

public class DivisaoTest
{
    private readonly CalculadoraService calc = new CalculadoraService();


    [Fact]
    public void TestarDivisaoComNaN()
    {
        // Arrange
        double a = 2.0;
        double b = double.NaN;

        // Act
        double resultado = calc.Divisao(a, b);

        // Assert
        Assert.True(double.IsNaN(resultado));
    }


    [Fact]
    public void DeveDiviDoisNumerosPositivo()
    {
        double a = 4.0;
        double b = 2.0;

        var result = calc.Divisao(a, b);
        Assert.Equal(result, 2);
    }

    [Fact]
    public void DeveDiviUmNumeroPositivoNegativo()
    {
        double a = 4.0;
        double b = -2.0;

        var result = calc.Divisao(a, b);
        Assert.Equal(result, -2);
    }

    [Fact]
    public void DeveDiviDoisNumerosNegatio()
    {
        double a = -25.0;
        double b = -5.0;

        var result = calc.Divisao(a, b);
        Assert.Equal(result, 5);
    }

    [Fact]
    public void DeveDivZero()
    {
        double a = 25.0;
        double b = 0.0;

        var result = calc.Divisao(a, b);
        Assert.Equal(result, double.PositiveInfinity);
    }



}

public class SomaTests
{
    private readonly CalculadoraService calc = new CalculadoraService();

    [Fact]
    public void TestarSomaComMaiorNumero()
    {
        int a = int.MaxValue;
        int b = 1;

        Assert.Throws<OverflowException>(() => calc.Soma(a, b));
    }

    [Fact]
    public void DeveSomarDoisNumerosPositivos()
    {
        int a = 5;
        int b = 2;

        var result = calc.Soma(a, b);

        Assert.Equal(result, 7);
    }

    [Fact]
    public void DeveSomarUmNumeroNegativoPositivo()
    {
        int a = 8;
        int b = -1;

        var result = calc.Soma(a, b);
        Assert.Equal(result, 7);
    }

    [Fact]
    public void DeveSomarDoisNumerosNegativos()
    {
        int a = -2;
        int b = -2;

        var result = calc.Soma(a, b);
        Assert.Equal(result, -4);
    }
}

public class SubtracaoTests
{
    private readonly CalculadoraService calc = new CalculadoraService();

    [Fact]
    public void DeveSubtrairDoisNumerosPositivo()
    {
        int a = 5;
        int b = 5;

        var result = calc.Subtracao(a, b);
        Assert.Equal(result, 0);
    }


    [Fact]
    public void DeveSubtrairUmNumeroPositivoNegativo()
    {
        int a = 5;
        int b = -2;

        var result = calc.Subtracao(a, b);
        Assert.Equal(result, 7);
    }


    [Fact]
    public void DeveSubtrairDoisNumerosNegativo()
    {
        int a = -5;
        int b = -2;

        var result = calc.Subtracao(a, b);
        Assert.Equal(result, -3);
    }

}

public class MultiTests
{
    private readonly CalculadoraService calc = new CalculadoraService();

    [Fact]
    public void DeveMultiDoisNumerosPositivo()
    {
        int a = 5;
        int b = 5;

        var result = calc.Multiplicacao(a, b);
        Assert.Equal(result, 25);
    }

    [Fact]
    public void DeveMultiUmNumeroPositivoNegativo()
    {
        int a = 5;
        int b = -3;

        var result = calc.Multiplicacao(a, b);
        Assert.Equal(result, -15);
    }

    [Fact]
    public void DeveMultiDoisNumerosNegatio()
    {
        int a = -5;
        int b = -5;

        var result = calc.Multiplicacao(a, b);
        Assert.Equal(result, 25);
    }

}

public class Media
{
    private readonly CalculadoraService calc = new CalculadoraService();

    [Fact]
    public void DeveMediaDoisNumerosPositivo()
    {
        int a = 5;
        int b = 5;

        var result = calc.Media(a, b);
        Assert.Equal(result, 5);
    }

    [Fact]
    public void DeveMediaUmNumeroPositivoNegativo()
    {
        int a = 5;
        int b = -3;

        var result = calc.Media(a, b);
        Assert.Equal(result, 1);
    }

    [Fact]
    public void DeveMediaTresNumeros()
    {
        double a = 6.0;
        double b = 6.0;
        double c = 6.0;

        var result = calc.Media(a, b, c);
        Assert.Equal(result, 6.0);
    }

}

public class MedianaTests
{
    private readonly CalculadoraService calc = new CalculadoraService();

    [Fact]
    public void DeveMediaConjunto()
    {
        int a = 5;
        int b = 3;
        int c = 7;
        int d = 9;

        var result = calc.Mediana(a, b, c, d);
        Assert.Equal(result, 6);
    }

}



