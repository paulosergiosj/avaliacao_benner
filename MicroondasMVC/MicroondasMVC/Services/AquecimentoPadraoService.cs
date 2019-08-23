using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MicroondasMVC.Models;
using MicroondasMVC.Services.Exceptions;

namespace MicroondasMVC.Services
{
    public class AquecimentoPadraoService
    {
        public static List<AquecimentoPadrao> aquecimentos = CarregaProgramas();
        public int ID = 4;

        public bool ValidaAlimento(int id, string alimentoAquecer)
        {
            if (string.IsNullOrEmpty(alimentoAquecer))
            {
                throw new StringVaziaException("'Alimento' necessário para validação do aquecimento");
            }
            if (AlimentoCompativel(id, alimentoAquecer))
            {
                return true;
            }
            else
            {
                throw new AlimentoIncompativelException($"Alimento {alimentoAquecer} incompatível com o programa {aquecimentos[id].Nome}." +
                    $"Compativel: {aquecimentos[id].Alimento}");
            }
        }

        public bool AlimentoCompativel(int id,string alimentoAquecer)
        {
            string alimentoChave = aquecimentos[id].Alimento.ToLower();
            string alimento = alimentoAquecer.ToLower();
            string[] palavras = alimento.Split(new char[] { ' ', '?', '!', '.', ',', ';','*','@','#','$','%','¨','-','=','+','_' });

            if (palavras.Contains(alimentoChave))
            {
                return true;
            }
            return false;
        }

        public List<AquecimentoPadrao> EncontraAlimento(string alimento)
        {
            List<AquecimentoPadrao> registros = new List<AquecimentoPadrao>();

            for (int i = 0; i <= aquecimentos.Count ; i++)
            {
               if (AlimentoCompativel(i, alimento))
                {
                    registros.Add(aquecimentos[i]);
                }
            }
            if (registros.Count == 0)
            {
                throw new NaoEncontradoException($"Não foram Encontrados Aquecimentos Cadastrados compativeis com {alimento}");
            }
            return registros;

        }

        public void InsereAquecimentoPadrao(AquecimentoPadrao aquecimento)
        {
            aquecimento.ID = ID;
            ID++;
            aquecimentos.Add(aquecimento);
        }
        public static List<AquecimentoPadrao> CarregaProgramas()//Carrega os aquecimentos padrões - Nivel 2
        {
            var newAquecimento = new List<AquecimentoPadrao>();
            AquecimentoPadrao a1 = new AquecimentoPadrao("Frango", new TimeSpan(01, 25, 00), 5,0, "Cozinha Frango", "Frango deve estar Descongelado", '+');
            AquecimentoPadrao a2 = new AquecimentoPadrao("Peixe", new TimeSpan(02, 00, 00), 6, 1,"Fazer Peixe", "Peixe pode ser aquecido com ou sem espinhas", '$');
            AquecimentoPadrao a3 = new AquecimentoPadrao("Arroz", new TimeSpan(01, 15, 00), 3,2, "Aquecer Arroz", "O arroz deve estar pré cozido", '*');
            AquecimentoPadrao a4 = new AquecimentoPadrao("Bife", new TimeSpan(01, 40, 00), 4,3, "Aquecer Bife", "O bife deve estar temperado", '&');
            AquecimentoPadrao a5 = new AquecimentoPadrao("Feijão", new TimeSpan(00, 30, 00), 2,4, "Cozinhar Feijão", "O feijão deve ser colocado num recipiente adequado", '#');
            newAquecimento.Add(a1);
            newAquecimento.Add(a2);
            newAquecimento.Add(a3);
            newAquecimento.Add(a4);
            newAquecimento.Add(a5);

            return newAquecimento;
        }
    }
}
