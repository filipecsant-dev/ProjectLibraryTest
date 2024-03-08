using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HiperMercado.Entities
{
    public class DespesaItem
    {
        public string Descricao { get; private set; }
        public double Custo { get; private set; }

        public DespesaItem(string descricao, double custo)
        {
            Descricao = descricao;
            Custo = custo;
        }
    }
}