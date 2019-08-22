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
        [Required(ErrorMessage = "{0} necessário")]
        public string Alimento { get; set; }
        [DataType(DataType.Time)]
        //      [DataType(DataType.Duration)]
        [Required(ErrorMessage = "{0} necessário")]
        [Display(Name = "Tempo (Minuto:Segundo)")]
        //               [DisplayFormat(DataFormatString = "{0:mm\\:ss}", ApplyFormatInEditMode = true)]
        //        [DisplayFormat(DataFormatString = "{0:t}")]
        public TimeSpan Tempo { get; set; }
        [Required(ErrorMessage = "{0} necessária")]
        [Range(1, 10, ErrorMessage = "Potência mínima permitida é {1}, máxima {2}")]
        public int Potencia { get; set; } = 10;

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
        public List<string> ExecutarAquecimento()
        {
            
            double minutos = Tempo.Hours;
            double segundos =Tempo.Minutes;
            double totalSegundos;
            List<string> stringFinal = new List<string>();

            if (minutos > 0)
            {
                totalSegundos = (60 * minutos) + segundos;
            }
            else
            {
                totalSegundos = segundos;
            }
            string alimento = Alimento;

            for (int i = 1; i <= totalSegundos; i++)
            {
                if (alimento.Length > 300)
                {
                    stringFinal.Add(alimento);
                    alimento = null;
                }
                alimento += new string('.', Potencia);
            }
            stringFinal.Add(alimento);
            return stringFinal;
        }

    }
}
