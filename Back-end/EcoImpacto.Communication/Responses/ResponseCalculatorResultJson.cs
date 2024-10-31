using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EcoImpacto.Communication.Responses
{
    [Table("EcoImpactoResults")]
    public class ResponseCalculatorResultJson
    {
        [Key]
        public string UserName { get; set; }
        public string UserEmail { get; set; }
        public double result { get; set; }
        public string worstSector { get; set; }
    }
}
