using System.ComponentModel.DataAnnotations;

namespace EcoImpacto.Communication.Requests
{
    public class RequestCalculatorResultJson
    {
        [Key]
        public double ConsumoEnergiaKWh { get; set; }
        public double ConsumoGasM3 { get; set; }
        public double ConsumoCombustivelLitros { get; set; }
        public double ConsumoVeiculoKmPorLitro { get; set; }
        public double TransportePublicoKm { get; set; }
        public int PraticasReciclagem { get; set; }
        public string NomeUsuario { get; set; } = string.Empty;
        public string EmailUsuario { get; set; } = string.Empty;
    }
}
