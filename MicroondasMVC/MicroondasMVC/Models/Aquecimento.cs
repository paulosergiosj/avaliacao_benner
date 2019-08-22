using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using System.Globalization;

namespace MicroondasMVC.Models
{
    public class Aquecimento
    {
        public int ID { get; set; }
        [Required(ErrorMessage ="{0} necessário")]
        public string Alimento { get; set; }
        [DataType(DataType.Time)]
        [Required(ErrorMessage = "{0} necessário")]
        [Display(Name ="Tempo (Minuto:Segundo)")]

        public TimeSpan Tempo { get;  set; }
        [Required(ErrorMessage = "{0} necessária")]
        [Range(1,10, ErrorMessage ="Potência mínima permitida é {1}, máxima {2}")]
        public int Potencia { get;  set; } = 10;

        public Aquecimento() { }

        public Aquecimento(string alimento, TimeSpan tempo, int potencia)
        {
            Alimento = alimento;
            Tempo = tempo;
            Potencia = potencia;
        }
        public void AquecimentoPadrao()
        {
            TimeSpan valorPadrao = new TimeSpan(00, 30, 00);
            Tempo = valorPadrao;
            Potencia = 8;
        }
    }
}
