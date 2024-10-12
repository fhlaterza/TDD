using System;
using System.Diagnostics;
using Xunit;
using TddProject;
using System.ComponentModel.DataAnnotations;
using Microsoft.VisualBasic;

namespace TddTests;

public class UnitTest1
{
    public Calculadora construirClasse()
    {
        string data =  DateAndTime.Now.ToString();
        Calculadora calc = new Calculadora(data);
        return calc;
    }
    
    [Theory]
    [InlineData (1, 2, 3)]
    [InlineData (4, 5, 9)]
    public void TesteSomar(int val1,  int val2, int resultado)
    {
        Calculadora calc = construirClasse();

        int resultadoTest = calc.somar(val1,val2);

        Assert.Equal(resultado, resultadoTest);
    }

    [Theory]
    [InlineData (5, 2, 3)]
    [InlineData (14, 5, 9)]
    public void TesteSubtrair(int val1,  int val2, int resultado)
    {
        Calculadora calc = construirClasse();

        int resultadoTest = calc.subtrair(val1,val2);

        Assert.Equal(resultado, resultadoTest);
    }

    [Theory]
    [InlineData (1, 2, 2)]
    [InlineData (3, 3, 9)]
    public void TesteMultiplicar(int val1,  int val2, int resultado)
    {
        Calculadora calc = construirClasse();

        int resultadoTest = calc.multiplicar(val1,val2);

        Assert.Equal(resultado, resultadoTest);
    }

    [Theory]
    [InlineData (6, 2, 3)]
    [InlineData (45, 5, 9)]
    public void Testedividir(int val1,  int val2, int resultado)
    {
        Calculadora calc = construirClasse();

        int resultadoTest = calc.dividir(val1,val2);

        Assert.Equal(resultado, resultadoTest);
    }

    [Fact]
    public void TestarDivisaoPorZero()
    {
        Calculadora calc = construirClasse();
        Assert.Throws<DivideByZeroException>(
            () => calc.dividir(3,0)
        );
    }

    [Fact]
    public void TestarHistorico()
    {
        Calculadora calc = construirClasse();

        calc.somar(1,2);
        calc.subtrair(3,2);
        calc.multiplicar(3,7);
        calc.dividir(9,3);

        var lista = calc.historico();

        Assert.NotEmpty(calc.historico());
        Assert.Equal(3, lista.Count);
    }
}   
