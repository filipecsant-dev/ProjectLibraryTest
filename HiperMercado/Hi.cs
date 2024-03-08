using HiperMercado.Services;

namespace HiperMercado
{
    public static class Hi
    {
        public static double formulaMagica(double custo, int validade) 
        {
            double custoDepesas = HiServices.CustoPorDespesas(custo);
            double custoPorValidade = HiServices.CustoPorValidade(validade);
            double preco = HiServices.CustoFinal(custo, custoDepesas + custoPorValidade);
           
            return preco;
        }
    }
}
