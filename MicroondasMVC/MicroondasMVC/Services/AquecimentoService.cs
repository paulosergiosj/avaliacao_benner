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
        public List<Aquecimento> aquecimentos { get; set; }
        public AquecimentoService(){}

        public int Id { get; set; } = 1;
        public Aquecimento AqueceAlimento(Aquecimento aquecimento)
        {
            var minutos = aquecimento.Tempo.Hours;
            var segundos = aquecimento.Tempo.Minutes;

            if ((minutos > 2 || (segundos < 1 && minutos < 1) || (minutos >= 2 && segundos > 0)))
            {
                throw new TempoException("O tempo não pode ser maior que 2 minutos nem menor que 1 segundo");
            }
            aquecimento.ID = Id;
            aquecimentos.Add(aquecimento);
            Id++;
            return aquecimento;
        }
    }
}
