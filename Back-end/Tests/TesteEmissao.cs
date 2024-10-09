using Xunit;

public class EmissaoCarbonoTests
{
    [Fact] 
    public void CalcularEmissaoCarbono_DeveRetornarValorCorreto()
    {
       
        var dados = new DadosImpacto
        {
            ConsumoEnergiaKWh = 100,   
            ConsumoGasM3 = 50,        
            ConsumoCombustivelLitros = 20,  
            TransportePublicoKm = 10   
        };

        var calculadora = new CalculadoraCarbono();
        
   
        double resultado = calculadora.CalcularEmissaoCarbono(dados);
        
        
        double resultadoEsperado = (100 * 0.233) + (50 * 2.1) + (20 * 2.3) + (10 * 0.1);
        Assert.Equal(resultadoEsperado, resultado, precision: 2); 
    }
}
