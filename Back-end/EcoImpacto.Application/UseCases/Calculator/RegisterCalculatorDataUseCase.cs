using EcoImpacto.Communication.Requests;
using EcoImpacto.Communication.Responses;

namespace EcoImpacto.Application.UseCases.Calculator;
public class RegisterCalculatorDataUseCase
{
    public ResponseCalculatorResultJson Execute(RequestCalculatorResultJson request)
    {
        double energyEmission = request.ConsumoEnergiaKWh * 0.223;
        double gasEmission = request.ConsumoGasM3 * 2.1;
        double fuelEmission = request.ConsumoCombustivelLitros * 2.3;
        double publicTransportEmission = request.TransportePublicoKm * 0.1;
        double totalEmission = energyEmission + gasEmission + fuelEmission + publicTransportEmission;

        return new ResponseCalculatorResultJson
        {
            result = totalEmission,
            recyclingN = request.PraticasReciclagem
        };

    }

}

