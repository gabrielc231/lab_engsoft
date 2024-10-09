using Xunit; 
using EcoImpacto.Application.UseCases.Calculator;
using EcoImpacto.Communication.Requests;
using EcoImpacto.Communication.Responses;

public class RegisterCalculatorDataUseCaseTests
{
    [Fact] 
    public void Execute_DeveRetornarEmissaoCorreta()
    {
        
        var useCase = new RegisterCalculatorDataUseCase();
        
        var request = new RequestCalculatorResultJson
        {
            ConsumoEnergiaKWh = 100,   
            ConsumoGasM3 = 50,         
            ConsumoCombustivelLitros = 20,  
            TransportePublicoKm = 10,  
            PraticasReciclagem = 5   
        };

      
        var response = useCase.Execute(request);
        
       
        double expectedEmission = (100 * 0.223) + (50 * 2.1) + (20 * 2.3) + (10 * 0.1);
        Assert.Equal(expectedEmission, response.result, precision: 2); // Verificando o valor da emissão
    }
}
