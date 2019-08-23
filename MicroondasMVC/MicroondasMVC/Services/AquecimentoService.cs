using MicroondasMVC.Models;
using MicroondasMVC.Services.Exceptions;

namespace MicroondasMVC.Services
{
    public class AquecimentoService
    {
        public Aquecimento AqueceAlimento(Aquecimento aquecimento)
        {
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
            return aquecimento;
        }
        public Aquecimento InicioRapido(Aquecimento aquecimento)
        {
            if (string.IsNullOrEmpty(aquecimento.Alimento))
            {
                throw new StringVaziaException("Não é possivel iniciar o aquecimento sem informar o Alimento");
            }
            aquecimento.AquecimentoRapido(); //adiciona parametros de aquecimento rapido nos atributos de potencia e tempo
            AqueceAlimento(aquecimento);
            return aquecimento;
        }
        
       
    }
}
