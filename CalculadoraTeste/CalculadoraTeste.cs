namespace CalculadoraTeste;

public class UnitTest1
{
    Programa.Calculadora calculadora = new Programa.Calculadora();
    [Fact]
    public void TesteSoma()
    {
        double result;

        result = calculadora.Somar(1, 2);
        Assert.Equal(3, result);

        result = calculadora.Somar(-1, 1);
        Assert.Equal(0, result);

        result = calculadora.Somar(1.1, 1);
        Assert.Equal(2.1, result);

        result = calculadora.Somar(0, 1);
        Assert.Equal(1, result);

        result = calculadora.Somar(1, -2);
        Assert.Equal(-1, result);
    }

    [Fact]
    public void TesteSubtracao()
    {
        double result;

        result = calculadora.Subtrair(5, -3);
        Assert.Equal(8.0, result);

        result = calculadora.Subtrair(-5, 2.5);
        Assert.Equal(-7.5, result);

        result = calculadora.Subtrair(10, 10);
        Assert.Equal(0.0, result);

        result = calculadora.Subtrair(26, 0);
        Assert.Equal(26, result);

        result = calculadora.Subtrair(0, 15);
        Assert.Equal(-15, result);
    }

    [Fact]
    public void TesteMultiplicacao()
    {
        double result;

        result = calculadora.Multiplicar(5, 3);
        Assert.Equal(15, result);

        result = calculadora.Multiplicar(-5, 2.5);
        Assert.Equal(-12.5, result);

        result = calculadora.Multiplicar(10, 10);
        Assert.Equal(100, result);

        result = calculadora.Multiplicar(10, 0);
        Assert.Equal(0, result);

        result = calculadora.Multiplicar(0, -7);
        Assert.Equal(0, result);
    }
    
    [Fact]
    public void TesteDivisao()
    {
        double result;

        result = calculadora.Divisao(2, 2);
        Assert.Equal(1, result);

        result = calculadora.Divisao(-2, 2);
        Assert.Equal(-1, result);

        result = calculadora.Divisao(2.2, 2);
        Assert.Equal(1.1, result);

        result = calculadora.Divisao(0, 2);
        Assert.Equal(0, result);
        
        result = calculadora.Divisao(2, 0);
        Assert.Equal(double.NaN, result);
    }
}