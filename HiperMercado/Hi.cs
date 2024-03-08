using HiperMercado.Services;

namespace HiperMercado
{
    public static class Hi
    {
        public static double formulaMagica(double custo, int validade) 
        {
            try
            {
                if(custo == 0 || validade == 0)
                return 0;

                double custoDepesas = HiServices.CustoPorDespesas(custo);
                double custoPorValidade = HiServices.CustoPorValidade(validade);
                double preco = HiServices.CustoFinal(custo, custoDepesas + custoPorValidade);
            
                return preco;
            }
            catch(Exception ex)
            {
                throw new Exception("Algo ocorreu fora do esperado. Consulte a equipe responsável!");
            }
        }
    }
}
