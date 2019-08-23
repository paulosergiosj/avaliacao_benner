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
        public List<AquecimentoPadrao> aquecimentos = CarregaProgramas();
        public int ID = 4;

        public bool AlimentoCompativel(int id,string alimentoAquecer)
        {
            string alimentoChave = aquecimentos[id].Alimento.ToLower();
            string alimento = alimentoAquecer.ToLower();

            if (string.IsNullOrEmpty(alimento))
            {
                throw new StringVaziaException("'Alimento' necessário para validação do aquecimento");
            }
            string[] palavras = alimento.Split(new char[] { ' ', '?', '!', '.', ',', ';','*','@','#','$','%','¨','-','=','+','_' });

            if (!palavras.Contains(alimentoChave))
            {
                throw new AlimentoIncompativelException($"Alimento {alimento} incompatível com o programa {aquecimentos[id].Nome}");
            }
            return true;
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
