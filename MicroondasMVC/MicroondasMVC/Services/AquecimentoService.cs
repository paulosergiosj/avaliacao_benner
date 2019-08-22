using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MicroondasMVC.Models;
using MicroondasMVC.Services.Exceptions;
using MicroondasMVC.Data;

namespace MicroondasMVC.Services
{
    public class AquecimentoService
    {
        public List<Aquecimento> aquecimentos = new List<Aquecimento>();
        public int Id { get; set; } 
        public Aquecimento AqueceAlimento(Aquecimento aquecimento)
        {
            Id++;
            var minutos = aquecimento.Tempo.Hours;
            var segundos = aquecimento.Tempo.Minutes;

            if ((minutos > 2) || (segundos < 1 && minutos < 1) || (minutos >= 2 && segundos > 0))
            {
                throw new TempoException("O tempo não pode ser maior que 2 minutos nem menor que 1 segundo");
            }
            aquecimento.ID = Id;
            aquecimentos.Add(aquecimento);
            return aquecimento;
        }
        public Aquecimento InicioRapido(Aquecimento aquecimento)
        {
            aquecimento.AquecimentoPadrao();
            AqueceAlimento(aquecimento);
            return aquecimento;
        }
    }
}
