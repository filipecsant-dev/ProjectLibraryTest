using HiperMercado.Infra;

namespace HiperMercado.Services
{
    public static class HiServices
    {
        public static double CustoPorDespesas(double custos)
        {
            var despesas = HiRepository.GeneratePorDespesas();
            return custos + despesas.Sum(x => x.Custo);
        }

        public static double CustoPorValidade(int validade)
        {
            var custosValidade = HiRepository.GenerateCustoPorValidade();
            var custo = custosValidade.Aggregate((x, y) => Math.Abs(x.Key - validade) < Math.Abs(y.Key - validade) ? x : y);
            return custo.Value;
        }

        public static double CustoFinal(double custoInicial, double custosAdicional)
        {
            return custoInicial + custosAdicional;
        }
    }
}