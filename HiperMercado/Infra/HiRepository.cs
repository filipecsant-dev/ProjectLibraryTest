using HiperMercado.Entities;

namespace HiperMercado.Infra
{
    public static class HiRepository
    {
        public static IEnumerable<DespesaItem> GeneratePorDespesas()
        {
            var despesaItem = new List<DespesaItem>();
            despesaItem.Add(new DespesaItem("Transporte", 5));
            despesaItem.Add(new DespesaItem("Validade", 10.5));
            despesaItem.Add(new DespesaItem("Galpão", 6));
            despesaItem.Add(new DespesaItem("Refrigeração", 12.87));
            despesaItem.Add(new DespesaItem("Manuseio", 3));

            return despesaItem;
        }

        public static Dictionary<int, double> GenerateCustoPorValidade()
        {
            var validades = new Dictionary<int, double>();
            validades.Add(30, 15);
            validades.Add(25, 13);
            validades.Add(21, 11.5);
            validades.Add(18, 10);
            validades.Add(13, 8.8);
            validades.Add(10, 7);
            validades.Add(7, 5);
            validades.Add(3, 3);
            validades.Add(1, 1);

            return validades;
        }
    }
}