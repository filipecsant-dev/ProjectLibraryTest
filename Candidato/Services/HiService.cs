using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Candidato.Entities;
using Candidato.Infra;

namespace Candidato.Services
{
    public static class HiService
    {
        public static List<Casa> GetCasa()
        {
            return HiRepository.GenerateDataCasa();
        }

        public static List<Rua> GetRuasVisita(List<Casa> casas)
        {
            var ruas = new Dictionary<Rua, int>();
            foreach(var casa in casas)
            {
                ruas.Add(casa.rua, casa.totalEleitores);
            }
            var ruasOrdenadas = ruas.OrderByDescending(x => x.Value);
            
            return ruasOrdenadas.AsEnumerable().Select(x => x.Key).ToList();
        }
    }
}