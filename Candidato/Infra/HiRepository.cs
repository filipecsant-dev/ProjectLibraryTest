using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Candidato.Entities;

namespace Candidato.Infra
{
    public static class HiRepository
    {
        public static List<Casa> GenerateDataCasa()
        {
            var casas = new List<Casa>();
            Random rnd = new Random();
            for (int i = 0; i < 20; i++)
            {
                casas.Add(new Casa(rnd.Next(10000000, 99999999).ToString(), $"Rua {i.ToString().PadLeft(1, '0')}", rnd.Next(1, 20), rnd.Next(1, 10)));
            }

            return casas;
        }
    }
}