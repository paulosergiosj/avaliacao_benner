using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MicroondasMVC.Models
{
    public class AquecimentoPadrao:Aquecimento
    {
        public int ID { get; set; }
        [Required(ErrorMessage = "{0} necessário")]
        public string Nome { get; set; }
        [Display(Name="Instruções")]
        [Required(ErrorMessage = "{0} necessário")]
        public string Instrucoes { get; set; }
        [Display(Name = "Caracter de Aquecimento")]
        [Required(ErrorMessage = "{0} necessário")]
        public char CaracterDeAquecimento { get; set; }

        public AquecimentoPadrao() { }

        public AquecimentoPadrao(string alimento, TimeSpan tempo, int potencia, int id, string nome, string instrucoes, char caracterDeAquecimento)
            :base(alimento,tempo,potencia)
        {
            ID = id;
            Nome = nome;
            Instrucoes = instrucoes;
            CaracterDeAquecimento = caracterDeAquecimento;
        }
    }
}
