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
            var potencia = aquecimento.Potencia;

            if ((minutos > 2) || (segundos < 1 && minutos < 1) || (minutos >= 2 && segundos > 0) || (minutos == 0 && segundos == 0))
            {
                throw new TempoException("O tempo deve estar entre 2 Minutos(02:00) e 1 Segundo (00:01)");
            }
            if (potencia < 1 || potencia> 10)
            {
                throw new PotenciaException("Potencia Minima permitida: 1, Maxima permitida : 10");
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
